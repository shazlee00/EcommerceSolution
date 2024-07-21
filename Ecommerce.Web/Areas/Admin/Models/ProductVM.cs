using Ecommerce.Entities.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Web.Areas.Admin.Models
{
	public class ProductVM
	{
		public int Id { get; set; }
		[MaxLength(100)]
		[Required]
		public string Name { get; set; }

		[MaxLength(100)]
		public string Description { get; set; }

		[Display(Name = "Product Image")]

		[ValidateNever]
		public string? Img { get; set; }

		[Required]
		
		public decimal Price { get; set; }
		
		public int CategoryId { get; set; } = 0;

		public IEnumerable<SelectListItem>? Categories { get; set; }
		
	}
}
