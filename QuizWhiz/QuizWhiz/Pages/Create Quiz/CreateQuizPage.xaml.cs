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
        bool isInputValid = true;

        if (TOQPicker.SelectedIndex == -1)
        {
            xTypeOfQuiz.IsVisible = true;
        }

        else
        {
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

        try
        {
            if (!string.IsNullOrWhiteSpace(entryTimeMinutes.Text) &&
                !string.IsNullOrWhiteSpace(entryTimeSeconds.Text) &&
                !string.IsNullOrWhiteSpace(entryNumberOfQuestions.Text))
            {
                bool isValid = true;

                try
                {
                    int number = int.Parse(entryTimeMinutes.Text);
                    xTimeMinutes.IsVisible = false;
                }
                catch
                {
                    xTimeMinutes.IsVisible = true;
                    isValid = false;
                }

                try
                {
                    int number1 = int.Parse(entryTimeSeconds.Text);
                    xTimeSeconds.IsVisible = false;
                }
                catch
                {
                    xTimeSeconds.IsVisible = true;
                    isValid = false;
                }

                try
                {
                    int number2 = int.Parse(entryNumberOfQuestions.Text);
                    xNumberOfQuestions.IsVisible = false;
                }
                catch
                {
                    xNumberOfQuestions.IsVisible = true;
                    isValid = false;
                }

                if (!isValid)
                {
                    DisplayAlert("Invalid input", "Please enter valid inputs.", "OK");
                    isInputValid = false;
                    return;
                }
            }
        }
        catch (Exception ex) // Consider capturing the exception type to diagnose issues.
        {
            DisplayAlert("Invalid input", "Please enter a valid input.", "OK");
            isInputValid = false;
            // Optionally log or display ex.Message for debugging
        }


        if (string.IsNullOrWhiteSpace(entryTimeMinutes.Text))
        {
            xTimeMinutes.IsVisible = true;
        }

        else
        {
            xTimeMinutes.IsVisible = false;
        }

        if (string.IsNullOrWhiteSpace(entryTimeSeconds.Text))
        {
            xTimeSeconds.IsVisible = true;
        }

        else
        {
            xTimeSeconds.IsVisible = false;
        }

        if (string.IsNullOrWhiteSpace(entryNumberOfQuestions.Text))
        {
            xNumberOfQuestions.IsVisible = true;
        }

        else
        {
            xNumberOfQuestions.IsVisible = false;
        }

        if (isInputValid && !string.IsNullOrWhiteSpace(entryQuizName.Text) && !string.IsNullOrWhiteSpace(entryTimeMinutes.Text) && !string.IsNullOrWhiteSpace(entryTimeSeconds.Text) && !string.IsNullOrWhiteSpace(entryNumberOfQuestions.Text))
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



