using System.ComponentModel;

namespace Layout;

public partial class NewPage5 : ContentPage
{
	public NewPage5()
	{
		InitializeComponent();
	}
	private async void LiczbaOsob(object? sender, EventArgs e)
	{
		var osobyVisible = podziel.IsToggled;

		if (osobyVisible == true) {
			osoby.IsVisible = true;
			naosobesuma.IsVisible = true;
		}
		if (osobyVisible == false)
		{
			osoby.IsVisible = false;
			naosobesuma.IsVisible = false;
		}
	}
	private void SliderTip10(object? sender, EventArgs e)
	{
		Slider.Value = 10;
	}
    private void SliderTip15(object? sender, EventArgs e)
    {
        Slider.Value = 15;
    }
    private void SliderTip20(object? sender, EventArgs e)
    {
        Slider.Value = 20;
    }


}