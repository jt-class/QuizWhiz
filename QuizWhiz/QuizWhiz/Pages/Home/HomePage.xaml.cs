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
}