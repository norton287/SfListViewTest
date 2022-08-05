using System;
using System.ComponentModel;
using System.Diagnostics;

using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;

using Xamarin.Essentials;
using Xamarin.Forms;

using static SfListViewTest.App;

using ItemTappedEventArgs = Syncfusion.ListView.XForms.ItemTappedEventArgs;

namespace SfListViewTest;

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

        if (!BeenDone)
        {
            try
            {
                ListView.DataSource.GroupDescriptors?.Add(new GroupDescriptor
                {
                    PropertyName = "ColorName",
                    KeySelector = obj => (obj as Colors)?.ColorName
                });
            }
            catch (InvalidOperationException e)
            {
                Debug.WriteLine("Did a refresh and threw it " + e.Message + " " + e.Data);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Debug.WriteLine("Argument out of range " + ex.Message + " " + ex.Data);
            }

            ListView.GroupHeaderTemplate ??= new DataTemplate(() =>
            {
                var grid = new Grid { BackgroundColor = Color.FromHex("#E4E4E4") };

                var column0 = new ColumnDefinition { Width = 70 };
                var column1 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
                var row0 = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };

                grid.RowDefinitions.Add(row0);
                grid.ColumnDefinitions.Add(column0);
                grid.ColumnDefinitions.Add(column1);

                var image = new Image();
                Binding binding = new("IsExpand")
                {
                    Converter = new BoolToImageConverter()
                };
                image.SetBinding(Image.SourceProperty, binding);
                image.HeightRequest = 30;
                image.WidthRequest = 30;
                image.VerticalOptions = LayoutOptions.Center;
                image.HorizontalOptions = LayoutOptions.Center;

                var label1 = new Label();
                label1.SetBinding(Label.TextProperty, new Binding("Key"));
                label1.TextColor = Color.Black;
                label1.BackgroundColor = Color.Transparent;
                label1.FontFamily = "RobotoBold";
                label1.VerticalTextAlignment = TextAlignment.Center;
                label1.Margin = new Thickness(0, 10, 15, 10);
                if (DeviceInfo.Platform == DevicePlatform.UWP)
                {
                    label1.FontSize = 29;
                    label1.HeightRequest = 80;
                }

                if (DeviceInfo.Idiom == DeviceIdiom.Phone)
                {
                    label1.FontSize = 14;
                    label1.HeightRequest = 85;
                }

                if (DeviceInfo.Idiom == DeviceIdiom.Tablet)
                {
                    label1.FontSize = 18;
                    label1.HeightRequest = 70;
                }

                grid.Children.Add(image, 0, 0);
                grid.Children.Add(label1, 1, 0);

                return grid;
            });

            BeenDone = true;
        }

        //Build picker list of color names and colors
        _viewModel.BuildColorsList();
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();

        if (BeenDone) BeenDone = false;
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height); //must be called

        _width = width;
        _height = height;

        if(width > height)
        {
            if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
                ListView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 3 };
            if (DeviceInfo.Idiom == DeviceIdiom.Tablet)
                ListView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 3 };
            if (DeviceInfo.Idiom == DeviceIdiom.Phone)
                ListView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 4 };
        }
        else if (height > width)
        {
            if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
                ListView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 2 };
            if (DeviceInfo.Idiom == DeviceIdiom.Tablet)
                ListView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 2 };
            if (DeviceInfo.Idiom == DeviceIdiom.Phone)
                ListView.LayoutManager = gridLayout = new GridLayout() { SpanCount = 2 };
        }
    }

    private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.ItemData is not Colors item) return;

        var index = ListView.DataSource.DisplayItems.IndexOf(item);
            
        _viewModel.DoUpdate(item);

        ListView.LayoutManager.ScrollToRowIndex(index, Syncfusion.ListView.XForms.ScrollToPosition.Center, true);



    }

    private void Help_OnClicked(object sender, EventArgs e)
    {
#pragma warning disable 219
        var test = true;
#pragma warning restore 219
    }
}