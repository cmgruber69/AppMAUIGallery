using System.Windows.Input;

namespace AppMAUIGallery.Views.CommunityMaui
{
    public class CommunityBehaviorPageViewModel
    {
        public ICommand PressedCommand { get; set; }
        public CommunityBehaviorPageViewModel()
        {
            PressedCommand = new Command(Pressed);
        }

        private void Pressed()
        {
            App.Current.MainPage.DisplayAlert("Fui pressionado!", "Fui pressionado!", "OK");
        }
    }
}
