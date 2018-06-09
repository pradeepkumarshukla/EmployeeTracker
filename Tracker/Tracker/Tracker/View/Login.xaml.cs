using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tracker.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        public LoginViewModel viewModel;
		public Login ()
		{
			InitializeComponent ();
            viewModel = App.Locator.LoginView;

            InitializeComponent();
            this.BindingContext = viewModel;
        }

        public void OnRegistrationClicked(Object sender, EventArgs e)
        {
            viewModel._navigationService.NavigateTo(App.Registration);
        }

    }
}