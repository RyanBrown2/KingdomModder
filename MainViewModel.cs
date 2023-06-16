using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace KingdomModder
{
    public class MainViewModel: INotifyPropertyChanged
    {
        // Define properties representing the data needed by the UI
        private bool isFileOpen = false;
        public bool IsFileOpen
        {
            get { return isFileOpen; }
            set
            {
                isFileOpen = value;
                OnPropertyChanged(nameof(IsFileOpen));
            }
        }
        // Define commands representing the actions triggered by the UI

        // Constructor
        public MainViewModel()
        {
            // Initialize commands
        }

        // Implement the INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
