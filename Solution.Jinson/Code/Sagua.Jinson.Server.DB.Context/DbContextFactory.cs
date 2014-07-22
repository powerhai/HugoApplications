namespace Sagua.Jinson.Server.DB.Context
{




	public class  DbContextFactory
	{
		public static WebDbContext CreateDbContext()
		{
			var context = new WebDbContext(); 
			context.Database.CreateIfNotExists();
			context.Configuration.LazyLoadingEnabled = false;

			return context;
		}
	}
}

