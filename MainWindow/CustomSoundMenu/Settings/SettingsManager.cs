using System;
using System.IO;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;
using MusicCircle.Properties;

namespace MusicCircle.Settings
{
    // Реализация IDisposable для освобеждения неиспользуемых ресурсов 
    // Идея по созданию своего парсера настроек в ini файл 
    // Либо использование Nuget пакета IniParser 

    internal class SettingsManager /*: IDisposable*/
    {
        private static SettingsManager _instance = null;
        public static SettingsManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SettingsManager();
                }
                return _instance;
            }
        }

        UserSettings _userSettings = UserSettings.Instance;
        private readonly string _path;
        private readonly FileIniDataParser _parser;
        private IniData _data;

        private SettingsManager(string filepath = null)
        {
            if (string.IsNullOrEmpty(filepath))
            {
                _path = AppDomain.CurrentDomain
                             .BaseDirectory.Remove(AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "Set\\"+"file.ini";
                //_path = Path.Combine("Set", "file.ini");
            }
            else
            {
                _path = filepath;
            }
            _parser = new FileIniDataParser();
        }

        public void LoadSettings()
        {
            
            if (File.Exists(_path))
            {
                _data = _parser.ReadFile(_path);
                for (int i = 0; i < 12; i++) {
                    _userSettings.OriganalMajorTonalityName[i].DescriptionOfTonality = _data["Major"]["DescriptionOfTonality" + i];
                    _userSettings.OriganalMajorTonalityName[i].NotesOfTonality = _data["Major"]["NotesOfTonality" + i];

                    _userSettings.OriganalMajorTonalityName[i].DescriptionOfTonality = _data["Minor"]["DescriptionOfTonality" + i];
                    _userSettings.OriganalMajorTonalityName[i].NotesOfTonality = _data["Minor"]["NotesOfTonality" + i];
                }
            }
            else
            {
                CreateIniFile();
            }
        }
        public void SaveSettings()
        {
            if (File.Exists(_path))
            {
                for (int i = 0; i < 12; i++)
                {
                    _data["Major"]["DescriptionOfTonality" + i] = _userSettings.OriganalMajorTonalityName[i].DescriptionOfTonality;
                    _data["Major"]["NotesOfTonality" + i] =       _userSettings.OriganalMajorTonalityName[i].NotesOfTonality;

                    _data["Minor"]["DescriptionOfTonality" + i] = _userSettings.OriganalMinorTonalityName[i].DescriptionOfTonality;
                    _data["Minor"]["NotesOfTonality" + i] =       _userSettings.OriganalMinorTonalityName[i].NotesOfTonality; 

                    _parser.WriteFile(_path, _data);
                }
            }
            else
            {
                CreateIniFile();
            }
        }

        private void CreateIniFile()
        {
            _data = new IniData();
            using (FileStream stream = File.Open(_path, FileMode.OpenOrCreate)) { };

            for (int i = 0; i < 12; i++)
            {
                _data["Major"]["DescriptionOfTonality" + i] = _userSettings.OriganalMajorTonalityName[i].DescriptionOfTonality;
                _data["Major"]["NotesOfTonality" + i] = _userSettings.OriganalMajorTonalityName[i].NotesOfTonality;
                
                _data["Minor"]["DescriptionOfTonality" + i] = _userSettings.OriganalMinorTonalityName[i].DescriptionOfTonality;
                _data["Minor"]["NotesOfTonality" + i] = _userSettings.OriganalMinorTonalityName[i].NotesOfTonality;

                
                _parser.WriteFile(_path, _data);
            }
        }
    }
}
