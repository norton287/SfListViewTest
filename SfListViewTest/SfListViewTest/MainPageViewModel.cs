using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace SfListViewTest
{
    public class MainPageViewModel
    {
        #region Properties and Fields

        private bool _isExpanded;

        public bool IsExpanded
        {
            get => _isExpanded;
            set
            {
                _isExpanded = value;
                OnPropertyChanged("IsExpanded");
            }
        }

        private readonly List<Colors> SubColors = new List<Colors>();

        public ObservableCollection<Colors> ColorsObservableCollection { get; set; }

        #endregion

        public MainPageViewModel()
        {
            ColorsObservableCollection = new ObservableCollection<Colors>();
        }

        public void DoUpdate(Colors item)
        {
            int index = ColorsObservableCollection.IndexOf(item);

            ColorsObservableCollection.Remove(item);

            item.BackGroundColor = "Test Color";
            item.BgColor = Color.Black;

            ColorsObservableCollection.Insert(index, item);
        }

        public void BuildColorsList()
        {
            ColorsObservableCollection?.Clear();

            //Build colors observable collection
            if (ColorsObservableCollection == null || ColorsObservableCollection.Count > 0) return;

            //Build colors observable collection

            SubColors.Clear();

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DodgerBlue",
                ColorName = "Dodger Blue",
                BgColor = Color.DodgerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Tomato",
                ColorName = "Tomato",
                BgColor = Color.Tomato,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Green",
                ColorName = "Green",
                BgColor = Color.Green,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Orange",
                ColorName = "Orange",
                BgColor = Color.Orange,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Brown",
                ColorName = "Brown",
                BgColor = Color.Brown,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Maroon",
                ColorName = "Maroon",
                BgColor = Color.Maroon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateGray",
                ColorName = "Dark Slate Gray",
                BgColor = Color.DarkSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DimGray",
                ColorName = "Dim Gray",
                BgColor = Color.DimGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightGreen",
                ColorName = "Light Green",
                BgColor = Color.LightGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.CornflowerBlue",
                ColorName = "Cornflower Blue",
                BgColor = Color.CornflowerBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSalmon",
                ColorName = "Light Salmon",
                BgColor = Color.LightSalmon,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Blue",
                ColorName = "Blue",
                BgColor = Color.Blue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.DarkSlateBlue",
                ColorName = "Dark Slate Blue",
                BgColor = Color.DarkSlateBlue,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LightSlateGray",
                ColorName = "Light Slate Gray",
                BgColor = Color.LightSlateGray,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.LimeGreen",
                ColorName = "Lime Green",
                BgColor = Color.LimeGreen,
                FntColor = Color.White
            });

            SubColors.Add(new Colors
            {
                BackGroundColor = "Color.Yellow",
                ColorName = "Yellow",
                BgColor = Color.Yellow,
                FntColor = Color.Black
            });

            foreach (var subColor in SubColors)
            {
                ColorsObservableCollection?.Add(subColor);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
