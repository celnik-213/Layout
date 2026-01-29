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
		}
		if (osobyVisible == false)
		{
			osoby.IsVisible = false;
		}
	}
}