using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Demo.WinFormsWithXamlIslands;
using Demo.XamlIslands.WpfWithXamlIslands.Controls;
using Demo.XamlIslands.WpfWithXamlIslands.Util;

namespace Demo.XamlIslands.WpfWithXamlIslands
{
    public class MainWindowViewModel : PropertyChangedBase
    {
        private ControlMetaInfo _selectedControl;

        public ObservableCollection<ControlMetaInfo> Controls { get; } = new ObservableCollection<ControlMetaInfo>();

        public ControlMetaInfo SelectedControl
        {
            get => _selectedControl;
            set
            {
                if (_selectedControl != value)
                {
                    _selectedControl = value;
                    this.RaisePropertyChanged(nameof(this.SelectedControl));
                    this.RaisePropertyChanged(nameof(this.SelectedControlName));
                }
            }
        }

        public string SelectedControlName => _selectedControl != null ? _selectedControl.ToString() : "-";

        public MainWindowViewModel()
        {
            this.Controls.Add(new ControlMetaInfo(typeof(OwnMapControl)));
            this.Controls.Add(new ControlMetaInfo(typeof(OwnMediaPlayerControl)));
            this.Controls.Add(new ControlMetaInfo(typeof(OwnInkCanvasControl)));
            this.Controls.Add(new ControlMetaInfo(typeof(OwnCustomSimpleUserControl)));
        }
    }
}
