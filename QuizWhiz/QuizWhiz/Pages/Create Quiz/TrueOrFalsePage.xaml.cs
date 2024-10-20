namespace QuizWhiz.Pages.Create_Quiz;

public partial class TrueOrFalsePage : ContentPage
{
	public TrueOrFalsePage()
	{
		InitializeComponent();
	}

    // If true frame is tapped
    private async void rbTrueTapped(object sender, EventArgs e)
    {
        rbTrue.IsChecked = true;
    }

    // If false frame is tapped
    private async void rbFalseTapped(object sender, EventArgs e)
    {
        rbFalse.IsChecked = true;
    }
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }
    private async void OnCloseButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PushAsync(new QuizWhiz.Pages.Create_Quiz.CreateQuizPage());

        // make a code where if it is closed, reset all questionare's entered.
    }
}