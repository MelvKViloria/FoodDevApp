using FoodDevApp.MVVM.Model;
using FoodDevApp.MVVM.Services;

namespace FoodDeliveryApp.MVVM.View;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private void LogIn_Clicked(object sender, EventArgs e)
    {
      
        Navigation.PushAsync(new LogInPage());
    }

    private void ForgotPass_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LogInPage());
    }

    private void Registration_Clicked(object sender, EventArgs e)
    {
        string username = NameEntryField.Text;
        string email = EmailEntryField.Text;
        string password = PasswordEntryField.Text;

        User newUser = new User { UserName = username, Password = password };

        userService.AddUser(newUser);

        Navigation.PushAsync(new LogInPage());
    }
}