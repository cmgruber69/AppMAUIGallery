namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
	}

    private void GoToStep1(object sender, EventArgs e)
    {
        //Using Relative route
        Shell.Current.GoToAsync("page4/page04step01");
   
    }
}