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
			DisplayAlert("Powiadomienie", "Mamy twoje zg≥oszenie", "Potwierdü");

		}else
		{
			DisplayAlert("Powiadomienie", "Uzupe≥nij wszystkie pola aby wys≥aÊ zg≥oszenie", "Potwierdü");
		}
	}
}