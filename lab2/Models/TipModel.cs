using System.ComponentModel.DataAnnotations;

namespace lab2.Models;

public class TipModel
{
    [Required(ErrorMessage = "Please enter cost of meal")]
    [Range(0, 100000, ErrorMessage = "Cost of meal cannot be less than 0")]
    public double? CostOfMeal { get; set; }

    public double Tip15 { get; set; }
    public double Tip20 { get; set; }
    public double Tip25 { get; set; }

    public void CalculateTip()
    {
        Tip15 = (CostOfMeal ?? 0) * 0.15;
        Tip20 = (CostOfMeal ?? 0) * 0.20;
        Tip25 = (CostOfMeal ?? 0) * 0.25;
    }
    
}