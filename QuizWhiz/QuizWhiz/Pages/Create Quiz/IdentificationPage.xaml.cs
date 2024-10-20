namespace QuizWhiz.Pages.Create_Quiz;

public partial class IdentificationPage : ContentPage
{
	public IdentificationPage()
	{
		InitializeComponent();
	}

    private async void OnCloseButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PushAsync(new QuizWhiz.Pages.Create_Quiz.CreateQuizPage());

        // make a code where if it is closed, reset all questionare's entered.
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }
}