namespace QuizWhiz
{
    using CommunityToolkit.Maui.Alerts;
    using CommunityToolkit.Maui.Core;
    using Microsoft.Maui.Controls.PlatformConfiguration;

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        // Opens the signup
        private async void OpenSignupPage_Clicked(object sender, EventArgs e)
        {
            //Navigate to SignUpPage
            await Navigation.PushAsync(new Signup());
        }

        // Opens the homepage
        private async void OpenHomePage_Clicked(object sender, EventArgs e)
        {
            //Navigate to HomePage
            await Navigation.PushAsync(new QuizWhiz.Pages.HomePage.HomePage());

            // Show a toast message
            var toast = Toast.Make("Login Successfully", ToastDuration.Short);
            await toast.Show();
        }

        // Double tap on back button to exit
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
                Application.Current.Quit(); // or Environment.Exit(0);
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
                    if (!task.IsCanceled) // Only reset if the task completed
                    {
                        _isBackPressed = false; // Reset flag if time passes
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }

            return true; // Prevent default back button action
        }



    }

}
