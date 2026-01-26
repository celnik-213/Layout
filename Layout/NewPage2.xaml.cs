using System.Threading.Tasks;

namespace Layout;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
        UpdateImagesCount();

    }
	private async void OnThumbnailTapped(object sender, EventArgs e)
	{
		var thumbnai = sender as Image;

		if (thumbnai != null)
		{
			await DisplayAlert(
				"SZYMPANS",
				"Fajny Goryl co nie???",
				"GORYL");
		}
	}
    private void UpdateImagesCount()
    {
        int count = 0;

        foreach (var child in GalleryLayout.Children)
        {
            if (child is Grid grid)
            {
                foreach (var gridChild in grid.Children)
                {
                    if (gridChild is Image)
                    {
                        count++;
                    }
                }
            }
        }

        ImagesCountLabel.Text = $"Obecna iloœæ zdjêæ: {count}";
    }

}

