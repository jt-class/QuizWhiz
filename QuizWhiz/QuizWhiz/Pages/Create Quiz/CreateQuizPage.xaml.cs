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
                "  Identification",
                "  True or False"
            };
        TOQPicker.ItemsSource = options;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PushAsync(new QuizWhiz.Pages.HomePage.HomePage());
    }

    // Checks all criteria and proceeds to the next page
    private async void OnNextbuttonClicked(object sender, EventArgs e)
    {
        if (TOQPicker.SelectedIndex == -1)
        {
            xTypeOfQuiz.IsVisible = true;
        }

        else {
            xTypeOfQuiz.IsVisible = false;
        }

        if (string.IsNullOrWhiteSpace(entryQuizName.Text))
        {
            xQuizName.IsVisible = true;
        }

        else
        {
            xQuizName.IsVisible = false;
        }

        if (string.IsNullOrWhiteSpace(entryTime.Text))
        {
            xTime.IsVisible = true;
        }

        else
        {
            xTime.IsVisible = false;
        }

        if (string.IsNullOrWhiteSpace(entryNumberOfQuestions.Text))
        {
            xNumberOfQuestions.IsVisible = true;
        }

        else
        {
            xNumberOfQuestions.IsVisible = false;
        }

        if (!string.IsNullOrWhiteSpace(entryQuizName.Text) && !string.IsNullOrWhiteSpace(entryTime.Text) && !string.IsNullOrWhiteSpace(entryNumberOfQuestions.Text))
        {
            if (TOQPicker.SelectedIndex == 0)
            {
                //Navigate to multiple choice page
                await Navigation.PushAsync(new QuizWhiz.Pages.Create_Quiz.MultipleChoicePage());
            }

            if (TOQPicker.SelectedIndex == 1)
            {
                //Navigate to fill in the blanks page
                await Navigation.PushAsync(new QuizWhiz.Pages.Create_Quiz.IdentificationPage());
            }

            if (TOQPicker.SelectedIndex == 2)
            {
                //Navigate to true or false page
                await Navigation.PushAsync(new QuizWhiz.Pages.Create_Quiz.TrueOrFalsePage());
            }
        }
    }
}