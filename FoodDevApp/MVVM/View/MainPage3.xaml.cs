using Microsoft.Maui.Controls;
using System;

namespace FoodDevApp
{
    public partial class MainPage3 : ContentPage
    {
        public MainPage3()
        {
            InitializeComponent();
        }

        private void AddToCartButton_Clicked(object sender, EventArgs e)
        {
            // Add the selected item to the cart
            var selectedItem = new
            {
                ItemName = "Grilled Chicken",
                ItemPrice = 12.5, // Set the actual price
                AddedFromMainPage = true
            };

            App.CartItems.Add(selectedItem);

            // Navigate back to the FoodSelection page
            Navigation.PopAsync();
        }
    }
}
