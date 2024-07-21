using Entities.Models;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entities.Models
{
	public class Category
	{
		public Category()
		{ 
			Products = new List<Product>();
		}
		public int CategoryId { get; set; }

		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }

		[MaxLength(100)]
		public string Description { get; set; }

        public DateTime CreatedTime { get; set; }=DateTime.Now;

		public List<Product> Products { get; set; } 

    }

    
}
