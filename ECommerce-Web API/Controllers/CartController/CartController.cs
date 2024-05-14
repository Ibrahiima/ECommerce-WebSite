using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace E_commerce.Controllers.CartController
{
    [ApiController]
    [Route("api/CartController/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _CartService;

        public CartController(ICartService CartService)
        {
            _CartService = CartService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CartDTOs>>> GetAllCarts()
        {
            var Carts = await _CartService.GetAllAsync();
            if (Carts == null)
            {
                return Ok(new List<CartDTOs>());
            }
            return Ok(Carts);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CartDTOs>> GetCartById(int id)
        {
            var Cart = await _CartService.GetByIdAsync(id);
            if (Cart == null)
            {
                return NotFound();
            }
            return Ok(Cart);
        }

        [HttpPost]
        public async Task<ActionResult<CartDTOs>> CreateCart(CartDTOs CartDTO)
        {
            var createdCart = await _CartService.CreateAsync(CartDTO);

            return Ok(createdCart);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CartDTOs CartDTO)
        {
            var existingDto = await _CartService.GetByIdAsync(id);
            if (existingDto == null)
            {
                return NotFound();
            }
            await _CartService.UpdateAsync(CartDTO);
            return Ok("Updated Successfuly");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCart(int id)
        {
            await _CartService.DeleteAsync(id);
            return Ok("Deleted Successfuly");
        }
    }


}

