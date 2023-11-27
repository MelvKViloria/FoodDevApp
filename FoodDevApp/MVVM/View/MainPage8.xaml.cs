using Microsoft.Maui.Controls;
using System;

namespace FoodDevApp
{
    public partial class MainPage8 : ContentPage
    {
        public MainPage8()
        {
            InitializeComponent();
        }

        private void AddToCartButton_Clicked(object sender, EventArgs e)
        {
            // Add the selected item to the cart
            var selectedItem = new
            {
                ItemName = "Coke",
                ItemPrice = 3, // Set the actual price
                AddedFromMainPage = true
            };

            App.CartItems.Add(selectedItem);

            // Navigate back to the FoodSelection page
            Navigation.PopAsync();
        }
    }
}
