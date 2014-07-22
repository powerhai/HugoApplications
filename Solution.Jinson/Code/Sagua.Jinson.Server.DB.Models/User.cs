using System.ComponentModel.DataAnnotations;

namespace Sagua.Jinson.Server.DB.Models
{
    public class User
	{
		[Key]
		public long UserId { get; set; }
		public string Name { get; set; }
		public string Tel { get; set; }   
		public string Address { get; set; }
		public string MobileNumber { get; set; }
//
//		[Required]
//		public virtual Account Account { get; set; }
//		[Required]
//		public virtual UserPhoto Photo { get; set; }
		  
	}


}

