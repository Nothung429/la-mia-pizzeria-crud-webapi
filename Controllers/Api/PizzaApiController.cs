using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_crud_webapi.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaApiController : ControllerBase
    {
        PizzeriaContext context;

        public PizzaApiController()
        {
            context = new PizzeriaContext();
        }

        [HttpGet]
        public ActionResult GetPizza()
        {
            List<Pizza> pizza = context.Pizza.ToList();

            return Ok(pizza);
        }
    }
}
