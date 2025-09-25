namespace PaxAndroid.Pages;

public partial class AddTips : ContentPage
{
	public AddTips()
	{
		InitializeComponent();
	}

    private async void NavigateBack(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

  
}