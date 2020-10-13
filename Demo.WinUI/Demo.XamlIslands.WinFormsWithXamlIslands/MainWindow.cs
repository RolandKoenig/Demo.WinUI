using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.XamlIslands.WinFormsWithXamlIslands.Controls;

namespace Demo.XamlIslands.WinFormsWithXamlIslands
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearContentPanel()
        {
            while (_panContent.Controls.Count > 0)
            {
                var actRemovedControl = _panContent.Controls[0];
                _panContent.Controls.RemoveAt(0);
                actRemovedControl.Dispose();

                _panContent.Text = "-";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.DesignMode) { return; }

            _lstControls.Items.Add(new ControlMetaInfo(typeof(OwnMapControl)));
            _lstControls.Items.Add(new ControlMetaInfo(typeof(OwnMediaPlayer)));
            _lstControls.Items.Add(new ControlMetaInfo(typeof(OwnInkControls)));
            _lstControls.Items.Add(new ControlMetaInfo(typeof(OwnCustomSimpleUserControl)));
        }

        private void OnLstControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            var metaInfo = _lstControls.SelectedItem as ControlMetaInfo;
            if (metaInfo == null)
            {
                this.ClearContentPanel();
            }
            else
            {
                this.ClearContentPanel();

                var newControl = metaInfo.CreateControl();
                newControl.Dock = DockStyle.Fill;
                _panContent.Controls.Add(newControl);
                _panContent.Text = metaInfo.ToString();
            }
        }
    }
}
