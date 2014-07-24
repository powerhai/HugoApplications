using System.ComponentModel.DataAnnotations;

namespace Sagua.Jinson.Server.DB.Models
{
    public class Server
    {
        [Key]
        public long ServerId
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }
        public bool IsOpenning
        {
            get;
            set;
        }
    }
}