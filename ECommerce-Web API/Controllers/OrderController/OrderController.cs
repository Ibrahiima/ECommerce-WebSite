using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace E_commerce.Controllers.OrderController
{
    [ApiController]
    [Route("api/OrderController/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _OrderService;

        public OrderController(IOrderService OrderService)
        {
            _OrderService = OrderService;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDTOs>>> GetAllOrders()
        {
            var Orders = await _OrderService.GetAllAsync();
            if (Orders == null)
            {
                return Ok(new List<OrderDTOs>());
            }
            return Ok(Orders);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDTOs>> GetOrderById(int id)
        {
            var Order = await _OrderService.GetByIdAsync(id);
            if (Order == null)
            {
                return NotFound();
            }
            return Ok(Order);
        }

        [HttpPost]
        public async Task<ActionResult<OrderDTOs>> CreateOrder(OrderDTOs OrderDTO)
        {
            var createdOrder = await _OrderService.CreateAsync(OrderDTO);

            return Ok(createdOrder);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, OrderDTOs OrderDTO)
        {
            var existingDto = await _OrderService.GetByIdAsync(id);
            if (existingDto == null)
            {
                return NotFound();
            }
            await _OrderService.UpdateAsync(OrderDTO);
            return Ok("Updated Successfuly");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            await _OrderService.DeleteAsync(id);
            return Ok("Deleted Successfuly");
        }
    }


}

