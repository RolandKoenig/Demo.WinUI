using System.Windows.Forms;

namespace Testing.WinFormsWithXamlIslands
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.MenuStrip menuStrip1;
            System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
            System.Windows.Forms.StatusStrip statusStrip1;
            System.Windows.Forms.GroupBox groupBox1;
            this._lstControls = new System.Windows.Forms.ListBox();
            this._ctrlSplitter = new System.Windows.Forms.SplitContainer();
            this._panContent = new System.Windows.Forms.GroupBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            groupBox1 = new System.Windows.Forms.GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ctrlSplitter)).BeginInit();
            this._ctrlSplitter.Panel1.SuspendLayout();
            this._ctrlSplitter.Panel2.SuspendLayout();
            this._ctrlSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem1});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this._lstControls);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(266, 404);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Xaml Controls";
            // 
            // _lstControls
            // 
            this._lstControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lstControls.FormattingEnabled = true;
            this._lstControls.ItemHeight = 15;
            this._lstControls.Location = new System.Drawing.Point(3, 19);
            this._lstControls.Name = "_lstControls";
            this._lstControls.Size = new System.Drawing.Size(260, 382);
            this._lstControls.TabIndex = 0;
            this._lstControls.SelectedIndexChanged += new System.EventHandler(this.OnLstControls_SelectedIndexChanged);
            // 
            // _ctrlSplitter
            // 
            this._ctrlSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ctrlSplitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._ctrlSplitter.Location = new System.Drawing.Point(0, 24);
            this._ctrlSplitter.Name = "_ctrlSplitter";
            // 
            // _ctrlSplitter.Panel1
            // 
            this._ctrlSplitter.Panel1.Controls.Add(groupBox1);
            // 
            // _ctrlSplitter.Panel2
            // 
            this._ctrlSplitter.Panel2.Controls.Add(this._panContent);
            this._ctrlSplitter.Size = new System.Drawing.Size(800, 404);
            this._ctrlSplitter.SplitterDistance = 266;
            this._ctrlSplitter.TabIndex = 2;
            this._ctrlSplitter.Text = "splitContainer1";
            // 
            // _panContent
            // 
            this._panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panContent.Location = new System.Drawing.Point(0, 0);
            this._panContent.Name = "_panContent";
            this._panContent.Size = new System.Drawing.Size(530, 404);
            this._panContent.TabIndex = 0;
            this._panContent.Text = "-";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._ctrlSplitter);
            this.Controls.Add(statusStrip1);
            this.Controls.Add(menuStrip1);
            this.MainMenuStrip = menuStrip1;
            this.Name = "MainWindow";
            this.Text = "XamlIslands with Windows.Forms";
            this.AutoScaleMode = AutoScaleMode.Dpi;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            this._ctrlSplitter.Panel1.ResumeLayout(false);
            this._ctrlSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ctrlSplitter)).EndInit();
            this._ctrlSplitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer _ctrlSplitter;
        private System.Windows.Forms.ListBox _lstControls;
        private System.Windows.Forms.GroupBox _panContent;
    }
}

