using Xamarin.Forms;
using System.Threading.Tasks;

namespace XamarinSocialAuth
{
    public partial class App : Application
    {
        public static IAuthenticate Authenticator { get; private set; }

        public interface IAuthenticate
        {
            Task<bool> Authenticate();
        }

        public App(IAuthenticate authenticator)
        {
            InitializeComponent();
            Authenticator = authenticator;

            MainPage = new XamarinSocialAuthPage();
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
