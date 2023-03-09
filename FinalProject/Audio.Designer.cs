
namespace FinalProject
{
    partial class formAudio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAudio));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menubtnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnControl = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnPause = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnResume = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnVolumeUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnVolumeDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnFaster = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnF15 = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnF2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnSlower = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnS15 = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnS2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnReverse = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnMerge = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProperties = new System.Windows.Forms.ListView();
            this.colProperty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerAudio = new System.Windows.Forms.Timer(this.components);
            this.scrollPlayPosition = new System.Windows.Forms.HScrollBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbtnPlay = new System.Windows.Forms.ToolStripButton();
            this.toolbtnResume = new System.Windows.Forms.ToolStripButton();
            this.toolbtnPause = new System.Windows.Forms.ToolStripButton();
            this.toolbtnVolumeDown = new System.Windows.Forms.ToolStripButton();
            this.toolbtnVolumeUp = new System.Windows.Forms.ToolStripButton();
            this.menuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnFile,
            this.menubtnControl,
            this.menubtnEdit,
            this.menubtnMerge});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(530, 33);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menubtnFile
            // 
            this.menubtnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnOpen,
            this.menubtnSave,
            this.menubtnSaveAs});
            this.menubtnFile.Name = "menubtnFile";
            this.menubtnFile.Size = new System.Drawing.Size(54, 29);
            this.menubtnFile.Text = "File";
            // 
            // menubtnOpen
            // 
            this.menubtnOpen.Name = "menubtnOpen";
            this.menubtnOpen.Size = new System.Drawing.Size(176, 34);
            this.menubtnOpen.Text = "Open";
            this.menubtnOpen.Click += new System.EventHandler(this.menubtnOpen_Click);
            // 
            // menubtnSave
            // 
            this.menubtnSave.Enabled = false;
            this.menubtnSave.Name = "menubtnSave";
            this.menubtnSave.Size = new System.Drawing.Size(176, 34);
            this.menubtnSave.Text = "Save";
            this.menubtnSave.Click += new System.EventHandler(this.menubtnSave_Click);
            // 
            // menubtnSaveAs
            // 
            this.menubtnSaveAs.Enabled = false;
            this.menubtnSaveAs.Name = "menubtnSaveAs";
            this.menubtnSaveAs.Size = new System.Drawing.Size(176, 34);
            this.menubtnSaveAs.Text = "Save As";
            this.menubtnSaveAs.Click += new System.EventHandler(this.menubtnSaveAs_Click);
            // 
            // menubtnControl
            // 
            this.menubtnControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnPlay,
            this.menubtnPause,
            this.menubtnResume,
            this.menubtnVolumeUp,
            this.menubtnVolumeDown});
            this.menubtnControl.Enabled = false;
            this.menubtnControl.Name = "menubtnControl";
            this.menubtnControl.Size = new System.Drawing.Size(87, 29);
            this.menubtnControl.Text = "Control";
            // 
            // menubtnPlay
            // 
            this.menubtnPlay.Name = "menubtnPlay";
            this.menubtnPlay.Size = new System.Drawing.Size(226, 34);
            this.menubtnPlay.Text = "Play";
            this.menubtnPlay.Click += new System.EventHandler(this.menubtnPlay_Click);
            // 
            // menubtnPause
            // 
            this.menubtnPause.Enabled = false;
            this.menubtnPause.Name = "menubtnPause";
            this.menubtnPause.Size = new System.Drawing.Size(226, 34);
            this.menubtnPause.Text = "Pause";
            this.menubtnPause.Click += new System.EventHandler(this.menubtnPause_Click);
            // 
            // menubtnResume
            // 
            this.menubtnResume.Enabled = false;
            this.menubtnResume.Name = "menubtnResume";
            this.menubtnResume.Size = new System.Drawing.Size(226, 34);
            this.menubtnResume.Text = "Resume";
            this.menubtnResume.Click += new System.EventHandler(this.menubtnResume_Click);
            // 
            // menubtnVolumeUp
            // 
            this.menubtnVolumeUp.Enabled = false;
            this.menubtnVolumeUp.Name = "menubtnVolumeUp";
            this.menubtnVolumeUp.Size = new System.Drawing.Size(226, 34);
            this.menubtnVolumeUp.Text = "Volume Up";
            this.menubtnVolumeUp.Click += new System.EventHandler(this.menubtnVolumeUp_Click);
            // 
            // menubtnVolumeDown
            // 
            this.menubtnVolumeDown.Name = "menubtnVolumeDown";
            this.menubtnVolumeDown.Size = new System.Drawing.Size(226, 34);
            this.menubtnVolumeDown.Text = "Volume Down";
            this.menubtnVolumeDown.Click += new System.EventHandler(this.menubtnVolumeDown_Click);
            // 
            // menubtnEdit
            // 
            this.menubtnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnFaster,
            this.menubtnSlower,
            this.menubtnReverse});
            this.menubtnEdit.Enabled = false;
            this.menubtnEdit.Name = "menubtnEdit";
            this.menubtnEdit.Size = new System.Drawing.Size(58, 29);
            this.menubtnEdit.Text = "Edit";
            // 
            // menubtnFaster
            // 
            this.menubtnFaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnF15,
            this.menubtnF2});
            this.menubtnFaster.Name = "menubtnFaster";
            this.menubtnFaster.Size = new System.Drawing.Size(174, 34);
            this.menubtnFaster.Text = "Faster";
            this.menubtnFaster.Click += new System.EventHandler(this.menubtnFaster_Click);
            // 
            // menubtnF15
            // 
            this.menubtnF15.Name = "menubtnF15";
            this.menubtnF15.Size = new System.Drawing.Size(138, 34);
            this.menubtnF15.Text = "1.5";
            this.menubtnF15.Click += new System.EventHandler(this.menubtnF15_Click);
            // 
            // menubtnF2
            // 
            this.menubtnF2.Name = "menubtnF2";
            this.menubtnF2.Size = new System.Drawing.Size(138, 34);
            this.menubtnF2.Text = "2";
            this.menubtnF2.Click += new System.EventHandler(this.menubtnF2_Click);
            // 
            // menubtnSlower
            // 
            this.menubtnSlower.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnS15,
            this.menubtnS2});
            this.menubtnSlower.Name = "menubtnSlower";
            this.menubtnSlower.Size = new System.Drawing.Size(174, 34);
            this.menubtnSlower.Text = "Slower";
            this.menubtnSlower.Click += new System.EventHandler(this.menubtnSlower_Click);
            // 
            // menubtnS15
            // 
            this.menubtnS15.Name = "menubtnS15";
            this.menubtnS15.Size = new System.Drawing.Size(138, 34);
            this.menubtnS15.Text = "1.5";
            this.menubtnS15.Click += new System.EventHandler(this.menubtnS15_Click);
            // 
            // menubtnS2
            // 
            this.menubtnS2.Name = "menubtnS2";
            this.menubtnS2.Size = new System.Drawing.Size(138, 34);
            this.menubtnS2.Text = "2";
            this.menubtnS2.Click += new System.EventHandler(this.menubtnS2_Click);
            // 
            // menubtnReverse
            // 
            this.menubtnReverse.Name = "menubtnReverse";
            this.menubtnReverse.Size = new System.Drawing.Size(174, 34);
            this.menubtnReverse.Text = "Reverse";
            this.menubtnReverse.Click += new System.EventHandler(this.menubtnReverse_Click);
            // 
            // menubtnMerge
            // 
            this.menubtnMerge.Enabled = false;
            this.menubtnMerge.Name = "menubtnMerge";
            this.menubtnMerge.Size = new System.Drawing.Size(79, 29);
            this.menubtnMerge.Text = "Merge";
            this.menubtnMerge.Click += new System.EventHandler(this.menubtnMerge_Click_1);
            // 
            // viewProperties
            // 
            this.viewProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProperty,
            this.colValue});
            this.viewProperties.HideSelection = false;
            this.viewProperties.Location = new System.Drawing.Point(12, 48);
            this.viewProperties.Name = "viewProperties";
            this.viewProperties.Size = new System.Drawing.Size(506, 210);
            this.viewProperties.TabIndex = 1;
            this.viewProperties.UseCompatibleStateImageBehavior = false;
            this.viewProperties.View = System.Windows.Forms.View.Details;
            this.viewProperties.SelectedIndexChanged += new System.EventHandler(this.viewProperties_SelectedIndexChanged);
            // 
            // colProperty
            // 
            this.colProperty.Text = "Property";
            this.colProperty.Width = 170;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 170;
            // 
            // timerAudio
            // 
            this.timerAudio.Interval = 500;
            this.timerAudio.Tick += new System.EventHandler(this.timerAudio_Tick);
            // 
            // scrollPlayPosition
            // 
            this.scrollPlayPosition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scrollPlayPosition.Location = new System.Drawing.Point(0, 286);
            this.scrollPlayPosition.Maximum = 1000;
            this.scrollPlayPosition.Name = "scrollPlayPosition";
            this.scrollPlayPosition.Size = new System.Drawing.Size(530, 26);
            this.scrollPlayPosition.TabIndex = 2;
            this.scrollPlayPosition.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollPlayPosition_Scroll);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnPlay,
            this.toolbtnResume,
            this.toolbtnPause,
            this.toolbtnVolumeDown,
            this.toolbtnVolumeUp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 253);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(530, 33);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbtnPlay
            // 
            this.toolbtnPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnPlay.Enabled = false;
            this.toolbtnPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnPlay.Image")));
            this.toolbtnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnPlay.Name = "toolbtnPlay";
            this.toolbtnPlay.Size = new System.Drawing.Size(34, 28);
            this.toolbtnPlay.Text = "Play";
            this.toolbtnPlay.Click += new System.EventHandler(this.toolbtnPlay_Click);
            // 
            // toolbtnResume
            // 
            this.toolbtnResume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnResume.Enabled = false;
            this.toolbtnResume.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnResume.Image")));
            this.toolbtnResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnResume.Name = "toolbtnResume";
            this.toolbtnResume.Size = new System.Drawing.Size(34, 28);
            this.toolbtnResume.Text = "Resume";
            this.toolbtnResume.Click += new System.EventHandler(this.toolbtnResume_Click);
            // 
            // toolbtnPause
            // 
            this.toolbtnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnPause.Enabled = false;
            this.toolbtnPause.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnPause.Image")));
            this.toolbtnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnPause.Name = "toolbtnPause";
            this.toolbtnPause.Size = new System.Drawing.Size(34, 28);
            this.toolbtnPause.Text = "Pause";
            this.toolbtnPause.Click += new System.EventHandler(this.toolbtnPause_Click);
            // 
            // toolbtnVolumeDown
            // 
            this.toolbtnVolumeDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnVolumeDown.Enabled = false;
            this.toolbtnVolumeDown.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnVolumeDown.Image")));
            this.toolbtnVolumeDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnVolumeDown.Name = "toolbtnVolumeDown";
            this.toolbtnVolumeDown.Size = new System.Drawing.Size(34, 28);
            this.toolbtnVolumeDown.Text = "Volume Down";
            this.toolbtnVolumeDown.Click += new System.EventHandler(this.toolbtnVolumeDown_Click);
            // 
            // toolbtnVolumeUp
            // 
            this.toolbtnVolumeUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnVolumeUp.Enabled = false;
            this.toolbtnVolumeUp.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnVolumeUp.Image")));
            this.toolbtnVolumeUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnVolumeUp.Name = "toolbtnVolumeUp";
            this.toolbtnVolumeUp.Size = new System.Drawing.Size(34, 28);
            this.toolbtnVolumeUp.Text = "Volume Up";
            this.toolbtnVolumeUp.Click += new System.EventHandler(this.toolbtnVolumeUp_Click);
            // 
            // formAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 312);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.scrollPlayPosition);
            this.Controls.Add(this.viewProperties);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "formAudio";
            this.Text = "Audio";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menubtnFile;
        private System.Windows.Forms.ToolStripMenuItem menubtnOpen;
        private System.Windows.Forms.ToolStripMenuItem menubtnControl;
        private System.Windows.Forms.ToolStripMenuItem menubtnPlay;
        private System.Windows.Forms.ToolStripMenuItem menubtnPause;
        private System.Windows.Forms.ListView viewProperties;
        private System.Windows.Forms.ColumnHeader colProperty;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.Timer timerAudio;
        private System.Windows.Forms.HScrollBar scrollPlayPosition;
        private System.Windows.Forms.ToolStripMenuItem menubtnEdit;
        private System.Windows.Forms.ToolStripMenuItem menubtnFaster;
        private System.Windows.Forms.ToolStripMenuItem menubtnSlower;
        private System.Windows.Forms.ToolStripMenuItem menubtnReverse;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolbtnPlay;
        private System.Windows.Forms.ToolStripMenuItem menubtnVolumeUp;
        private System.Windows.Forms.ToolStripMenuItem menubtnVolumeDown;
        private System.Windows.Forms.ToolStripMenuItem menubtnF15;
        private System.Windows.Forms.ToolStripMenuItem menubtnF2;
        private System.Windows.Forms.ToolStripMenuItem menubtnS15;
        private System.Windows.Forms.ToolStripMenuItem menubtnS2;
        private System.Windows.Forms.ToolStripButton toolbtnPause;
        private System.Windows.Forms.ToolStripButton toolbtnVolumeDown;
        private System.Windows.Forms.ToolStripButton toolbtnVolumeUp;
        private System.Windows.Forms.ToolStripMenuItem menubtnSave;
        private System.Windows.Forms.ToolStripMenuItem menubtnMerge;
        private System.Windows.Forms.ToolStripMenuItem menubtnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menubtnResume;
        private System.Windows.Forms.ToolStripButton toolbtnResume;
    }
}

