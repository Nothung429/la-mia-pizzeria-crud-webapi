using System.ComponentModel.DataAnnotations;
using la_mia_pizzeria_crud_webapi.Models;

public class Message
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Text { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? EMail { get; set; }

    public Message()
    {

    }
}