using AppMAUIGallery.Models;
using System.Web;

namespace AppMAUIGallery.Views.Shells.Pages;

[QueryProperty(nameof(Texto), "msg")]
[QueryProperty(nameof(Person), "person")]
public partial class Page2Step01WithParameters : ContentPage
{
	private string _Texto;
	public string Texto
	{
		get { return _Texto; }
		set 
		{ 
			_Texto = HttpUtility.UrlDecode(value);
            LblMSGParameter.Text = _Texto;
        }
	}

    private Person _person;
    public Person Person
    {
        get { return _person; }
        set
        {
            _person = value;
            LblCompParameter.Text = $"A pessoa recebida é: {_person.Name} ({_person.Email})";
        }
    }

    public Page2Step01WithParameters()
	{
		InitializeComponent();
	}



}