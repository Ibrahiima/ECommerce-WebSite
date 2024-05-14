using Context;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        EDBContext _context;
        public ProductRepository(EDBContext context) : base(context)
        {
            _context = context;    
        }
        public async Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            return await _context.Products
                .Where(p => p.CategoryId == categoryId)
                .ToListAsync();
        }
        public async Task<List<Product>> GetDiscountedProductsAsync()
        {
            return await _context.Products.Where(prod => prod.IsPromoted == true).ToListAsync();
        }
        public async Task<List<Product>> GetProductByName(string ProductName)
        {
            return await _context.Products.Where(prod => prod.Title.Contains(ProductName)).ToListAsync();
        }
    }
}
