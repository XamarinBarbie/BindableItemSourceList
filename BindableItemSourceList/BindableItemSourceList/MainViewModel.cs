using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BindableItemSourceList
{
    class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TextAndDetail> _dataList;

        public ObservableCollection<TextAndDetail> DataList
        {
            get => _dataList;
            set => SetProperty(ref _dataList, value);
        }

        public MainViewModel()
        {
            var data = new List<TextAndDetail>
            {
                new TextAndDetail{Text = "India", Detail = "New Delhi"},
                new TextAndDetail { Text = "Ireland", Detail = "Dublin" },
                new TextAndDetail { Text = "Italy", Detail = "Rome" }
            };
            DataList = new ObservableCollection<TextAndDetail>(data);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
                return false;

            storage = value;

            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
