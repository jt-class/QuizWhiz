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

    private async void OnNextbuttonClicked(object sender, EventArgs e)
    {
        if (TOQPicker.SelectedIndex == 0)
        {
            //Navigate to Create multiple choice page
            await Navigation.PushAsync(new QuizWhiz.Pages.Create_Quiz.CreateMultipleChoicePage());
        }

        if (TOQPicker.SelectedIndex == 1)
        {
            DisplayAlert("1","a","a");
        }

        if (TOQPicker.SelectedIndex == 2)
        {
            DisplayAlert("2", "a", "a");
        }
    }
}