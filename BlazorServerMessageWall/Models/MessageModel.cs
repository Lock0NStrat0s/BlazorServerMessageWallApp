using System.ComponentModel.DataAnnotations;

namespace BlazorServerMessageWall.Models;

public class MessageModel
{
    [Required]
    [StringLength(100, MinimumLength = 5)]
    public string Message { get; set; }
}
