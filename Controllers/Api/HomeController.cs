using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace la_mia_pizzeria_crud_webapi.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        PizzeriaContext context;
        public HomeController()
        {
            context = new PizzeriaContext();
        }

        [HttpGet]
        public IActionResult GetPizza(string? name)
        {
            IQueryable<Pizza> PizzaDB;

            if (name != null)
            {
                PizzaDB = context.Pizza.Where(pizza => pizza.Name.ToLower().Contains(name.ToLower()));
            }
            else
            {
                PizzaDB = context.Pizza;
            }

            return Ok(PizzaDB.ToList<Pizza>());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pizza pizza = context.Pizza.Where(p => p.Id == id).First();

            return Ok(pizza);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Pizza pizza = context.Pizza.Where(p => p.Id == id).First();

            context.Pizza.Remove(pizza);
            context.SaveChanges();

            return Ok(new { Message = "somebody once told me the world is gonna roll me" });
        }
    }
}