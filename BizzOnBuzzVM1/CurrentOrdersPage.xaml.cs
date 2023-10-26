namespace BizzOnBuzzVM1;

public partial class CurrentOrdersPage : ContentPage
{
	public CurrentOrdersPage()
	{
		InitializeComponent();
	}

   async private void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopToRootAsync();
    }
}