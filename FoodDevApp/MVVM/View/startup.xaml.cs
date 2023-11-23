namespace FoodDevApp;

public partial class startup : ContentPage
{
	public startup()
	{
		InitializeComponent();
	}

    private void StartBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new startup());
    }

    private void FoodCart_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new startup());
    }

    private void box1_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void box2_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage2());
    }
    private void box3_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void box4_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void box5_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void box6_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void box7_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void box8_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private void box9_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

}