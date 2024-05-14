using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;
using Services;

namespace E_commerce.Controllers.ProductController
{
    [ApiController]
    [Route("api/ProductController/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;

        public ProductController(IProductService ProductService)
        {
            _ProductService = ProductService;
        }

        //[HttpGet("DiscountedProducts")]
        //public async Task<ActionResult<List<ProductDTOs>>> GetDiscountedProductsAsync()
        //{
        //    var discountedProducts = await ProductService.GetDiscountedProductsAsync();
        //    return discountedProducts;
        //}



        //[HttpGet("getproductsByName")]
        //public async Task<ActionResult<List<ProductDTOs>>> getproductsByName(string prodTitle)
        //{
        //    return await ProductService.GetProductByName(prodTitle);
        //}


        [HttpGet]
        public async Task<ActionResult<List<ProductDTOs>>> GetAllProducts()
        {
            var Products = await _ProductService.GetAllAsync();
            if (Products == null)
            {
                return Ok(new List<ProductDTOs>());
            }
            return Ok(Products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTOs>> GetProductById(int id)
        {
            var Product = await _ProductService.GetByIdAsync(id);
            if (Product == null)
            {
                return NotFound();
            }
            return Ok(Product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTOs>> CreateProduct(ProductDTOs ProductDTO)
        {
            var createdProduct = await _ProductService.CreateAsync(ProductDTO);

            return Ok(createdProduct);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProductDTOs ProductDTO)
        {
            var existingDto = await _ProductService.GetByIdAsync(id);
            if (existingDto == null)
            {
                return NotFound();
            }
            await _ProductService.UpdateAsync(ProductDTO);
            return Ok("Updated Successfuly");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _ProductService.DeleteAsync(id);
            return Ok("Deleted Successfuly");
        }
    }


}

