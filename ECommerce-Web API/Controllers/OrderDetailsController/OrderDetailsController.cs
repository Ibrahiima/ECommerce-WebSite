using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace E_commerce.Controllers.OrderDetailsController
{
    [ApiController]
    [Route("api/CartController/[controller]")]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailService _OrderDetailsService;

        public OrderDetailsController(IOrderDetailService OrderDetailsService)
        {
            _OrderDetailsService = OrderDetailsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDetailDTOs>>> GetAllOrderDetailss()
        {
            var OrderDetailss = await _OrderDetailsService.GetAllAsync();
            if (OrderDetailss == null)
            {
                return Ok(new List<OrderDetailDTOs>());
            }
            return Ok(OrderDetailss);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetailDTOs>> GetOrderDetailsById(int id)
        {
            var OrderDetails = await _OrderDetailsService.GetByIdAsync(id);
            if (OrderDetails == null)
            {
                return NotFound();
            }
            return Ok(OrderDetails);
        }

        [HttpPost]
        public async Task<ActionResult<OrderDetailDTOs>> CreateOrderDetails(OrderDetailDTOs OrderDetailsDTO)
        {
            var createdOrderDetails = await _OrderDetailsService.CreateAsync(OrderDetailsDTO);

            return Ok(createdOrderDetails);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, OrderDetailDTOs OrderDetailsDTO)
        {
            var existingDto = await _OrderDetailsService.GetByIdAsync(id);
            if (existingDto == null)
            {
                return NotFound();
            }
            await _OrderDetailsService.UpdateAsync(OrderDetailsDTO);
            return Ok("Updated Successfuly");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetails(int id)
        {
            await _OrderDetailsService.DeleteAsync(id);
            return Ok("Deleted Successfuly");
        }
    }


}

