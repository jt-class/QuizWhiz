namespace QuizWhiz
{
    using CommunityToolkit.Maui.Alerts;
    using CommunityToolkit.Maui.Core;

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenSignupPage_Clicked(object sender, EventArgs e)
        {
            //Navigate to SignUpPage
            await Navigation.PushAsync(new Signup());
        }

        private async void OpenHomePage_Clicked(object sender, EventArgs e)
        {
            //Navigate to HomePage
            await Navigation.PushAsync(new QuizWhiz.Pages.HomePage.HomePage());

            // Show a toast message
            var toast = Toast.Make("Login Successfully", ToastDuration.Short);
            await toast.Show();
        }

    }

}
