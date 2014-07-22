using System.ComponentModel.DataAnnotations;
using Sagua.Jinson.Global.Domain;

namespace Sagua.Jinson.Server.DB.Models
{
    public class Shop
    {
        [Key]
        public long ShopId
        {
            get;
            set;
        }

        public long AcountId
        {
            get;
            set;
        }
 
        public string Title
        {
            get;
            set;
        }
        public string Url
        {
            get;
            set;
        }

        public ShopType ShopType
        {
            get;
            set;
        }
        
    }
}