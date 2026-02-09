using Bumptech.Glide.Load.Resource.Bitmap;
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
			Osoby.IsVisible = true;
			naosobesuma.IsVisible = true;
		}
		if (osobyVisible == false)
		{
			Osoby.IsVisible = false;
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
	private void NapiwekUpdate(object? sender, EventArgs e)
	{
		Rachunek();
	}
	private void CenaUpdate(object sender, ValueChangedEventArgs e)
	{
		Rachunek();
	}

	private void Rachunek()
	{
		if (!string.IsNullOrEmpty(Kwota.Text))
		{
			double NapiwekProcent = Slider.Value;
			double cena = double.Parse(Kwota.Text);
			double CenaObliczona = cena * (NapiwekProcent / 100);
			suma.Text = $"Suma do zap³aty wynosi: {cena + CenaObliczona:F2}";
			napiwek.Text = $"Napiwek: {CenaObliczona:F2}";
		}
		if(!string.IsNullOrEmpty(Kwota.Text) && !string.IsNullOrEmpty(Osoby.Text))
		{
			if (!string.IsNullOrEmpty(Kwota.Text) && Osoby != null && !string.IsNullOrEmpty(Osoby.Text))
            {
                double NapiwekProcent = Slider.Value;
                double cena = double.Parse(Kwota.Text);
                double cenaNapiwku = cena * (NapiwekProcent / 100);
				double CenaKoncowa = cena + cenaNapiwku;
				int liczbaosob = 
            }
		}
	}


}