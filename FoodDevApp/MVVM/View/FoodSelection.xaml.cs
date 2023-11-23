namespace FoodDevApp;

public partial class FoodSelection : ContentPage
{
	public FoodSelection()
	{
		InitializeComponent();
	}

    private void StartBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FoodSelection());
    }

    private void FoodCart_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FoodSelection());
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
        Navigation.PushAsync(new MainPage3());
    }
    private void box4_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage4());
    }
    private void box5_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage5());
    }
    private void box6_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage6());
    }
    private void box7_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage7());
    }
    private void box8_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage8());
    }
    private void box9_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new MainPage9());
    }

}