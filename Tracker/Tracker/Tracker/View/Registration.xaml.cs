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
	public partial class Registration : ContentPage
	{
        public RegistrationViewModel viewModel;
		public Registration ()
		{
			InitializeComponent ();
            viewModel = App.Locator.RegistrationView;

            InitializeComponent();
            this.BindingContext = viewModel;
        }

        public void OnSignUpClicked(Object sender, EventArgs e)
        {
            viewModel.nonEmpty();
        }
    }
}