using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tracker
{
   public class LoginViewModel : ViewModelBase
    {
        public readonly INavigationService _navigationService;
        private readonly GalaSoft.MvvmLight.Views.IDialogService _dialogService;

        private String _userName;
        public String UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                RaisePropertyChanged(() => UserName);
            }
        }

        private String _pwd;
        public String Password
        {
            get
            {
                return _pwd;
            }
            set
            {
                _pwd = value;
                RaisePropertyChanged(() => Password);
            }
        }

        public LoginViewModel(INavigationService navigationService, GalaSoft.MvvmLight.Views.IDialogService dialogService)
        {
            if (navigationService == null)
                throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            if (dialogService == null)
                throw new ArgumentNullException("dialogService");
            _dialogService = dialogService;



        }
    }
}
