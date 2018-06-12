using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Tracker.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainMapPage : ContentPage
	{
        public MainMapPageViewModel viewModel;

        private async Task RetrieveLocation()
        {
            var location = CrossGeolocator.Current;
            location.DesiredAccuracy = 20;

            var position = await location.GetPositionAsync(TimeSpan.FromSeconds(10));

            var latitude = position.Latitude;
            var longitude = position.Longitude;

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Distance.FromMeters(500)));
        }

        private async void RetrieveLocation1()
        {
            await RetrieveLocation();
        }

        public MainMapPage ()
		{
			InitializeComponent ();
            viewModel = App.Locator.MainMapPageView;

            InitializeComponent();
            this.BindingContext = viewModel;

            RetrieveLocation1();
        }

	}
}