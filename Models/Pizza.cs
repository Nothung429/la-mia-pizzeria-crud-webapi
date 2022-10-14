using System.ComponentModel.DataAnnotations;
using la_mia_pizzeria_crud_webapi.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

public class Pizza
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    [StringLength(50, ErrorMessage = "Il nome non può avere più di 25 caratteri")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    [StringLength(200, ErrorMessage = "La descrizione non può avere più di 25 caratteri")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Image { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    [Range(0.99,99.99, ErrorMessage = "Non esagerare con il prezzo")]
    public double? Price { get; set; }

    //ONE-TO-MANY
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    //MANY-TO-MANY
    public List<Ingredient>? Ingredients { get; set; }

    public Pizza()
    {

    }
    public Pizza(string? name, string? description, string? image, double? price)
    {
        Name = name;
        Description = description;
        Image = image;
        Price = price;
    }
}
