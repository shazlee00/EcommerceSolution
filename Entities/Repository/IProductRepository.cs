﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
	public interface IProductRepository: IGRepository<Product>
	{
		void Update(Product product);
	}
	
}
