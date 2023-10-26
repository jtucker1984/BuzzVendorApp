namespace BizzOnBuzzVM1;

public partial class CompletedOrdersPage : ContentPage
{
	public CompletedOrdersPage()
	{
		InitializeComponent();
	}

    async private void ImageButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopToRootAsync();
    }
}