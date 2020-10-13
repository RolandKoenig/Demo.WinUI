using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Toolkit.Forms.UI.Controls;

namespace Demo.XamlIslands.WinFormsWithXamlIslands.Controls
{
    public partial class OwnMediaPlayer : OwnXamlControlBase<MediaPlayerElement>
    {
        public OwnMediaPlayer()
        {
            InitializeComponent();

            
        }

        protected override MediaPlayerElement CreateXamlControl()
        {
            return new MediaPlayerElement();
        }
    }
}
