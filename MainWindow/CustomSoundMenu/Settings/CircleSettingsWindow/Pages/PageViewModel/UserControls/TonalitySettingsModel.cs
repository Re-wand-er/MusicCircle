﻿namespace MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel.UserControls
{
    internal class TonalitySettingsModel /*: INotifyPropertyChanged*/
    {
        string _originalNameOfTonality;
        string _descriptionOfTonality;
        string _notesOfTonality;
        int _angleProperty;

        public string OriginalNameOfTonality
        {
            get => _originalNameOfTonality;
            set 
            {
                _originalNameOfTonality = value + ":";
                /*OnPropertyChanged(nameof(OriginalNameOfTonality));*/
            }
        }

        public string DescriptionOfTonality 
        { 
            get=> _descriptionOfTonality;
            set 
            {
                _descriptionOfTonality = value;
                /*OnPropertyChanged(nameof(DescriptionOfTonality));*/
            }
        }
        
        public string NotesOfTonality 
        {
            get => _notesOfTonality;
            set 
            {
                _notesOfTonality = value;
                /*OnPropertyChanged(nameof(NotesOfTonality));*/
            }
        }
        
        public int Angle 
        { 
            get => _angleProperty;
            set 
            { 
                _angleProperty = value; 
                //OnPropertyChanged(nameof(Index)); 
            }
        }


        /*public ICommand TestCommand { get; }
        public TonalitySettingsVM() 
        {
            TestCommand = new SettingsButtonCommandModel<object>(Message);
            count++;
        }

        public void Message(object jo)
        {
            MessageBox.Show("Привязка есть");
        }*/

        /*public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/
    }
}
