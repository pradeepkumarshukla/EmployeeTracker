using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tracker.ViewModel
{
    public class MainMapPageViewModel : ViewModelBase
    {
        public readonly INavigationService _navigationService;
        private readonly GalaSoft.MvvmLight.Views.IDialogService _dialogService;

        public MainMapPageViewModel(INavigationService navigationService, GalaSoft.MvvmLight.Views.IDialogService dialogService)
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
