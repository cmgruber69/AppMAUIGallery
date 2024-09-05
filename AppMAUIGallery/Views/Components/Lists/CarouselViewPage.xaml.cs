using AppMAUIGallery.Views.Components.Lists.Models;

namespace AppMAUIGallery.Views.Components.Lists;

public partial class CarouselViewPage : ContentPage
{
	public CarouselViewPage()
	{
		InitializeComponent();
        CarouselViewControl.ItemsSource = MovieList.GetList();
    }
}