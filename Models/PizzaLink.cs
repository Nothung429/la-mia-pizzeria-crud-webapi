using la_mia_pizzeria_crud_webapi.Models;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

public class PizzaLink
{
    public Pizza? Pizza { get; set; }
    public List<Category>? Categories { get; set; }
    public List<Ingredient>? Ingredients { get; set; }
    public List<int> SelectedIngredients { get; set; }
    //public bool? Selected { get; set; }
}