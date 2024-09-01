using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using MusicCircle.Settings.CircleSettingsWindow.Pages.PageModel;
using MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel.UserControls;
using MusicCircle.SoundPlayAlghorithms;

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
                new TonalitySettingsVM() { OriginalNameOfTonality="C",       DescriptionOfTonality="C",       NotesOfTonality="C E G",    Angle=270 },
                new TonalitySettingsVM() { OriginalNameOfTonality="G",       DescriptionOfTonality="G",       NotesOfTonality="G B D",    Angle=300 },
                new TonalitySettingsVM() { OriginalNameOfTonality="D",       DescriptionOfTonality="D",       NotesOfTonality="D F# A",   Angle=330 },
                new TonalitySettingsVM() { OriginalNameOfTonality="A",       DescriptionOfTonality="A",       NotesOfTonality="A C# E",   Angle=0   },
                new TonalitySettingsVM() { OriginalNameOfTonality="E",       DescriptionOfTonality="E",       NotesOfTonality="E G# B",   Angle=30  },
                new TonalitySettingsVM() { OriginalNameOfTonality="B",       DescriptionOfTonality="B",       NotesOfTonality="B D# F#",  Angle=60  },
                new TonalitySettingsVM() { OriginalNameOfTonality="Gb/F#",   DescriptionOfTonality="Gb/F#",   NotesOfTonality="F# A# C#", Angle=90  },
                new TonalitySettingsVM() { OriginalNameOfTonality="Db",      DescriptionOfTonality="Db",      NotesOfTonality="C# F G#",  Angle=120 },
                new TonalitySettingsVM() { OriginalNameOfTonality="Ab",      DescriptionOfTonality="Ab",      NotesOfTonality="G# C D#",  Angle=150 },
                new TonalitySettingsVM() { OriginalNameOfTonality="Eb",      DescriptionOfTonality="Eb",      NotesOfTonality="D# G A#",  Angle=180 },
                new TonalitySettingsVM() { OriginalNameOfTonality="Bb",      DescriptionOfTonality="Bb",      NotesOfTonality="A# D F",   Angle=210 },
                new TonalitySettingsVM() { OriginalNameOfTonality="F",       DescriptionOfTonality="F",       NotesOfTonality="F A C",    Angle=240 }
            };

            OriganalMinorTonalityName = new ObservableCollection<TonalitySettingsVM> { 
                new TonalitySettingsVM() { OriginalNameOfTonality="Am",      DescriptionOfTonality="Am",      NotesOfTonality="A C E",    Angle=270 },
                new TonalitySettingsVM() { OriginalNameOfTonality="Em",      DescriptionOfTonality="Em",      NotesOfTonality="E G B",    Angle=300 },
                new TonalitySettingsVM() { OriginalNameOfTonality="Bm",      DescriptionOfTonality="Bm",      NotesOfTonality="B D F#",   Angle=330 },
                new TonalitySettingsVM() { OriginalNameOfTonality="F#m",     DescriptionOfTonality="F#m",     NotesOfTonality="F# A C#",  Angle=0   },
                new TonalitySettingsVM() { OriginalNameOfTonality="C#m",     DescriptionOfTonality="C#m",     NotesOfTonality="C# E G#",  Angle=30  },
                new TonalitySettingsVM() { OriginalNameOfTonality="G#m",     DescriptionOfTonality="G#m",     NotesOfTonality="G# B D#",  Angle=60  },
                new TonalitySettingsVM() { OriginalNameOfTonality="Ebm/D#m", DescriptionOfTonality="Ebm/D#m", NotesOfTonality="D# F# A#", Angle=90  },
                new TonalitySettingsVM() { OriginalNameOfTonality="Bbm",     DescriptionOfTonality="Bbm",     NotesOfTonality="A# C# F",  Angle=120 },
                new TonalitySettingsVM() { OriginalNameOfTonality="Fm",      DescriptionOfTonality="Fm",      NotesOfTonality="F G# C",   Angle=150 },
                new TonalitySettingsVM() { OriginalNameOfTonality="Cm",      DescriptionOfTonality="Cm",      NotesOfTonality="C D# G",   Angle=180 },
                new TonalitySettingsVM() { OriginalNameOfTonality="Gm",      DescriptionOfTonality="Gm",      NotesOfTonality="G A# D",   Angle=210 },
                new TonalitySettingsVM() { OriginalNameOfTonality="Dm",      DescriptionOfTonality="Dm",      NotesOfTonality="D F A",    Angle=240 }
            };

            SoundCommand = new SettingsButtonCommandModel<string>(Sound); 
        }

        public ICommand SoundCommand { get; set; }

        public async void Sound(string str)
        {
            await ChordSound.Play(str);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
