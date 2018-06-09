using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tracker.ViewModel
{
    public class RegistrationViewModel : ViewModelBase
    {
        public readonly INavigationService _navigationService;
        private readonly GalaSoft.MvvmLight.Views.IDialogService _dialogService;

        private String _name;
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        private String _empId;
        public String EmployeeId
        {
            get
            {
                return _empId;
            }
            set
            {
                _empId = value;
                RaisePropertyChanged(() => EmployeeId);
            }
        }

        private String _contactNo;
        public String ContactNumber
        {
            get
            {
                return _contactNo;
            }
            set
            {
                _contactNo = value;
                RaisePropertyChanged(() => ContactNumber);
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

        private String _cnfPwd;
        public String ConfirmPassword
        {
            get
            {
                return _cnfPwd;
            }
            set
            {
                _cnfPwd = value;
                RaisePropertyChanged(() => ConfirmPassword);
            }
        }

        public RegistrationViewModel(INavigationService navigationService, GalaSoft.MvvmLight.Views.IDialogService dialogService)
        {
            if (navigationService == null)
                throw new ArgumentNullException("navigationService");
            _navigationService = navigationService;

            if (dialogService == null)
                throw new ArgumentNullException("dialogService");
            _dialogService = dialogService;
            
        }

        public void nonEmpty()
        {
            if((string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(EmployeeId) || string.IsNullOrEmpty(ContactNumber) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmPassword)))
            {
                _dialogService.ShowMessage("All fields are required", "Alert");
            }
            else
            {
                _navigationService.GoBack();
            }
        }
    }
}
