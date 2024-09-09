using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel.UserControls;
using MusicCircle.SoundPlayAlghorithms;

namespace MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel
{
    internal class ChordPageVM : INotifyPropertyChanged
    {
        private static ChordPageVM instance = null;
        public static ChordPageVM Instance {
            get
            {
                if (instance == null)
                {
                    instance = new ChordPageVM();
                }
                return instance;
            }
        }

        public ObservableCollection<TonalitySettingsModel> _originalMajorTonalityName;
        public ObservableCollection<TonalitySettingsModel> _originalMinorTonalityName;

        public ObservableCollection<TonalitySettingsModel> OriganalMajorTonalityName
        {
            get {  return _originalMajorTonalityName; }
            set 
            {  
                _originalMajorTonalityName = value; 
                OnPropertyChanged(nameof(OriganalMajorTonalityName)); 
            } 
        }
        public ObservableCollection<TonalitySettingsModel> OriganalMinorTonalityName
        {
            get { return _originalMinorTonalityName; }
            set
            {
                _originalMinorTonalityName = value;
                OnPropertyChanged(nameof(OriganalMinorTonalityName));
            }
        }

        private ChordPageVM() {
            
                UserSettings settings = UserSettings.Instance;

                OriganalMajorTonalityName = settings.OriganalMajorTonalityName;
            /*= new ObservableCollection<TonalitySettingsModel> {
                new TonalitySettingsModel() { OriginalNameOfTonality="C",       DescriptionOfTonality="C",       NotesOfTonality="C E G",    Angle=270 },
                new TonalitySettingsModel() { OriginalNameOfTonality="G",       DescriptionOfTonality="G",       NotesOfTonality="G B D",    Angle=300 },
                new TonalitySettingsModel() { OriginalNameOfTonality="D",       DescriptionOfTonality="D",       NotesOfTonality="D F# A",   Angle=330 },
                new TonalitySettingsModel() { OriginalNameOfTonality="A",       DescriptionOfTonality="A",       NotesOfTonality="A C# E",   Angle=0   },
                new TonalitySettingsModel() { OriginalNameOfTonality="E",       DescriptionOfTonality="E",       NotesOfTonality="E G# B",   Angle=30  },
                new TonalitySettingsModel() { OriginalNameOfTonality="B",       DescriptionOfTonality="B",       NotesOfTonality="B D# F#",  Angle=60  },
                new TonalitySettingsModel() { OriginalNameOfTonality="Gb/F#",   DescriptionOfTonality="Gb/F#",   NotesOfTonality="F# A# C#", Angle=90  },
                new TonalitySettingsModel() { OriginalNameOfTonality="Db",      DescriptionOfTonality="Db",      NotesOfTonality="C# F G#",  Angle=120 },
                new TonalitySettingsModel() { OriginalNameOfTonality="Ab",      DescriptionOfTonality="Ab",      NotesOfTonality="G# C D#",  Angle=150 },
                new TonalitySettingsModel() { OriginalNameOfTonality="Eb",      DescriptionOfTonality="Eb",      NotesOfTonality="D# G A#",  Angle=180 },
                new TonalitySettingsModel() { OriginalNameOfTonality="Bb",      DescriptionOfTonality="Bb",      NotesOfTonality="A# D F",   Angle=210 },
                new TonalitySettingsModel() { OriginalNameOfTonality="F",       DescriptionOfTonality="F",       NotesOfTonality="F A C",    Angle=240 }
            };*/

                OriganalMinorTonalityName = settings.OriganalMinorTonalityName; /*new ObservableCollection<TonalitySettingsModel> { 
                new TonalitySettingsModel() { OriginalNameOfTonality="Am",      DescriptionOfTonality="Am",      NotesOfTonality="A C E",    Angle=270 },
                new TonalitySettingsModel() { OriginalNameOfTonality="Em",      DescriptionOfTonality="Em",      NotesOfTonality="E G B",    Angle=300 },
                new TonalitySettingsModel() { OriginalNameOfTonality="Bm",      DescriptionOfTonality="Bm",      NotesOfTonality="B D F#",   Angle=330 },
                new TonalitySettingsModel() { OriginalNameOfTonality="F#m",     DescriptionOfTonality="F#m",     NotesOfTonality="F# A C#",  Angle=0   },
                new TonalitySettingsModel() { OriginalNameOfTonality="C#m",     DescriptionOfTonality="C#m",     NotesOfTonality="C# E G#",  Angle=30  },
                new TonalitySettingsModel() { OriginalNameOfTonality="G#m",     DescriptionOfTonality="G#m",     NotesOfTonality="G# B D#",  Angle=60  },
                new TonalitySettingsModel() { OriginalNameOfTonality="Ebm/D#m", DescriptionOfTonality="Ebm/D#m", NotesOfTonality="D# F# A#", Angle=90  },
                new TonalitySettingsModel() { OriginalNameOfTonality="Bbm",     DescriptionOfTonality="Bbm",     NotesOfTonality="A# C# F",  Angle=120 },
                new TonalitySettingsModel() { OriginalNameOfTonality="Fm",      DescriptionOfTonality="Fm",      NotesOfTonality="F G# C",   Angle=150 },
                new TonalitySettingsModel() { OriginalNameOfTonality="Cm",      DescriptionOfTonality="Cm",      NotesOfTonality="C D# G",   Angle=180 },
                new TonalitySettingsModel() { OriginalNameOfTonality="Gm",      DescriptionOfTonality="Gm",      NotesOfTonality="G A# D",   Angle=210 },
                new TonalitySettingsModel() { OriginalNameOfTonality="Dm",      DescriptionOfTonality="Dm",      NotesOfTonality="D F A",    Angle=240 }
            };*/

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
