using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Toolkit.Forms.UI.Controls;

namespace Testing.WinFormsWithXamlIslands.Controls
{
    public partial class OwnInkControls : UserControl
    {
        private InkCanvas _inkCanvas;
        private InkToolbar _inkToolbar;

        public OwnInkControls()
        {
            InitializeComponent();
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);

            if (_inkToolbar != null)
            {
                _inkToolbar.Height = (int) (48f * this.GetDpiScaleFactor());
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode) { return; }
            if (_inkCanvas != null) { return; }
            if (_inkToolbar != null) { return; }

            _inkCanvas = new InkCanvas();
            _inkCanvas.Dock = DockStyle.Fill;
            this.Controls.Add(_inkCanvas);

            _inkToolbar = new InkToolbar();
            _inkToolbar.Dock = DockStyle.Top;
            _inkToolbar.Height = (int) (48f * this.GetDpiScaleFactor());
            _inkToolbar.AutoScaleMode = AutoScaleMode.Dpi;
            _inkToolbar.TargetInkCanvas = _inkCanvas;
            this.Controls.Add(_inkToolbar);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            if (this.DesignMode) { return; }

            if (_inkToolbar != null)
            {
                this.Controls.Remove(_inkToolbar);
                _inkToolbar.Dispose();
                _inkToolbar = null;
            }

            if (_inkCanvas != null)
            {
                this.Controls.Remove(_inkCanvas);
                _inkCanvas.Dispose();
                _inkCanvas = null;
            }
        }
    }
}
