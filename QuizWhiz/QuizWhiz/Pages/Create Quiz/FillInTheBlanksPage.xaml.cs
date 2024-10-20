namespace QuizWhiz.Pages.Create_Quiz;

public partial class FillInTheBlanksPage : ContentPage
{
	public FillInTheBlanksPage()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }
}