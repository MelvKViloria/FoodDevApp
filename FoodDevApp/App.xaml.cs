using FoodDeliveryApp.MVVM.View;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace FoodDevApp
{
    public partial class App : Application
    {
        public static List<dynamic> CartItems { get; set; } = new List<dynamic>();

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LogInPage());
        }
    }
}