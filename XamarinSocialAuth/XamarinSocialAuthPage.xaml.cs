using System;
using Xamarin.Forms;

namespace XamarinSocialAuth
{
    public partial class XamarinSocialAuthPage : ContentPage
    {
        bool authenticated = false;

        public XamarinSocialAuthPage()
        {
            InitializeComponent();
        }

        async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (App.Authenticator != null)
            {
                authenticated = await App.Authenticator.Authenticate();
            }   
        }
    }
}
