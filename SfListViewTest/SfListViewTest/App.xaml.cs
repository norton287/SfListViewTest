using Xamarin.Forms;

namespace SfListViewTest
{
    public partial class App : Application
    {
        public static bool BeenDone { get; set; }

        public static object LastItemTapped { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
