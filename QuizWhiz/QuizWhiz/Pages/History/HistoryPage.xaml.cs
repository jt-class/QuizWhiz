namespace QuizWhiz.Pages.History;

public partial class HistoryPage : ContentPage
{
	public HistoryPage()
	{
		InitializeComponent();
	}
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }
}