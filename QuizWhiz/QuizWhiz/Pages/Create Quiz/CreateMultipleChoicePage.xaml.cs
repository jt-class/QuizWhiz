namespace QuizWhiz.Pages.Create_Quiz;

public partial class CreateMultipleChoicePage : ContentPage
{
	public CreateMultipleChoicePage()
	{
		InitializeComponent();
	}
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }
}