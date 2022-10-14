using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_crud_webapi.Models;
using System.Reflection.Metadata.Ecma335;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace la_mia_pizzeria_crud_webapi.Controllers.Admin
{
    [Authorize]
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        PizzeriaContext context = new PizzeriaContext();

        // GET: PizzaController
        [HttpGet]
        public ActionResult Index()
        {
            List<Pizza> PizzaDB = context.Pizza.Include("Category").Include("Ingredients").ToList();

            return View(PizzaDB);
        }

        // GET: PizzaController/Show/5
        [HttpGet]
        public ActionResult Show(int Id)
        {
            Pizza pizzaSearch = context.Pizza.Where(pizza => pizza.Id == Id).Include(pizza => pizza.Category).Include(pizza => pizza.Ingredients).First();

            return View("Show", pizzaSearch);
        }

        // GET: PizzaController/Create
        [HttpGet]
        public ActionResult Create()
        {
            PizzaLink PizzaDB = new PizzaLink();

            PizzaDB.Categories = new PizzeriaContext().Category.ToList();

            PizzaDB.Ingredients = new PizzeriaContext().Ingredient.ToList();

            return View(PizzaDB);
        }

        // POST: PizzaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PizzaLink formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Categories = context.Category.ToList();
                formData.Ingredients = context.Ingredient.ToList();
                return View("Create");
            }

            formData.Pizza.Ingredients = context.Ingredient.Where(ingredient => formData.SelectedIngredients.Contains(ingredient.Id)).ToList();

            context.Pizza.Add(formData.Pizza);

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: PizzaController/Edit/5
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Pizza pizza = context.Pizza.Where(pizza => pizza.Id == Id).First();

            PizzaLink PizzaEdit = new PizzaLink();

            PizzaEdit.Pizza = pizza;

            PizzaEdit.Categories = context.Category.ToList();
            PizzaEdit.Ingredients = context.Ingredient.ToList();

            return View(PizzaEdit);
        }

        // POST: PizzaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PizzaLink formData)
        {
            if (!ModelState.IsValid)
            {
                formData.Categories = context.Category.ToList();
                formData.Ingredients = context.Ingredient.ToList();
                return View("Edit");
            }

            formData.Pizza.Id = id;
            context.Pizza.Update(formData.Pizza);

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: PizzaController/Delete/5
        [HttpGet]
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: PizzaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Pizza pizza = context.Pizza.Where(pizza => pizza.Id == id).First();

            if (pizza == null)
            {
                return View("Error");
            }

            context.Pizza.Remove(pizza);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
