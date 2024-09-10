using AppMAUIGallery.Models;
using AppMAUIGallery.Repositories;


namespace AppMAUIGallery.Views;

public partial class Menu : ContentPage
{
    private IGroupComponentRepository _repository;

    public Menu()
	{
		InitializeComponent();

        //One simple approach of menu
        //var categories = new CategoryRepository().GetCategories();

        //      foreach (var category in categories)
        //{
        //          var lblCategory = new Label();
        //	lblCategory.Text = category.Name;
        //	lblCategory.FontFamily = "OpenSansSemibold";
        //          lblCategory.FontSize = 18;
        //          lblCategory.FontAttributes = FontAttributes.Bold;

        //          MenuContainer.Children.Add(lblCategory);

        //          foreach (var component in category.Components)
        //	{
        //              var tap = new TapGestureRecognizer();
        //              tap.CommandParameter = component.Page;
        //              tap.Tapped += OnTapComponent;

        //              var lblComponentTitle = new Label();
        //		lblComponentTitle.Text = component.Title;
        //              lblComponentTitle.FontFamily = "OpenSansSemibold";
        //              lblComponentTitle.FontSize = 15;
        //              lblComponentTitle.FontAttributes = FontAttributes.Bold;
        //              lblComponentTitle.Margin = new Thickness(20,10,0,0);
        //              lblComponentTitle.GestureRecognizers.Add(tap);

        //              var lblComponentDescription = new Label();
        //		lblComponentDescription.Text = component.Description;
        //              lblComponentDescription.Margin = new Thickness(20, 0, 0, 0);
        //              lblComponentDescription.TextColor = Colors.Gray;
        //              lblComponentDescription.GestureRecognizers.Add(tap);

        //              MenuContainer.Children.Add(lblComponentTitle);
        //              MenuContainer.Children.Add(lblComponentDescription);
        //          }
        //      }

        //Forma nova
        _repository = new GroupComponentRepository();
        MenuCollection.ItemsSource = _repository.GetGroupComponents();
    }

    //Another simple approach of menu
    //private void OnTapComponent(object sender, EventArgs e)
    //{
    //    //Forma inicial de fazer o menu
    //    //var label = (Label)sender;
    //    //var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
    //    //var page = (Type)tap.CommandParameter;

    //    //((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
    //    //((FlyoutPage)App.Current.MainPage).IsPresented = false;
    //}

    private void OnTapComponent(object sender, TappedEventArgs e)
    {
        var component = (Component)e.Parameter;

        if (component.IsReplaceMainPage == false)
        {
            ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(component.Page));
            ((FlyoutPage)App.Current.MainPage).IsPresented = false;
        }
        else
        {
            App.Current.MainPage = (Page)Activator.CreateInstance(component.Page);
        }
    }

    private void OnStartTap(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppMAUIGallery.Views.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}