namespace QuizWhiz;

public partial class Signup : ContentPage
{
	public Signup()
	{
		InitializeComponent();

    }
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Shell.Current.GoToAsync("//MainPage");
    }
}