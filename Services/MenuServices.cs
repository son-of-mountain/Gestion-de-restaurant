using RestaurantApp.Models;

namespace RestaurantApp.Services;

public class MenuServices
{
    public static List<Dish> GetMenu()
    {
        return new List<Dish>
        {
            new Dish
            {
                Id = 1, Name = "Tajine berqoq", Category = "Tajine", Description = "Tajine avec Deghmira", Price = 50
            },
            new Dish
            {
                Id = 2, Name = "Spaghetti Carbonara", Category = "Pasta", Description = "Cream, egg, pancetta",
                Price = 10.50m
            },
            new Dish
            {
                Id = 3, Name = "Tiramisu", Category = "Dessert", Description = "Coffee-flavored dessert", Price = 5.00m
            }
        };
    }
}