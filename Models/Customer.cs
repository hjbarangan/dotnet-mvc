using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Customer
{
    public int Id { get; set; }
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    [DataType(DataType.Date)]
    public DateTime Birthdate { get; set; }
    
}