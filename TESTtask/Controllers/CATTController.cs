using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TESTtask.Data;

namespace TESTtask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CATTController : ControllerBase
    {
        ApplicationDbContext context = new ApplicationDbContext();


         [HttpGet]
        public IActionResult getAll()
        {
         
           

            

     }
}
