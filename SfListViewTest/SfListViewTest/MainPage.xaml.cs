using System.ComponentModel;
using Syncfusion.ListView.XForms;
using Xamarin.Essentials;
using Xamarin.Forms;
using ItemTappedEventArgs = Syncfusion.ListView.XForms.ItemTappedEventArgs;

namespace SfListViewTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private readonly MainPageViewModel _viewModel;

        private double _width;
        private double _height;

        public MainPage()
        {
            InitializeComponent();

            _viewModel = new MainPageViewModel();

            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Build picker list of color names and colors
            _viewModel.BuildColorsList();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (_width == width && _height == height) return;

            _width = width;
            _height = height;

            if (width > height)
            {
                if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
                    listView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 4 };
                if (DeviceInfo.Idiom == DeviceIdiom.Tablet)
                    listView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 2 };
                if (DeviceInfo.Idiom == DeviceIdiom.Phone)
                   listView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 4 };
            }
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (!(e.ItemData is Colors item)) return;

            var index = listView.DataSource.DisplayItems.IndexOf(item);
            
            _viewModel.DoUpdate(item);

            listView.LayoutManager.ScrollToRowIndex(index, Syncfusion.ListView.XForms.ScrollToPosition.Center, true);



        }
    }
}
