namespace AppMAUIGallery.Views.Components.Forms;

public partial class TimePickerPage : ContentPage
{

    public TimePickerPage()
	{
		InitializeComponent();
	}

    TimePicker SelectedTime { get; set; }

    //Para pegar a data somente com MVVM

    //lblResult.Text = SelectedTime.Value.ToString();
}