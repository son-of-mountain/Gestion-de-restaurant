namespace RestaurantApp.Models;

// to display and manage dishes
public class Dish
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Category {get; set;}
    public string Description {get; set;}
    public decimal Price {get; set;}
    public string ImageUrl {get; set;}
}