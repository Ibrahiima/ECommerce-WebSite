using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace E_commerce.Controllers.CategoryController
{
    [ApiController]
    [Route("api/CategoryController/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _CategoryService;

        public CategoryController(ICategoryService CategoryService)
        {
            _CategoryService = CategoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDTOs>>> GetAllCategorys()
        {
            var Categorys = await _CategoryService.GetAllAsync();
            if (Categorys == null)
            {
                return Ok(new List<CategoryDTOs>());
            }
            return Ok(Categorys);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDTOs>> GetCategoryById(int id)
        {
            var Category = await _CategoryService.GetByIdAsync(id);
            if (Category == null)
            {
                return NotFound();
            }
            return Ok(Category);
        }

        [HttpPost]
        public async Task<ActionResult<CategoryDTOs>> CreateCategory(CategoryDTOs CategoryDTO)
        {
            var createdCategory = await _CategoryService.CreateAsync(CategoryDTO);

            return Ok(createdCategory);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CategoryDTOs CategoryDTO)
        {
            var existingDto = await _CategoryService.GetByIdAsync(id);
            if (existingDto == null)
            {
                return NotFound();
            }
            await _CategoryService.UpdateAsync(CategoryDTO);
            return Ok("Updated Successfuly");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _CategoryService.DeleteAsync(id);
            return Ok("Deleted Successfuly");
        }
    }
}
