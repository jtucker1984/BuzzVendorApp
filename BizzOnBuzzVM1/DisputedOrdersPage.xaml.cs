namespace BizzOnBuzzVM1;

public partial class DisputedOrdersPage : ContentPage
{
	public DisputedOrdersPage()
	{
		InitializeComponent();
	}

   async private void ImageButton_Clicked(object sender, EventArgs e)
    {
      await Navigation.PopToRootAsync();
    }
}