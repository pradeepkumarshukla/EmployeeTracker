using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Tracker;
using Tracker.View;
using Tracker.ViewModel;

namespace GoogleMapProject.Helper
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var navigationService = this.CreateNavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navigationService);

            SimpleIoc.Default.Register<IDialogService, DialogService>();
          //  SimpleIoc.Default.Register<IDatabaseManager, DatabaseManager>();

            SimpleIoc.Default.Register<LoginViewModel>();

            SimpleIoc.Default.Register<RegistrationViewModel>();

            SimpleIoc.Default.Register<ForgetPasswordViewModel>();

            SimpleIoc.Default.Register<MainMapPageViewModel>();
        }

        public LoginViewModel LoginView
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }

        public RegistrationViewModel RegistrationView
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RegistrationViewModel>();
            }
        }

        public ForgetPasswordViewModel ForgetPasswordView
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ForgetPasswordViewModel>();
            }
        }

        public MainMapPageViewModel MainMapPageView
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainMapPageViewModel>();
            }
        }

        private INavigationService CreateNavigationService()
        {
            var navigationService = new NavigationService();
            navigationService.Configure(App.Login, typeof(Login));
            navigationService.Configure(App.Registration, typeof(Registration));
            navigationService.Configure(App.ForgetPassword, typeof(ForgetPassword));
            navigationService.Configure(App.MainMapPage, typeof(MainMapPage));
            return navigationService;
        }
    }
}
