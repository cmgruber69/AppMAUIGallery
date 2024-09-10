namespace AppMAUIGallery.Views.Animations;

public partial class BasicAnimation : ContentPage
{
	public BasicAnimation()
	{
		InitializeComponent();
	}

    private void Standard(object sender, EventArgs e)
    {
        Image.Scale = 1;
        Image.Opacity = 1;
        Image.TranslationX = 0;
        Image.TranslationY = 0;
        Image.Rotation = 0;
        Image.RotationX = 0;
        Image.RotationY = 0;
    }
    private void Increase(object sender, EventArgs e)
    {
        Image.ScaleTo(2, 2000);
    }

    private void Decrease(object sender, EventArgs e)
    {
        Image.ScaleTo(0.5, 2000);
    }

    private void Move(object sender, EventArgs e)
    {
        Image.TranslateTo(0, 90, 2000, Easing.BounceOut);
    }

    private async void Rotate(object sender, EventArgs e)
    {
        //await Image.RotateTo(720, 2000);
        //await Image.RotateYTo(360, 1000);
        await Image.RelRotateTo(90, 1000);
    }

    private async void Transparency(object sender, EventArgs e)
    {
        await Image.FadeTo(0.3, 1000);
    }

    private async void Sequence(object sender, EventArgs e)
    {
        await Image.TranslateTo(100, 0, 250);
        await Image.TranslateTo(-100, 0, 500);
        await Image.TranslateTo(0, 0, 250);
    }

    private async void Parallel(object sender, EventArgs e)
    {
        await Task.WhenAll(
            Image.TranslateTo(100, 0, 4000),
            Image.RotateTo(360, 4000),
            Image.FadeTo(0.6, 4000)
        );
    }

    private void Cancellation(object sender, EventArgs e)
    {
        Image.CancelAnimations();
    }

    private void Custom(object sender, EventArgs e)
    {
        var principal = new Animation();
        var animacao01 = new Animation(v => Image.TranslationX = v, 0, 150, Easing.Linear, null);
        var animacao02 = new Animation(v => Image.Rotation = v, 0, 360, Easing.Linear, null);


        principal.Add(0, 1, animacao01);
        principal.Add(0.5, 1, animacao02);

        principal.Commit(this, "AnimacaoPersonalizada", 16, 10000, null, null, null);
        //animacao01.Commit(this, "MoverORobo", 16, 3000, null, null, repeat: ()=>true);


    }

    private void ColorChange(object sender, EventArgs e)
    {
        Image.ColorTo(Colors.White, Colors.Violet, v => Image.BackgroundColor = v, 2000, null);
    }
}