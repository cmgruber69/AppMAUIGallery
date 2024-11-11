namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void GoToStep1(object sender, EventArgs e)
    {
        //Rota Relativa = entende que voce já está em /page1 portanto ele +/page1step1
        Shell.Current.GoToAsync("page1step1");
    }

    private void GoToStep2(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("page1step2");
    }

   
}