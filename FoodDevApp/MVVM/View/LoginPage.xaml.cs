using FoodDevApp;

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
        Navigation.PushAsync(new FoodSelection());
    }
}