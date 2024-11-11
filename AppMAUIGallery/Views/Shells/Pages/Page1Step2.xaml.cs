namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page1Step2 : ContentPage
{
	public Page1Step2()
	{
		InitializeComponent();
	}

    private void GoToStep1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("page1step1");
    }

    private void GoToPage1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("page1");
    }

    private void GoToPage5(object sender, EventArgs e)
    {
        //Go to page 5
        //Rota atual: /page1/page1step2
        //Rota destino: /cadastro/passo2

        //Rota Relativa
        //Shell.Current.GoToAsync("../../cadastro/passo2");

        //Rota absoluta
        //Shell.Current.GoToAsync("//cadastro/passo2");

        //Usando pagina
        //Shell.Current.GoToAsync("page5");  //Funciona apenas se rigistrar a rota no shell, mas fica na rota: /page1/page5 
        //Shell.Current.GoToAsync("//page5"); //NAO funciona
        //Shell.Current.GoToAsync("///page5"); //NAO funciona

        //Usando pesquisa de rota, volta para inicio
        Shell.Current.GoToAsync("///passo2");
    }

    private void GoToPage4(object sender, EventArgs e)
    {
        //Usando pesquisa de rota
        Shell.Current.GoToAsync("///passo1");
    }
}