using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Testing.WinFormsWithXamlIslands;

namespace Testing.WpfWithXamlIslands.Controls
{
    public class OwnControlHost : Grid
    {
        public static readonly DependencyProperty SelectedControlProperty = DependencyProperty.Register(
            "SelectedControl", typeof(ControlMetaInfo), typeof(OwnControlHost), new PropertyMetadata(default(ControlMetaInfo)));

        public ControlMetaInfo SelectedControl
        {
            get { return (ControlMetaInfo) this.GetValue(SelectedControlProperty); }
            set { this.SetValue(SelectedControlProperty, value); }
        }

        /// <inheritdoc />
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
             
            if(e.Property == SelectedControlProperty)
            {
                this.Children.Clear();

                var selectedControl = this.SelectedControl;
                var createdUIElement = selectedControl?.CreateXamlUIElement();
                if(createdUIElement != null)
                {
                    this.Children.Add(createdUIElement);
                }
            }
        }
    }
}
