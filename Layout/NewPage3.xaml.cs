using System.Threading.Tasks;

namespace Layout;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}
	void OnSubmiteClicked(object? sender, EventArgs e)
	{
		if (!string.IsNullOrWhiteSpace(ImieNazwisko.Text) && !string.IsNullOrWhiteSpace(Email.Text) && !string.IsNullOrWhiteSpace(Temat.Text) && !string.IsNullOrWhiteSpace(Wiadomosc.Text))
		{
			DisplayAlert("Powiadomienie", "Mamy twoje zg³oszenie", "PotwierdŸ");

		}else
		{
			DisplayAlert("Powiadomienie", "Uzupe³nij wszystkie pola aby wys³aæ zg³oszenie", "PotwierdŸ");
		}
	}
}

/*
***********************************************
nazwa funkcji: OnSubmiteClicked
opis funkcji: Funkcja sprawdza czy w pola zosta³a wpisana wartoœæ lub czy nie posiada pól wype³nionych spacjami. W zale¿noœci od wyniku sprawdzenia funkcja wyœwielta alert.
parametry: brak
zwracany typ i opis: brak 
autor: Wiktor Mañkut
************************************************
*/