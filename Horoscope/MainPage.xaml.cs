namespace Horoscope;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		ApiHelper.InitializeClient();
    }

	private void OnButtonClicked(object sender, EventArgs e)
	{
		if(picker.SelectedItem!=null)
		{
            Window infoWindow = new Window(new NewPage1(picker.SelectedItem.ToString()));
            Application.Current.OpenWindow(infoWindow);
        }
	}
}

