using Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[MaxLength]
		public string Description { get; set; }

		public string? Img { get; set; }

		[Required]
		public decimal Price { get; set; }
		[Required]
		public int CategoryId { get; set; }
		public Category Category { get; set; }
    }
}
