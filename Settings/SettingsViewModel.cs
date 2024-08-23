using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows;
using MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel;

namespace MusicCircle.Settings
{
    internal class SettingsViewModel : INotifyPropertyChanged
    {
        // Отвечает за отображение текущей страницы
        private object _currentPage;
        public object CurrentPage
        {   
            get { return _currentPage; } 
            set
            {
                    _currentPage = value;
                    OnPropertyChanged(nameof(CurrentPage));
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
        private void OpenPage(object pages)
        {
            CurrentPage = pages;  
        }
        public SettingsViewModel(params PageSettingsModel[] page)
        {
            foreach(var p in page) PageSettingsModel.Add(p);

            CurrentPage = page[0].OpenUserControl;
            PagesClickCommand = new SettingsButtonCommandModel(OpenPage);
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
