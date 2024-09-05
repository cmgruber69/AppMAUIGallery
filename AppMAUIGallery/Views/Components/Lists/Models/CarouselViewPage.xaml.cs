namespace AppMAUIGallery.Views.Components.Lists.Models;

public partial class CarouselViewPage : ContentPage
{
	public CarouselViewPage()
	{
		InitializeComponent();
        CarouselViewControl.ItemsSource = MovieList.GetList();
    }
}