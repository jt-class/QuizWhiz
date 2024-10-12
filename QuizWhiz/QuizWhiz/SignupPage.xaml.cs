using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

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

    private async void OnSignupButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Shell.Current.GoToAsync("//MainPage");

        // Show a toast message
        var toast = Toast.Make("Account created successfully!", ToastDuration.Short);
        await toast.Show();
    }
    
}