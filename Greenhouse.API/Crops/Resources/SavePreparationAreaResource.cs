using System.ComponentModel.DataAnnotations;

namespace Greenhouse.API.Crops.Resources;

public class SavePreparationAreaResource
{
    [Required]
    public string Author { get; set; }
    
    [Required]
    public string Activities { get; set; }
    
    [Required]
    public float Temperature { get; set; }
    
    public string? Comment { get; set; }
    
    [Required]
    public int EmployeeId { get; set; }
}