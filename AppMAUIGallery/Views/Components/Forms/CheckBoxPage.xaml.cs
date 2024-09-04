using System.Collections;

namespace AppMAUIGallery.Views.Components.Forms;

public partial class CheckBoxPage : ContentPage
{
    ArrayList list = new ArrayList();

    public CheckBoxPage()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value == true)
        {
            CheckBox checkBox = (CheckBox)sender;
            HorizontalStackLayout stack = (HorizontalStackLayout)checkBox.Parent;
            Label label = (Label)stack.Children[1];
            var stText = label.Text.ToString();
            list.Add(stText);
            lblStatus.Text = stText;
            lblList .Text = string.Join(", ", list.ToArray());

        }
        else
        {
            lblStatus.Text = string.Empty;
        }
        
        
    }
}