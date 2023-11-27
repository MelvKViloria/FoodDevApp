using Microsoft.Maui.Controls;
using System;

namespace FoodDevApp
{
    public partial class MainPage6 : ContentPage
    {
        public MainPage6()
        {
            InitializeComponent();
        }

        private void AddToCartButton_Clicked(object sender, EventArgs e)
        {
            // Add the selected item to the cart
            var selectedItem = new
            {
                ItemName = "Veggie Burger",
                ItemPrice = 10.5, // Set the actual price
                AddedFromMainPage = true
            };

            App.CartItems.Add(selectedItem);

            // Navigate back to the FoodSelection page
            Navigation.PopAsync();
        }
    }
}
