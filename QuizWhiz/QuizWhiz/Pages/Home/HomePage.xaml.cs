using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace QuizWhiz.Pages.HomePage;

public partial class HomePage : ContentPage
{
    public QuizViewModel ViewModel { get; set; }

    public HomePage()
    {
        InitializeComponent();
        ViewModel = new QuizViewModel();
        BindingContext = ViewModel;
    }

    public async void OpenNotificationPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuizWhiz.Pages.Notification.NotificationPage());
    }

    public async void OpenProfilePage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuizWhiz.Pages.Profile.ProfilePage());
    }

    public async void OpenSettingsPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuizWhiz.Pages.Settings.SettingsPage());
    }

    public async void OpenHistoryPage_Clicked(object sender, EventArgs e)
    {
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

public class QuizViewModel
{
    public ObservableCollection<Quiz> Quizzes { get; set; }
    public ICommand ViewQuizCommand { get; set; }

    public QuizViewModel()
    {
        Quizzes = new ObservableCollection<Quiz>
        {
            new Quiz { Title = "Sample Quiz 1", Description = "Description for Quiz 1", CreatedDate = DateTime.Now },
            new Quiz { Title = "Sample Quiz 2", Description = "Description for Quiz 2", CreatedDate = DateTime.Now.AddDays(-1) },
            new Quiz { Title = "Sample Quiz 3", Description = "Description for Quiz 3", CreatedDate = DateTime.Now.AddDays(-2) },
            new Quiz { Title = "Sample Quiz 4", Description = "Description for Quiz 4", CreatedDate = DateTime.Now.AddDays(-3) }
            // Add more quizzes after integration ng database na siguro
        };
        ViewQuizCommand = new Command<Quiz>(OnViewQuiz);
    }

    private async void OnViewQuiz(Quiz quiz)
    {
        // Logic to navigate to quiz details page
        //await Application.Current.MainPage.Navigation.PushAsync(new QuizDetailsPage(quiz));
    }
}

public class Quiz
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
}
