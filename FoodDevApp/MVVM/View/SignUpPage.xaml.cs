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
}