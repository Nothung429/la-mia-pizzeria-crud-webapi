using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_crud_webapi.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPizza()
        {
            using (PizzeriaContext context = new PizzeriaContext())
            {
                IQueryable<Pizza> pizza = context.Pizza;
                return Ok(pizza.ToList());
            }
        }
    }
}
