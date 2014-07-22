using System.ComponentModel.DataAnnotations;
using Sagua.Jinson.Global.Domain;

namespace Sagua.Jinson.Server.DB.Models
{
    public class Account
	{
		[Key]
		public long UserId { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }

        public UserType UserType
        {
            get;
            set;
        }

        public string QQ
        {
            get;
            set;
        }

        public string Tel
        {
            get;
            set;
        }

        public string Mail
        {
            get;
            set;
        }


	}
}
