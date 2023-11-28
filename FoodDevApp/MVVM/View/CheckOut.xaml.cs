using Microsoft.Maui.Controls;
using System;
using Microsoft.Maui.Graphics;
using System.Collections.Generic;
using System.Linq; // Import the LINQ namespace for the Sum method

namespace FoodDevApp
{
    public partial class CheckOut : ContentPage
    {
        private readonly List<dynamic> cartItems;

        public CheckOut(List<dynamic> cartItems)
        {
            InitializeComponent();
            this.cartItems = cartItems;
            UpdateOrderSummary();
        }

        private void UpdateOrderSummary()
        {
            OrderSummaryLabel.Text = "Order Summary:\n";

            double totalPrice = 0;

            foreach (var item in cartItems)
            {
                OrderSummaryLabel.Text += $"{item.ItemName} - Price: ${item.ItemPrice}\n";
                totalPrice += item.ItemPrice;
            }
            ApplyDynamicStyles();
            OrderSummaryLabel.Text += $"Total Items: {cartItems.Count}\n";
            OrderSummaryLabel.Text += $"Total Price: ${totalPrice:F2}";

        }

        private void ApplyDynamicStyles()
        {
            OrderSummaryLabel.FontSize = 25;

        }
        private List<string> itemsList = new List<string>();

        private async void Order_Clicked(object sender, EventArgs e)
        {
            
            int numberOfItems = GetNumberOfItems(); 

            // Calculate estimated time (assuming 5 minutes per item)
            int estimatedTime = numberOfItems * 5;

            // Display the pop-up message
            await DisplayAlert("Order Confirmation", $"Your food order has been made and will arrive in {estimatedTime} minutes.", "OK");

            // Clear the items from cart
            itemsList.Clear();
        }

        private int GetNumberOfItems()
        {
            // 5 meaning the number of time it takes for each items and x it but how much items u have
            return 5;
        }

    }

}



    


