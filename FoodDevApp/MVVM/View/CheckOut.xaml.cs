using Microsoft.Maui.Controls;
using System;
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
            OrderSummaryLabel.Text += $"Total Items: {cartItems.Count}\n";
            OrderSummaryLabel.Text += $"Total Price: ${totalPrice:F2}";
        }

        private void Order_Clicked(object sender, EventArgs e)
        {

        }
    }
}
