using AutoMapper;
using DTOs;
using Models;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   

    public class ProductService : GenericService<Product, ProductDTOs>, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository, IGenericRepository<Product> repository, IMapper mapper)
            : base(repository, mapper)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductDTOs>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var products = await _productRepository.GetProductsByCategoryIdAsync(categoryId);
            return _mapper.Map<List<ProductDTOs>>(products);
        }

        public async Task<List<ProductDTOs>> GetDiscountedProductsAsync()
        {
            var discountedProducts = await _productRepository.GetDiscountedProductsAsync();
            return _mapper.Map<List<ProductDTOs>>(discountedProducts);
        }


    }




}
