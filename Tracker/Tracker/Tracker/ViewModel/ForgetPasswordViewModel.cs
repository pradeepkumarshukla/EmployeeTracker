using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tracker.ViewModel
{
    public class ForgetPasswordViewModel : ViewModelBase
    {
        public readonly INavigationService _navigationService;
        private readonly GalaSoft.MvvmLight.Views.IDialogService _dialogService;

        private String _emailId;
        public String Email_Id
        {
            get
            {
                return _emailId;
            }
            set
            {
                _emailId = value;
                RaisePropertyChanged(() => Email_Id);
            }
        }

        public ForgetPasswordViewModel(INavigationService navigationService, GalaSoft.MvvmLight.Views.IDialogService dialogService)
        {
            if (navigationService == null)
                throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            if (dialogService == null)
                throw new ArgumentNullException("dialogService");
            _dialogService = dialogService;

        }

        public void nonEmptyField()
        {
            if ((string.IsNullOrEmpty(Email_Id)))
            {
                _dialogService.ShowMessage("Email Id is Required.", "Alert");
            }
            else
            {
                _navigationService.GoBack();
            }
        }
    }
}
