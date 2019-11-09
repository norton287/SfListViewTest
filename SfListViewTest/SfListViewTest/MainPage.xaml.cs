using System.ComponentModel;
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

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (!(e.ItemData is Colors item)) return;

            var index = listView.DataSource.DisplayItems.IndexOf(item);
            
            _viewModel.DoUpdate(item);

            listView.LayoutManager.ScrollToRowIndex(index, Syncfusion.ListView.XForms.ScrollToPosition.Center, true);



        }
    }
}
