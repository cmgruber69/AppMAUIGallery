using AppMAUIGallery.Views.Shells.Pages;

namespace AppMAUIGallery.Views.Components.Shells;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Register pages in AppShell for routing. This pages ar not listed in xaml appshel
        Routing.RegisterRoute("page4/page04step01", typeof(Page4Step1));
        Routing.RegisterRoute("page4/page04step02", typeof(Page4Step2));
        //Routing.RegisterRoute("page02/page02step01", typeof(Page02Step01WithParameters));
    }

    private void BackToGallery(object sender, EventArgs e)
    {
        App.Current.MainPage = new AppFlyout();
    }

}