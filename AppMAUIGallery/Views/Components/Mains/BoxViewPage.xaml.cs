namespace AppMAUIGallery.Views.Components;

public partial class BoxViewPage : ContentPage
{
	public BoxViewPage()
	{
		InitializeComponent();
	}

    private void Button_Pressed(object sender, EventArgs e)
    {
        LblLog.Text += $"\nPressionado: {DateTime.Now}";
    }

    private void Button_Released(object sender, EventArgs e)
    {
        LblLog.Text += $"\nLiberado: {DateTime.Now}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        LblLog.Text += $"\nClicado: {DateTime.Now}";
    }
}