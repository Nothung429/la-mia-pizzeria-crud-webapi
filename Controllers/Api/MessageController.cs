using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace la_mia_pizzeria_crud_webapi.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        PizzeriaContext context;
        public MessageController()
        {
            context = new PizzeriaContext();
        }

        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            context.Message.Add(message);
            context.SaveChanges();

            return Ok();
        }
    }
}
