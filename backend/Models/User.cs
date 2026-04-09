using System.ComponentModel.DataAnnotations;

namespace backend.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Email { get; set; }

    [Required]
    [MaxLength(20)]
    public string Password { get; set; }
}