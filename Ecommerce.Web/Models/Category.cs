using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Web.Models
{
	public class Category
	{
		public int CategoryId { get; set; }

		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }

		[MaxLength(100)]
		public string Description { get; set; }

        public DateTime CreatedTime { get; set; }=DateTime.Now;

    }

    
}
