using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Demo.Shared.Util
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event EventHandler<CloseWindowRequestEventArgs> CloseWindowRequest;

        public event EventHandler<ViewServiceRequestEventArgs> ViewServiceRequest;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void CloseWindow(object dialogResult)
        {
            this.CloseWindowRequest?.Invoke(this, new CloseWindowRequestEventArgs(dialogResult));
        }

        /// <summary>
        /// Gets the view service of the given type.
        /// </summary>
        protected T GetViewService<T>()
            where T : class
        {
            var eventArgs = new ViewServiceRequestEventArgs(typeof(T));
            this.ViewServiceRequest?.Invoke(this, eventArgs);

            if (!(eventArgs.ViewService is T result))
            {
                throw new ApplicationException($"Unable to get view service of type {typeof(T).FullName}!");
            }
            return result;
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
