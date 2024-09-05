using AppMAUIGallery.Views.Components.Lists.Models;

namespace AppMAUIGallery.Views.Components.Lists;

public partial class BindableLayoutPage : ContentPage
{
	public BindableLayoutPage()
	{
		InitializeComponent();

        var layout = VerticalStackLayoutControl;
        var list = MovieList.GetList();

        BindableLayout.SetItemsSource(layout, list);
    }
}