namespace QuizWhiz.Pages.Notification;

public partial class NotificationPage : ContentPage
{
	public NotificationPage()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }
}