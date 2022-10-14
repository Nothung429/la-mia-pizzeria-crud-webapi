using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using la_mia_pizzeria_crud_webapi.Models;

public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    [StringLength(50, ErrorMessage = "Il nome non può avere più di 50 caratteri")]
    public string? Name { get; set; }

    //ONE-TO-MANY
    public List<Pizza>? Pizzas { get; set; }
    public Category()
    {

    }
    public Category(string name)
    {
        Name = name;
    }
}