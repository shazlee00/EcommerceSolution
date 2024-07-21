﻿using Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Repository
{
	public interface ICategoryRepository: IGRepository<Category>
	{
		void Update(Category category);
	}
	
}
