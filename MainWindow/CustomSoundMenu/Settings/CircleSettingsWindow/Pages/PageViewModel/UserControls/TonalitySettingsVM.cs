using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel.UserControls
{
    internal class TonalitySettingsVM : INotifyPropertyChanged
    {

        public static int count;
        private string _originalNameOfTonality;
        public string OriginalNameOfTonality
        {
            get => _originalNameOfTonality;
            set 
            {
                _originalNameOfTonality = value + ":";
                OnPropertyChanged(nameof(OriginalNameOfTonality));
            }
        }
        private string _descriptionOfTonality;
        public string DescriptionOfTonality 
        { 
            get=> _descriptionOfTonality;
            set 
            {
                _descriptionOfTonality = value;
                OnPropertyChanged(nameof(DescriptionOfTonality));
            }
        }
        private string _notesOfTonality;
        public string NotesOfTonality 
        {
            get => _notesOfTonality;
            set 
            {
                _notesOfTonality = value;
                OnPropertyChanged(nameof(NotesOfTonality));
            }
        }
        public ICommand TestCommand { get; }
        public TonalitySettingsVM() 
        {
            TestCommand = new SettingsButtonCommandModel(Message);
            count++;
        }

        public void Message(object jo)
        {
            MessageBox.Show("Привязка есть");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
