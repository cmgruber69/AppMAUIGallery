namespace AppMAUIGallery.Views.CommunityMaui;

public partial class MediaElementPage : ContentPage
{
	public MediaElementPage()
	{
		InitializeComponent();
	}

    private void OnClickedToPlay(object sender, EventArgs e)
    {
#if ANDROID
        Player.Play();
#endif
    }
}