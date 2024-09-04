namespace AppMAUIGallery.Views.Components.Forms;

public partial class SearchBarPage : ContentPage
{
	public SearchBarPage()
	{
		InitializeComponent();
	}

    private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        var res = ((SearchBar)sender).Text;
        lblValue.Text = $"Pesquisa: {res}";
    }
}