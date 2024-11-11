namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page1Step1 : ContentPage
{
	public Page1Step1()
	{
		InitializeComponent();
	}

    private void GoToStep2(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("page1step2");
    }

    private void GoBackPage1(object sender, EventArgs e)
    {
        //Rota relativa
        // currennt Route: page1/page1step1
        Shell.Current.GoToAsync("..");

    }
}