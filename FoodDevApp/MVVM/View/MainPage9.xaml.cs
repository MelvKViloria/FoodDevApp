using Microsoft.Maui.Controls;
using System;

namespace FoodDevApp
{
    public partial class MainPage9 : ContentPage
    {
        public MainPage9()
        {
            InitializeComponent();
        }

        private void AddToCartButton_Clicked(object sender, EventArgs e)
        {
            // Add the selected item to the cart
            var selectedItem = new
            {
                ItemName = "Water",
                ItemPrice = 2, // Set the actual price
                AddedFromMainPage = true
            };

            App.CartItems.Add(selectedItem);

            // Navigate back to the FoodSelection page
            Navigation.PopAsync();
        }
    }
}
