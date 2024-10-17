namespace QuizWhiz.Pages.Settings;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }

    private async void OnLogOutButttonClicked(object sender, EventArgs e)
    {
        // Navigate back to Login Page
        await Navigation.PushAsync(new MainPage());
    }




}