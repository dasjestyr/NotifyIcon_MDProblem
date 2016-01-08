using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace NotifyIcon_MDDemo
{
    /// <summary>
    /// Interaction logic for NoTray.xaml
    /// </summary>
    public partial class NoTray : Window, INotifyPropertyChanged
    {
        private ObservableCollection<string> _items;

        public ObservableCollection<string> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        public NoTray()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var items = new List<string>
            {
                "Sub Item 1",
                "Sub Item 2",
                "Sub Item 3",
            };
            Items = new ObservableCollection<string>(items);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
