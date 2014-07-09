using System;
using System.Data.Entity;
using MySql.Data.Entity;
using Sagua.Server.DB.Models;

namespace Server.DB.Context
{
   // [DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class WebDbContext : DbContext, IDisposable
	{

		public DbSet<User> Users { get; set; }
		public DbSet<UserPhoto> UserPhotos { get; set; }
		public DbSet<Account> Accounts { get; set; }

        public WebDbContext()
            : base("name=DefaultConnection")
		{
		
		}

		static  WebDbContext()
		{
            
			#if DEBUG
			//Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WebDbContext>());

			 System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseAlways<WebDbContext>());
			#endif 
		}


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
//			modelBuilder.Entity<Clinic>().HasMany(t => t.Cures).WithRequired(p => p.Clinic).WillCascadeOnDelete(false);
//			modelBuilder.Entity<Clinic>().HasMany(t => t.Appointments ).WithRequired(p => p.Clinic).WillCascadeOnDelete(false);
//		
		}

	}
}

