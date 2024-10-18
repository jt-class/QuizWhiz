using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

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

    public async void OpenHistoryPage_Clicked(object sender, EventArgs e)
    {
        //Navigate to Settings
        await Navigation.PushAsync(new QuizWhiz.Pages.History.HistoryPage());
    }

    public async void OnBackAgain()
    {
        var toast = Toast.Make("Press back again to exit the app.", ToastDuration.Short);
        await toast.Show();
    }

    private bool _isBackPressed = false;
    private CancellationTokenSource _cts;

    protected override bool OnBackButtonPressed()
    {
        if (_isBackPressed)
        {
            // Exit the app
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
        else
        {
            _isBackPressed = true;
            OnBackAgain();

            // Reset the flag after 2 seconds if no second click
            _cts?.Cancel(); // Cancel any previous CancellationTokenSource
            _cts = new CancellationTokenSource();
            Task.Delay(2000, _cts.Token).ContinueWith(task =>
            {
                _isBackPressed = false; // Reset flag if time passes
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        return true; // Prevent default back button action
    }
}