using RestaurantApp.Models;
using RestaurantApp.Services;

namespace RestaurantApp.Views;

public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
        DishesList.ItemsSource = MenuService.GetMenu();
    }
}