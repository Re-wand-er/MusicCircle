using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace MusicCircle.Settings
{
    internal class SettingsViewModel /*: INotifyPropertyChanged*/
    {
        private List<string> _textContent;
        public List<string> TextContent
        {
            get => this._textContent;
            set
            {
                _textContent = value;
                //OnPropertyChanged();
            }
        }

        public ICommand ButtonClickCommand { get; }

        public SettingsViewModel()
        {
            TextContent = new List<string>() { "Standart text", "None standart text", "Second"};
        }
        public SettingsViewModel(string text/*, Action action*/)
        {
            TextContent = new List<string>() { text};
            //
            //ChangeTextCommand = new RelayCommand(ChangeText);
        }


        //public event PropertyChangedEventHandler PropertyChanged;
        //
        //protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
