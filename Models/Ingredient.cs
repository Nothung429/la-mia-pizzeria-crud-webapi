using System.ComponentModel.DataAnnotations;
using la_mia_pizzeria_crud_webapi.Models;

public class Ingredient
{
    public int Id { get; set; }
    public string? Name { get; set; }

    //MANY-TO-MANY
    public List<Pizza>? Pizzas { get; set; }

    public Ingredient()
    {

    }
}