using static Microsoft.Maui.Devices.DeviceDisplay;

namespace QuizWhiz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            var screenWidth = MainDisplayInfo.Width / MainDisplayInfo.Density;
            var screenHeight = MainDisplayInfo.Height / MainDisplayInfo.Density;

            var windowWidth = 550;
            var windowHeight = 950;

            //center window
            window.X = (screenWidth - windowWidth) / 2;
            window.Y = (screenHeight - windowHeight) / 2;

            //Fix window size
            window.MinimumWidth = windowWidth;
            window.MinimumHeight = windowHeight;
            window.MaximumWidth = windowWidth;
            window.MaximumHeight = windowHeight;

            return window;
        }
    }
}
