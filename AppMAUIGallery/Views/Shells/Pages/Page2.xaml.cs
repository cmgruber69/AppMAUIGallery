using AppMAUIGallery.Models;
using System.Web;

namespace AppMAUIGallery.Views.Shells.Pages;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void GoToStep1Simple(object sender, EventArgs e)
    {
        //page2/page2step1
        //page2/page2step1{name}?{param}={value}

        var text = "This is a parameter send from previous page";
        var textCoded = HttpUtility.HtmlDecode(text);
        Shell.Current.GoToAsync($"//page2/page2step1?msg={textCoded}");

        //è possivel passar um objeto através de um json
    }

    private void GoToStep1Complex(object sender, EventArgs e)
    {
        var person = new Person()
        {
            Id = 1,
            Name = "Cristian",
            Email = "email@email.com"
        };

        var parameters = new Dictionary<string, object>() 
        {
            {"msg", "Este é um parametro passado de forma complex!" },
            {"person", person }
        };

        Shell.Current.GoToAsync("//page2/page2step1", parameters);
    }
}