using MiniShop.Core.ViewModels;
using MiniShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Abstract
{
    public interface IProductService
    {
        //Crud işlemlerini gerçekleitirecek metot imzalarını yazacağız.
        void Create(ProductViewModel model); //create(c)
        List<ProductViewModel> GetAll(bool? isHome= null, bool? isActive=null, bool? isDelete=null); //(r)read
        ProductViewModel GetById(int id);
       
        void Update(ProductViewModel model);//(u)pdate
        void HardDelete(int id);//(d)elete
       
        void SoftDelete(int id);



    }
}
