using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.WinUI3InUWP.Util
{
    public class CommandToWinUIConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return new CommandWrapper((System.Windows.Input.ICommand)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }

        //*********************************************************************
        //*********************************************************************
        //*********************************************************************
        private class CommandWrapper : ICommand
        {
            private System.Windows.Input.ICommand _winCommand;
            private List<EventHandler<object>> _canExecuteChangedList = new List<EventHandler<object>>();

            public event EventHandler<object> CanExecuteChanged;

            public CommandWrapper(System.Windows.Input.ICommand winCommand)
            {
                _winCommand = winCommand;
            }

            public bool CanExecute(object parameter)
            {
                return _winCommand.CanExecute(parameter);
            }

            public void Execute(object parameter)
            {
                _winCommand.Execute(parameter);
            }
        }
    }
}
