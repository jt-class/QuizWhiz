namespace QuizWhiz.Pages.Create_Quiz;

public partial class TrueOrFalsePage : ContentPage
{
	public TrueOrFalsePage()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }
}