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

        // When onQuizNameTap is tapped, it focus on entryQuizName
        var tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += OnQuizNameTapped;
        onQuizNameTap.GestureRecognizers.Add(tapGestureRecognizer);
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }

    private async void OnQuizNameTapped(object sender, EventArgs e)
    {
        entryQuizName.Focus();
    }

}