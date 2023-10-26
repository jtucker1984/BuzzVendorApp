namespace BizzOnBuzzVM1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new OrdersPage());
    }

    async private void Inventory_Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Inventory());
    }
}

