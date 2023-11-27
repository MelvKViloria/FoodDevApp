namespace FoodDevApp;

using FoodDeliveryApp.MVVM.View;
using FoodDevApp.MVVM.View;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LogInPage());
        }
    }
