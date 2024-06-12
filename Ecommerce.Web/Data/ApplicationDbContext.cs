using Ecommerce.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Web.Data
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}


		public DbSet<Category> categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);


			modelBuilder.Entity<Category>().HasData(
	new Category {CategoryId=1, Name = "Electronics", Description = "Electronic Items" },
	new Category {CategoryId=2, Name = "Food", Description = "Food Items" },
	new Category {CategoryId=3, Name = "Books", Description = "Books and Magazines" },
	new Category {CategoryId=4, Name = "Clothing", Description = "Apparel and Accessories" },
	new Category {CategoryId=5, Name = "Toys", Description = "Toys and Games" },
	new Category {CategoryId=6, Name = "Furniture", Description = "Home and Office Furniture" },
	new Category {CategoryId=7, Name = "Tools", Description = "Tools and Hardware" },
	new Category {CategoryId=8, Name = "Sports", Description = "Sporting Goods" },
	new Category {CategoryId=9, Name = "Beauty", Description = "Beauty and Personal Care" },
	new Category {CategoryId=11, Name = "Automotive", Description = "Automotive Parts and Accessories" }
         );


		}

	}
}
