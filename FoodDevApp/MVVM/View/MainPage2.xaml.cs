using Microsoft.Maui.Controls;
using System;

namespace FoodDevApp
{
    public partial class MainPage2 : ContentPage
    {
        public MainPage2()
        {
            InitializeComponent();
        }

        private void AddToCartButton_Clicked(object sender, EventArgs e)
        {
            // Add the selected item to the cart for MainPage2
            var selectedItem = new
            {
                ItemName = "Chicken Burger",
                ItemPrice = 10.5, // Set the actual price
                AddedFromMainPage = true
            };

            App.CartItems.Add(selectedItem);

            // Navigate back to the FoodSelection page
            Navigation.PopAsync();
        }
    }
}
