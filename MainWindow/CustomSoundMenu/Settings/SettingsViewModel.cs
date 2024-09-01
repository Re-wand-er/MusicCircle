using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;

namespace MusicCircle.Settings
{
    // Идея использовать текущую viewModel Для открытия вообще всех страниц и окон
    internal class SettingsViewModel : INotifyPropertyChanged
    {
        // Отвечает за отображение текущей страницы или окна
        private object _currentView;
        public object CurrentView
        {   
            get { return _currentView; } 
            set
            {
                    _currentView = value;
                    OnPropertyChanged(nameof(CurrentView));
            }
        }
        // Хранит VM всех страниц 
        private List<PageSettingsModel> _pageSettingsModel = new List<PageSettingsModel>();
        public List<PageSettingsModel> PageSettingsModel
        {
            get => _pageSettingsModel;
            set
            {
                if (_pageSettingsModel != value)
                {
                  _pageSettingsModel = value;
                  OnPropertyChanged(nameof(_pageSettingsModel));
                }
            }
        }
        // Команда которая сработает при нажатии кнопки
        public ICommand PagesClickCommand { get; }
        
        public SettingsViewModel(params PageSettingsModel[] page)
        {
            foreach(var p in page) PageSettingsModel.Add(p);
            
            CurrentView = PageSettingsModel[0].OpenUserControl;
            PagesClickCommand = new SettingsButtonCommandModel<object>(OpenPage);
        }
        private void OpenPage(object pages)
        {
            CurrentView = pages;  
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
