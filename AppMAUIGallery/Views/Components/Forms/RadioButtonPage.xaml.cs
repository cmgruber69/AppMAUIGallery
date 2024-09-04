namespace AppMAUIGallery.Views.Components.Forms;

public partial class RadioButtonPage : ContentPage
{
	public RadioButtonPage()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value == true) 
		{
			var val = ((RadioButton)sender).Content;
            lblResponse.Text = $"coce escolheu: {val}";

        }
    }
}