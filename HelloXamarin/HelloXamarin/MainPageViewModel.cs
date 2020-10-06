using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HelloXamarin
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string title;

        public string Title 
        { 
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(FormatedTitle));
            } 
        }

        public string FormatedTitle => $"The title is: {Title}";

        public ICommand ResetCommand { get; set; }

        public MainPageViewModel()
        {
            ResetCommand = new Command(Reset);
        }

        private void Reset()
        {
            Title = string.Empty;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
