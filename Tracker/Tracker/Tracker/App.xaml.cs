using CommonServiceLocator;
using GalaSoft.MvvmLight.Views;
using GoogleMapProject.Helper;
using System;
using Tracker.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Tracker
{
	public partial class App : Application
	{
        public const string Login = "Login";
        public const string Registration = "Registration";
        public const string ForgetPassword = "ForgetPassword";
        public const string MainMapPage = "MainMapPage";
        public App ()
		{
			InitializeComponent();

            //MainPage = new MainPage();

            InitializeComponent();

            var firstPage = new NavigationPage(new Login());

            var navigationService = (NavigationService)ServiceLocator.Current.GetInstance<INavigationService>();
            navigationService.Initialize(firstPage);

            var dialogService = (DialogService)ServiceLocator.Current.GetInstance<IDialogService>();
            dialogService.Initialize(firstPage);

            MainPage = firstPage;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        #region Property

        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }

        #endregion Property
    }
}
