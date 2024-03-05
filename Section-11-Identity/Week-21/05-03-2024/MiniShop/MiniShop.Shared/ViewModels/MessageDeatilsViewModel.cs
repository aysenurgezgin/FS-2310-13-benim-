using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels
{
    public class MessageDeatilsViewModel
    {
        public int Id { get; set; }
        public DateTime SendingDate { get; set; } = DateTime.Now;
        public string Text { get; set; }
        public string ToId { get; set; }//Kimden 
        public string ToName { get; set; }
        public string FromId { get; set; }//Kime
        public string FromName { get; set; }
        public bool IsRead { get; set; }
    }
}
