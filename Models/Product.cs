namespace ecommerce.Models;
using System.ComponentModel.DataAnnotations;

public class Product{

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
     public string Description { get; set; } = string.Empty;
    public string qtStoque { get; set; } = string.Empty;
    public float Price { get; set; }
    public string Date { get; set; } = string.Empty;
    public Boolean Code_user { get; set; } = false;


}