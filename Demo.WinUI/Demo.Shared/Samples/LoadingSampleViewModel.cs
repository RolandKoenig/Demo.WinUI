using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Demo.Shared.Util;

namespace Demo.Shared.Samples
{
    public class LoadingSampleViewModel : ViewModelBase
    {
        private bool _isLoading;
        private float _loadingProgress;
        private float _loadingProgressMax;

        public DelegateCommand Command_TriggerLoading
        {
            get;
        }

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                if(_isLoading != value)
                {
                    _isLoading = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public float LoadingProgress
        {
            get => _loadingProgress;
            set
            {
                if(_loadingProgress != value)
                {
                    _loadingProgress = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public float LoadingProgressMax
        {
            get => _loadingProgressMax;
            set
            {
                if (_loadingProgressMax != value)
                {
                    _loadingProgressMax = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public LoadingSampleViewModel()
        {
            this.Command_TriggerLoading = new DelegateCommand(this.OnCommand_TriggerLoading);
        }

        private async void OnCommand_TriggerLoading()
        {
            if (_isLoading) { return; }
            this.IsLoading = true;
            try
            {
                this.LoadingProgress = 0f;
                this.LoadingProgressMax = 100f;

                for(var loop=0; loop<10; loop++)
                {
                    await Task.Delay(200);
                    this.LoadingProgress = loop * 10f;
                }
                await Task.Delay(100);
            }
            finally
            {
                this.IsLoading = false;
            }
        }
    }
}
