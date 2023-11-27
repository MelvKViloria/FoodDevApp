using Microsoft.Maui.Controls;
using System;

namespace FoodDevApp
{
    public partial class MainPage5 : ContentPage
    {
        public MainPage5()
        {
            InitializeComponent();
        }

        private void AddToCartButton_Clicked(object sender, EventArgs e)
        {
            // Add the selected item to the cart
            var selectedItem = new
            {
                ItemName = "Triple Beef",
                ItemPrice = 15.5, // Set the actual price
                AddedFromMainPage = true
            };

            App.CartItems.Add(selectedItem);

            // Navigate back to the FoodSelection page
            Navigation.PopAsync();
        }
    }
}
