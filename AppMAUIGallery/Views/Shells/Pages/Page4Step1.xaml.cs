namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page4Step1 : ContentPage
{
	public Page4Step1()
	{
		InitializeComponent();
	}

    private void GoToStep2(object sender, EventArgs e)
    {
        //Route registered at AppShell code behind
        //Current route: page4/page01step01
        //Target route : page4/page01step02

        //Using Relative route
        Shell.Current.GoToAsync("page04step02");
    }

    private void GoBackToPage4(object sender, EventArgs e)
    {
        //Current route: page4/page01step01
        //Target route : Page4
        Shell.Current.GoToAsync("..");
    }
}