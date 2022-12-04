namespace Horoscope;

public partial class NewPage1 : ContentPage
{
	public string zodiac;

	public NewPage1(string zodiacSign)
	{
		zodiac = zodiacSign;
		InitializeComponent();
	}

    private async Task LoadHoroscope()
    {
        var horoscope = await HoroscopeProcessor.LoadHoroscope(zodiac);
		zodiacSign.Text = zodiac;
		dateRange.Text = horoscope.date_range;
		currentDate.Text = horoscope.current_date;
		color.Text = horoscope.color;
		compatibility.Text = horoscope.compatibility;
		description.Text = horoscope.description;
		luckyNumber.Text = horoscope.lucky_number;
		luckyTime.Text = horoscope.lucky_time;
		mood.Text = horoscope.mood;
    }

	private async void Window_Loaded(object sender, EventArgs e)
	{
		await LoadHoroscope();
	}
}