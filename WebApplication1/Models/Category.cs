using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Category Name is required")]
    [DisplayName("Category Name")]
    [MaxLength(30)]
    public string Name { get; set; }
    [DisplayName("Diplay Order")]
    [Range(1, 100, ErrorMessage = "Please enter a number between 1 and 100")]
    public int DisplayOrder { get; set; }
}