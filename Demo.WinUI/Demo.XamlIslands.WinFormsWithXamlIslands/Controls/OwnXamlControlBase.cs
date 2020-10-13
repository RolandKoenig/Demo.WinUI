using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Testing.WinFormsWithXamlIslands.Controls
{
    public abstract class OwnXamlControlBase<T> : UserControl
        where T : Control
    {
        public T XamlControl { get; private set; }

        protected abstract T CreateXamlControl();

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode) { return; }
            if (this.XamlControl != null) { return; }

            this.XamlControl = this.CreateXamlControl();
            this.XamlControl.Dock = DockStyle.Fill;
            this.Controls.Add(this.XamlControl);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            if (this.DesignMode) { return; }
            if (this.XamlControl == null) { return; }

            this.Controls.Remove(this.XamlControl);

            this.XamlControl.Dispose();
            this.XamlControl = null;
        }
    }
}
