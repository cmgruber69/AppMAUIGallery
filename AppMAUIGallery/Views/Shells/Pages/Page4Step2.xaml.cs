namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page4Step2 : ContentPage
{
	public Page4Step2()
	{
		InitializeComponent();
	}

    private void GoBackToStep1(object sender, EventArgs e)
    {
        //Route registered at AppShell code behind
        //Current route: page4/page01step01
        //Target route : page4/page01step02

        //Using Relative route
        Shell.Current.GoToAsync("..");


        //Shell.Current.GoToAsync("page04step01");
    }

    private void GoToPage5(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("Page5");
    }
}