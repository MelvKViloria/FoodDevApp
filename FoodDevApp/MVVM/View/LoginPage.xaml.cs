using FoodDevApp;
using FoodDevApp.MVVM.Model;
using FoodDevApp.MVVM.Services;
using FoodDevApp.MVVM.View;

namespace FoodDeliveryApp.MVVM.View;

public partial class LogInPage : ContentPage
{

	public LogInPage()
	{
		InitializeComponent();
     


	}

    private void SignUp_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SignUpPage());

    }   

    private void ForgotPass_Clicked(object sender, EventArgs e)
    {
       

    }

    private void Login_Clicked(object sender, EventArgs e)
    {

        string username = UserNameEntry.Text;
        string password = PasswordEntry.Text;

        User user = userService.GetUser(username);


        if (user != null && user.Password == password)
        {
            Navigation.PushAsync(new FoodSelection());
        }
        else
        {
            DisplayAlert("Wrong Password", "or username"," Ok");
        }

        
    }
}