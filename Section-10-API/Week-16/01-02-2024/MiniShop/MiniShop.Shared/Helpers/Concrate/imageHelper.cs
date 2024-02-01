using Microsoft.AspNetCore.Http;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.Helpers.Concrate
{
    public class imageHelper : IImageHelper
    {
        //localhost:5000/wwwroot/images
        private readonly string _imagesFolder;
        public imageHelper(IWebHostEnvironment _environment)
        {
            _imagesFolder = Path.Combine(_environment.WebRootPath,"images");
        }
        public async Task<string> UploadImage(IFormFile image, string folderName)
        {
            if (image == null) 
            {
                return "Bir hata oluştu";
            }
           var targetFolder= Path.Combine(_imagesFolder, folderName);
            if (!Directory.Exists(targetFolder)) ;
            {
                Directory.CreateDirectory(targetFolder);
            }
            var fileExtension= Path.GetExtension(image.FileName);
            var fileName =$"{Guid.NewGuid()}{fileExtension}";
            var fileFullPath=Path.Combine(targetFolder, fileName);
            await using (var stream = new FileStream(fileFullPath,FileMode.Create))
            {
                image.CopyTo(stream);
            }
            return fileName;
        }

        public interface IWebHostEnvironment
        {
        }
    }
}
