namespace QuizWhiz.Pages.Create_Quiz;

public partial class CreateQuizPage : ContentPage
{
	public CreateQuizPage()
	{
		InitializeComponent();

        // Picker choices
        List<string> options = new List<string>
            {
                "  Multiple Choice",
                "  Fill in the blank",
                "  True or False"
            };
        TOQPicker.ItemsSource = options;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }
}