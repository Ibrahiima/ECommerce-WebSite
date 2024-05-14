﻿using DTOs;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IProductService : IGenericService<ProductDTOs> {

        //Task<List<ProductDTO>> GetProductsByCategoryIdAsync(int categoryId);


    }

}
