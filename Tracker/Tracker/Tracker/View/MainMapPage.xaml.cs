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
	public partial class MainMapPage : ContentPage
	{
        public MainMapPageViewModel viewModel;
        public MainMapPage ()
		{
			InitializeComponent ();
            viewModel = App.Locator.MainMapPageView;

            InitializeComponent();
            this.BindingContext = viewModel;
        }
	}
}