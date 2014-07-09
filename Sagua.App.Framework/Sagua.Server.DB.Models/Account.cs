using System.ComponentModel.DataAnnotations;

namespace Sagua.Server.DB.Models
{

	public class Account
	{
		[Key]
		public long UserId { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; } 
//		public User User { get; set; }
	}
}
