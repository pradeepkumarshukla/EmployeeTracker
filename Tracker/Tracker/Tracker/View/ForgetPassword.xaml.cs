using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tracker.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ForgetPassword : ContentPage
	{
        public ForgetPasswordViewModel viewModel;
		public ForgetPassword ()
		{
			InitializeComponent ();
            viewModel = App.Locator.ForgetPasswordView;

            InitializeComponent();
            this.BindingContext = viewModel;
        }

        public void OnSendClick(Object sender, EventArgs e)
        {
            viewModel.nonEmptyField();
        }

    }
}