using System.Threading.Tasks;

namespace Layout;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
    private async void OnThumbnailTapped(object sender, EventArgs e)
	{
		var thumbnai = sender as Image;

		if (thumbnai != null)
		{
			await DisplayAlert(
				"Miniatura",
				"Kliknięto w miniaturę w galerii",
				"OK");
		}
	}
}

