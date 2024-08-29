using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using MusicCircle.Settings.CircleSettingsWindow.Pages.PageModel;
using MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel.UserControls;

namespace MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel
{
    internal class ChordPageVM : INotifyPropertyChanged
    {
        public ObservableCollection<TonalitySettingsVM> _originalMajorTonalityName;
        public ObservableCollection<TonalitySettingsVM> OriganalMajorTonalityName
        {
            get {  return _originalMajorTonalityName; }
            set 
            {  
                _originalMajorTonalityName = value; 
                OnPropertyChanged(nameof(OriganalMajorTonalityName)); 
            } 
        }

        public ObservableCollection<TonalitySettingsVM> _originalMinorTonalityName;
        public ObservableCollection<TonalitySettingsVM> OriganalMinorTonalityName
        {
            get { return _originalMinorTonalityName; }
            set
            {
                _originalMinorTonalityName = value;
                OnPropertyChanged(nameof(OriganalMinorTonalityName));
            }
        }

        public ChordPageVM() {
            OriganalMajorTonalityName = new ObservableCollection<TonalitySettingsVM> {
                new TonalitySettingsVM() { OriginalNameOfTonality="C",     DescriptionOfTonality="C",     NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="G",     DescriptionOfTonality="G",     NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="D",     DescriptionOfTonality="D",     NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="A",     DescriptionOfTonality="A",     NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="E",     DescriptionOfTonality="E",     NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="B",     DescriptionOfTonality="B",     NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Gb/F#", DescriptionOfTonality="Gb/F#", NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Db",    DescriptionOfTonality="Db",    NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Ab",    DescriptionOfTonality="Ab",    NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Eb",    DescriptionOfTonality="Eb",    NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Bb",    DescriptionOfTonality="Bb",    NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="F",     DescriptionOfTonality="F",     NotesOfTonality="A# D F F" }
            };

            OriganalMinorTonalityName = new ObservableCollection<TonalitySettingsVM> { 
                new TonalitySettingsVM() { OriginalNameOfTonality="Am",      DescriptionOfTonality="Am",      NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Em",      DescriptionOfTonality="Em",      NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Bm",      DescriptionOfTonality="Bm",      NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="F#m",     DescriptionOfTonality="F#m",     NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="C#m",     DescriptionOfTonality="C#m",     NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="G#m",     DescriptionOfTonality="G#m",     NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Ebm/D#m", DescriptionOfTonality="Ebm/D#m", NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Bbm",     DescriptionOfTonality="Bbm",     NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Fm",      DescriptionOfTonality="Fm",      NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Cm",      DescriptionOfTonality="Cm",      NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Gm",      DescriptionOfTonality="Gm",      NotesOfTonality="A# D F F" },
                new TonalitySettingsVM() { OriginalNameOfTonality="Dm",      DescriptionOfTonality="Dm",      NotesOfTonality="A# D F F" }
            };
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
