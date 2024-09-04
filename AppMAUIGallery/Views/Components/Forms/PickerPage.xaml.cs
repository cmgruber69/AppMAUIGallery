namespace AppMAUIGallery.Views.Components.Forms;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var component = (Picker)sender;
		string Brand = (String)component.SelectedItem;

		lblValue.Text = Brand;
    }
}