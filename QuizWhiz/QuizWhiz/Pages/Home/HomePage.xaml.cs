namespace QuizWhiz.Pages.HomePage;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	public async void OpenNotificationPage_Clicked(object sender, EventArgs e)
	{
        //Navigate to HomePage
        await Navigation.PushAsync(new QuizWhiz.Pages.Notification.NotificationPage());
    }

    public async void OpenProfilePage_Clicked(object sender, EventArgs e)
    {
        //Navigate to Profile
        await Navigation.PushAsync(new QuizWhiz.Pages.Profile.ProfilePage());
    }

    public async void OpenSettingsPage_Clicked(object sender, EventArgs e)
    {
        //Navigate to Settings
        await Navigation.PushAsync(new QuizWhiz.Pages.Settings.SettingsPage());
    }
}