using FoodDeliveryApp.MVVM.View;
using Microsoft.Maui.Controls;
using System;

namespace FoodDevApp
{
    public partial class Food2 : ContentPage
    {
        public Food2()
        {
            InitializeComponent();
        }

        private void FoodCart_Clicked(object sender, EventArgs e)
        {
            // Navigate to the CheckoutPage and pass the cart items
            Navigation.PushAsync(new CheckOut(App.CartItems));
        }

        private void Box_Tapped(int boxNumber)
        {
            switch (boxNumber)
            {
                case 1:
                    Navigation.PushAsync(new MainPage());
                    break;
                case 2:
                    Navigation.PushAsync(new MainPage2());
                    break;
                case 3:
                    Navigation.PushAsync(new MainPage3());
                    break;
                case 4:
                    Navigation.PushAsync(new MainPage4());
                    break;
                case 5:
                    Navigation.PushAsync(new MainPage5());
                    break;
                case 6:
                    Navigation.PushAsync(new MainPage6());
                    break;
                case 7:
                    Navigation.PushAsync(new MainPage7());
                    break;
                case 8:
                    Navigation.PushAsync(new MainPage8());
                    break;
                case 9:
                    Navigation.PushAsync(new MainPage9());
                    break;
                default:
                    break;
            }
        }

        private void box1_Tapped(object sender, TappedEventArgs e)
        {
            Box_Tapped(1);
        }

        private void box2_Tapped(object sender, TappedEventArgs e)
        {
            Box_Tapped(2);
        }

        private void box3_Tapped(object sender, TappedEventArgs e)
        {
            Box_Tapped(3);
        }

        private void box4_Tapped(object sender, TappedEventArgs e)
        {
            Box_Tapped(4);
        }

        private void box5_Tapped(object sender, TappedEventArgs e)
        {
            Box_Tapped(5);
        }

        private void box6_Tapped(object sender, TappedEventArgs e)
        {
            Box_Tapped(6);
        }

        private void box7_Tapped(object sender, TappedEventArgs e)
        {
            Box_Tapped(7);
        }

        private void box8_Tapped(object sender, TappedEventArgs e)
        {
            Box_Tapped(8);
        }

        private void box9_Tapped(object sender, TappedEventArgs e)
        {
            Box_Tapped(9);
        }
    }
}
