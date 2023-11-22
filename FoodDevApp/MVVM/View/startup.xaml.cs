namespace FoodDevApp;

public partial class startup : ContentPage
{
	public startup()
	{
		InitializeComponent();
	}

    private void StartBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}