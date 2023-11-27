using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

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

            foreach (var item in cartItems)
            {
                OrderSummaryLabel.Text += $"{item.ItemName} - Price: ${item.ItemPrice}\n";
            }

            OrderSummaryLabel.Text += $"Total Items: {cartItems.Count}";
        }
    }
}