using AppMAUIGallery.Views.Components.Lists.Models;

namespace AppMAUIGallery.Views.Components.Lists;

public partial class DataTemplateSelectorPage : ContentPage
{
	public DataTemplateSelectorPage()
	{
		InitializeComponent();

        CollectionViewControl.ItemsSource = MovieList.GetList();
    }
}