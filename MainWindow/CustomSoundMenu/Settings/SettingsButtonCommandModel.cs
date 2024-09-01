using System;
using System.Windows.Input;

namespace MusicCircle.Settings
{
    internal class SettingsButtonCommandModel<T> : ICommand
    {
        private readonly Action<T> _execute;
        // Может быть удален, а может и нет
        private readonly Predicate<T> _canExecute;
        //int count = 0;

        public SettingsButtonCommandModel(Action<T> action, Predicate<T> canExecute = null)
        {
            _execute = action ?? throw new ArgumentNullException(nameof(action)); 
            _canExecute = canExecute;
        }

        // Пока не реализованы
        public event EventHandler CanExecuteChanged
        {
            add { /*CommandManager.RequerySuggested += value;*/ }
            remove { /*CommandManager.RequerySuggested -= value;*/ }
        }

        public bool CanExecute(object parameter)
        {
            return true;
            //count++;
            //return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
           _execute((T)parameter);
        }
    }
}
