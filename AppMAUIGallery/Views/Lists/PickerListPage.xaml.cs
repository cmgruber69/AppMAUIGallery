using AppMAUIGallery.Views.Lists.Models;

namespace AppMAUIGallery.Views.Components.Lists;

public partial class PickerListPage : ContentPage
{
	public PickerListPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var res = MovieList.GetList();
        PickerControl.ItemsSource = res;
        PickerControl2.ItemsSource = res;
    }
}