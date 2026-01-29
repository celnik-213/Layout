namespace Layout;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
		InitializeComponent();
	}
	void OnSaveClicked(object sender, EventArgs e)
	{
		var push = Push.IsToggled;
		var email = Email.IsToggled;
		var sms = Sms.IsToggled;
		var ciemny = Ciemny.IsToggled;
		double slider = Math.Round(Slider.Value);
		var analityczne = Analityczne.IsChecked;
		var reklamy = Reklamy.IsChecked;

		DisplayAlert("Twoje ustawienia", "Powiadomienia push: "+push+" Powiadomienia e-mail: "+email+" Powiadomienia SMS: "+sms+" Tryb ciemny: "+ciemny+" Rozmiar czcionki: "+slider+ " Udostêpnianie danych analitycznych: "+analityczne+" Personalizowane reklamy: "+reklamy, "PotwierdŸ");


    /*
    ***********************************************
    nazwa funkcji: OnSaveClicked
    opis funkcji: Funkcja pobiera wrtoœci od slider oraz checkedbox oraz swtich przypisuje je do zmiennych co pozwala wyœwietliæ wybrane przez u¿ytkownika opcje w alercie.
    parametry: brak
    zwracany typ i opis: brak 
    autor: Wiktor Mañkut
    ************************************************
    */

    }
}