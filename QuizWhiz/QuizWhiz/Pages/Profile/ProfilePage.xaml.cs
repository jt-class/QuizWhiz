namespace QuizWhiz.Pages.Profile;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to MainPage
        await Navigation.PopAsync();
    }

    private async void OnPhotoEditClicked(object sender, EventArgs e)
    {
        DisplayAlert("Sorry!", "Change photo is not yet available.", "OK");
    }

    private async void OnEditProfileClicked(object sender, EventArgs e)
    {
        profilePhoto.IsEnabled = true;
        editPhoto.IsVisible = true;
        entryFirstName.IsEnabled = true;
        entryFirstName.Background = Colors.LightGray;
        entrySurname.IsEnabled = true;
        entrySurname.Background = Colors.LightGray;
        entryBio.IsEnabled = true;
        entryBio.Background = Colors.LightGray;

        editProfileBtn.IsVisible = false;
        updateProfileBtn.IsVisible = true;
    }
}