using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.CodeDom.Compiler;

namespace MusicCircle.Settings
{
    internal class SettingsButtonCommandModel : ICommand
    {
        private readonly Action<object> _execute;
        // Может быть удален, а может и нет
        private readonly Predicate<object> _canExecute;
        //int count = 0;

        public SettingsButtonCommandModel(Action<object> action, Predicate<object> canExecute = null)
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
           _execute(parameter);
        }
    }
}
