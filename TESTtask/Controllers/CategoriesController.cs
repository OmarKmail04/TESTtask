using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TESTtask.Data;
namespace TESTtask.Models
namespace TESTtask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ApplicationDbContext context = new ApplicationDbContext();


        [HttpGet]
        public IActionResult getAll()
        {

            var categories = context.Category.ToList();


            if (categories.Count == 0)
            {
                return NotFound();
            }

            return Ok(categories);


        }
         
         
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var category = _productService.GetById(id);
            if (category == null) return NotFound();

            
            return Ok(category);
        }
    }
}
