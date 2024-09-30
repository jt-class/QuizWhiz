namespace QuizWhiz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenSignupActivity_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }


    }

}
