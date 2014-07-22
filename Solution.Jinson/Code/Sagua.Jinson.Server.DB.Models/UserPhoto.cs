using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sagua.Jinson.Server.DB.Models
{

	public class UserPhoto
	{
		[Key]
		public long UserId { get; set; }

#if MYSQL
        [Column(TypeName = "blob")]
#endif
#if SQLSERVER
        [Column(TypeName = "image")]
#endif
        public byte[] Photo { get; set; } 

	}
	
}
