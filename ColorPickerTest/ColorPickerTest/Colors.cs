using System.ComponentModel;
using Xamarin.Forms;

namespace SfListViewTest
{
    public class Colors : INotifyPropertyChanged
    {
        private string _backGroundColor;

        public string BackGroundColor
        {
            get => _backGroundColor;
            set
            {
                _backGroundColor = value;

                OnPropertyChanged("BackGroundColor");
            }
        }

        private string _colorName;

        public string ColorName
        {
            get => _colorName;
            set
            {
                _colorName = value;

                OnPropertyChanged("ColorName");
            }
        }

        private Color _bgColor;

        public Color BgColor
        {
            get => _bgColor;
            set
            {
                _bgColor = value;
                OnPropertyChanged("BgColor");
            }
        }

        private Color _bdColor;

        public Color BdColor
        {
            get => _bdColor;
            set
            {
                _bdColor = value;
                OnPropertyChanged("BdColor");
            }
        }

        private Color _fntColor;

        public Color FntColor
        {
            get => _fntColor;
            set
            {
                _fntColor = value;
                OnPropertyChanged("FntColor");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
