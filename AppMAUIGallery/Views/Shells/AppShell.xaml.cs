using AppMAUIGallery.Views.Shells.Pages;

namespace AppMAUIGallery.Views.Components.Shells;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Register pages in AppShell for routing. This pages ar not listed in xaml appshel
        Routing.RegisterRoute("page1/page1step1", typeof(Page1Step1));
        Routing.RegisterRoute("page1/page1step2", typeof(Page1Step2));

        Routing.RegisterRoute("page2/page2step1", typeof(Page2Step01WithParameters));

        Routing.RegisterRoute("page04step01", typeof(Page4Step1));
        Routing.RegisterRoute("page04step02", typeof(Page4Step2));


        //Routing.RegisterRoute("page5", typeof(Page5));
    }

    private void BackToGallery(object sender, EventArgs e)
    {
        App.Current.MainPage = new AppFlyout();
    }

}