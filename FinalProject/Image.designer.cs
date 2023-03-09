
namespace FinalProject
{
    partial class formImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formImage));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menubtnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnToRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnToGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnToBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnToGray = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnLaminate = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnDarken = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnAddColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnWeighted = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtn4Colors = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnGraphics = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnAddText = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnAddImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menubtnRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusImgInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureMain = new System.Windows.Forms.PictureBox();
            this.checkBoxRectangle = new System.Windows.Forms.CheckBox();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.toolbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolbtnUndo = new System.Windows.Forms.ToolStripButton();
            this.toolbtnRedo = new System.Windows.Forms.ToolStripButton();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            this.toolMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnFile,
            this.menubtnEdit,
            this.menubtnAddColor,
            this.menubtnGraphics,
            this.menubtnUndo,
            this.menubtnRedo});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(978, 33);
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
            this.menubtnFile.Click += new System.EventHandler(this.menubtnFile_Click);
            // 
            // menubtnOpen
            // 
            this.menubtnOpen.Name = "menubtnOpen";
            this.menubtnOpen.Size = new System.Drawing.Size(270, 34);
            this.menubtnOpen.Text = "Open";
            this.menubtnOpen.Click += new System.EventHandler(this.menubtnOpen_Click);
            // 
            // menubtnSave
            // 
            this.menubtnSave.Enabled = false;
            this.menubtnSave.Name = "menubtnSave";
            this.menubtnSave.Size = new System.Drawing.Size(270, 34);
            this.menubtnSave.Text = "Save";
            this.menubtnSave.Click += new System.EventHandler(this.menubtnSave_Click);
            // 
            // menubtnSaveAs
            // 
            this.menubtnSaveAs.Enabled = false;
            this.menubtnSaveAs.Name = "menubtnSaveAs";
            this.menubtnSaveAs.Size = new System.Drawing.Size(270, 34);
            this.menubtnSaveAs.Text = "Save As";
            this.menubtnSaveAs.Click += new System.EventHandler(this.menubtnSaveAs_Click);
            // 
            // menubtnEdit
            // 
            this.menubtnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnToRed,
            this.menubtnToGreen,
            this.menubtnToBlue,
            this.menubtnToGray,
            this.menubtnNegative,
            this.menubtnLaminate,
            this.menubtnDarken});
            this.menubtnEdit.Enabled = false;
            this.menubtnEdit.Name = "menubtnEdit";
            this.menubtnEdit.Size = new System.Drawing.Size(58, 29);
            this.menubtnEdit.Text = "Edit";
            // 
            // menubtnToRed
            // 
            this.menubtnToRed.Name = "menubtnToRed";
            this.menubtnToRed.Size = new System.Drawing.Size(185, 34);
            this.menubtnToRed.Text = "To Red";
            this.menubtnToRed.Click += new System.EventHandler(this.menubtnToRed_Click);
            // 
            // menubtnToGreen
            // 
            this.menubtnToGreen.Name = "menubtnToGreen";
            this.menubtnToGreen.Size = new System.Drawing.Size(185, 34);
            this.menubtnToGreen.Text = "To Green";
            this.menubtnToGreen.Click += new System.EventHandler(this.menubtnToGreen_Click);
            // 
            // menubtnToBlue
            // 
            this.menubtnToBlue.Name = "menubtnToBlue";
            this.menubtnToBlue.Size = new System.Drawing.Size(185, 34);
            this.menubtnToBlue.Text = "To Blue";
            this.menubtnToBlue.Click += new System.EventHandler(this.menubtnToBlue_Click);
            // 
            // menubtnToGray
            // 
            this.menubtnToGray.Name = "menubtnToGray";
            this.menubtnToGray.Size = new System.Drawing.Size(185, 34);
            this.menubtnToGray.Text = "To Gray";
            this.menubtnToGray.Click += new System.EventHandler(this.menubtnToGray_Click);
            // 
            // menubtnNegative
            // 
            this.menubtnNegative.Name = "menubtnNegative";
            this.menubtnNegative.Size = new System.Drawing.Size(185, 34);
            this.menubtnNegative.Text = "Negative";
            this.menubtnNegative.Click += new System.EventHandler(this.menubtnNegative_Click);
            // 
            // menubtnLaminate
            // 
            this.menubtnLaminate.Name = "menubtnLaminate";
            this.menubtnLaminate.Size = new System.Drawing.Size(185, 34);
            this.menubtnLaminate.Text = "Laminate";
            this.menubtnLaminate.Click += new System.EventHandler(this.menubtnLaminate_Click);
            // 
            // menubtnDarken
            // 
            this.menubtnDarken.Name = "menubtnDarken";
            this.menubtnDarken.Size = new System.Drawing.Size(185, 34);
            this.menubtnDarken.Text = "Darken";
            this.menubtnDarken.Click += new System.EventHandler(this.menubtnDarken_Click);
            // 
            // menubtnAddColor
            // 
            this.menubtnAddColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnNormal,
            this.menubtnWeighted,
            this.menubtn4Colors});
            this.menubtnAddColor.Enabled = false;
            this.menubtnAddColor.Name = "menubtnAddColor";
            this.menubtnAddColor.Size = new System.Drawing.Size(110, 29);
            this.menubtnAddColor.Text = "Add Color";
            this.menubtnAddColor.Click += new System.EventHandler(this.menubtnAddColor_Click);
            // 
            // menubtnNormal
            // 
            this.menubtnNormal.Name = "menubtnNormal";
            this.menubtnNormal.Size = new System.Drawing.Size(190, 34);
            this.menubtnNormal.Text = "Normal";
            this.menubtnNormal.Click += new System.EventHandler(this.menubtnNormal_Click);
            // 
            // menubtnWeighted
            // 
            this.menubtnWeighted.Name = "menubtnWeighted";
            this.menubtnWeighted.Size = new System.Drawing.Size(190, 34);
            this.menubtnWeighted.Text = "Weighted";
            this.menubtnWeighted.Click += new System.EventHandler(this.menubtnWeighted_Click);
            // 
            // menubtn4Colors
            // 
            this.menubtn4Colors.Name = "menubtn4Colors";
            this.menubtn4Colors.Size = new System.Drawing.Size(190, 34);
            this.menubtn4Colors.Text = "4 Colors";
            this.menubtn4Colors.Click += new System.EventHandler(this.menubtn4Colors_Click);
            // 
            // menubtnGraphics
            // 
            this.menubtnGraphics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubtnAddText,
            this.menubtnAddImage,
            this.menubtnRotate});
            this.menubtnGraphics.Enabled = false;
            this.menubtnGraphics.Name = "menubtnGraphics";
            this.menubtnGraphics.Size = new System.Drawing.Size(96, 29);
            this.menubtnGraphics.Text = "Graphics";
            // 
            // menubtnAddText
            // 
            this.menubtnAddText.Name = "menubtnAddText";
            this.menubtnAddText.Size = new System.Drawing.Size(203, 34);
            this.menubtnAddText.Text = "Add Text";
            this.menubtnAddText.Click += new System.EventHandler(this.menubtnAddText_Click);
            // 
            // menubtnAddImage
            // 
            this.menubtnAddImage.ForeColor = System.Drawing.Color.Black;
            this.menubtnAddImage.Name = "menubtnAddImage";
            this.menubtnAddImage.Size = new System.Drawing.Size(203, 34);
            this.menubtnAddImage.Text = "Add Image";
            this.menubtnAddImage.Click += new System.EventHandler(this.menubtnAddImage_Click);
            // 
            // menubtnRotate
            // 
            this.menubtnRotate.Name = "menubtnRotate";
            this.menubtnRotate.Size = new System.Drawing.Size(203, 34);
            this.menubtnRotate.Text = "Rotate";
            this.menubtnRotate.Click += new System.EventHandler(this.menubtnRotate_Click);
            // 
            // menubtnUndo
            // 
            this.menubtnUndo.Enabled = false;
            this.menubtnUndo.Name = "menubtnUndo";
            this.menubtnUndo.Size = new System.Drawing.Size(72, 29);
            this.menubtnUndo.Text = "Undo";
            this.menubtnUndo.Click += new System.EventHandler(this.menubtnUndo_Click);
            // 
            // menubtnRedo
            // 
            this.menubtnRedo.Enabled = false;
            this.menubtnRedo.Name = "menubtnRedo";
            this.menubtnRedo.Size = new System.Drawing.Size(69, 29);
            this.menubtnRedo.Text = "Redo";
            this.menubtnRedo.Click += new System.EventHandler(this.menubtnRedo_Click);
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusImgInfo});
            this.statusMain.Location = new System.Drawing.Point(0, 490);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(978, 22);
            this.statusMain.TabIndex = 1;
            this.statusMain.Text = "statusStrip1";
            // 
            // statusImgInfo
            // 
            this.statusImgInfo.Name = "statusImgInfo";
            this.statusImgInfo.Size = new System.Drawing.Size(0, 15);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.pictureMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 33);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(978, 457);
            this.panelMain.TabIndex = 2;
            // 
            // pictureMain
            // 
            this.pictureMain.Location = new System.Drawing.Point(3, 50);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(120, 50);
            this.pictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureMain.TabIndex = 0;
            this.pictureMain.TabStop = false;
            this.pictureMain.Click += new System.EventHandler(this.pictureMain_Click);
            this.pictureMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureMain_MouseDown);
            this.pictureMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureMain_MouseMove);
            this.pictureMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureMain_MouseUp);
            // 
            // checkBoxRectangle
            // 
            this.checkBoxRectangle.AutoSize = true;
            this.checkBoxRectangle.Location = new System.Drawing.Point(1119, 3);
            this.checkBoxRectangle.Name = "checkBoxRectangle";
            this.checkBoxRectangle.Size = new System.Drawing.Size(108, 24);
            this.checkBoxRectangle.TabIndex = 3;
            this.checkBoxRectangle.Text = "Rectangle";
            this.checkBoxRectangle.UseVisualStyleBackColor = true;
            this.checkBoxRectangle.CheckedChanged += new System.EventHandler(this.checkBoxRectangle_CheckedChanged);
            // 
            // toolMain
            // 
            this.toolMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnOpen,
            this.toolbtnSave,
            this.toolbtnUndo,
            this.toolbtnRedo});
            this.toolMain.Location = new System.Drawing.Point(0, 33);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(978, 33);
            this.toolMain.TabIndex = 4;
            this.toolMain.Text = "toolStrip1";
            // 
            // toolbtnOpen
            // 
            this.toolbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnOpen.Image")));
            this.toolbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnOpen.Name = "toolbtnOpen";
            this.toolbtnOpen.Size = new System.Drawing.Size(34, 28);
            this.toolbtnOpen.Text = "Open";
            this.toolbtnOpen.Click += new System.EventHandler(this.toolbtnOpen_Click);
            // 
            // toolbtnSave
            // 
            this.toolbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnSave.Enabled = false;
            this.toolbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnSave.Image")));
            this.toolbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnSave.Name = "toolbtnSave";
            this.toolbtnSave.Size = new System.Drawing.Size(34, 28);
            this.toolbtnSave.Text = "Save";
            this.toolbtnSave.Click += new System.EventHandler(this.toolbtnSave_Click);
            // 
            // toolbtnUndo
            // 
            this.toolbtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnUndo.Enabled = false;
            this.toolbtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnUndo.Image")));
            this.toolbtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnUndo.Name = "toolbtnUndo";
            this.toolbtnUndo.Size = new System.Drawing.Size(34, 28);
            this.toolbtnUndo.Text = "Undo";
            this.toolbtnUndo.Click += new System.EventHandler(this.toolbtnUndo_Click);
            // 
            // toolbtnRedo
            // 
            this.toolbtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnRedo.Enabled = false;
            this.toolbtnRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnRedo.Image")));
            this.toolbtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnRedo.Name = "toolbtnRedo";
            this.toolbtnRedo.Size = new System.Drawing.Size(34, 28);
            this.toolbtnRedo.Text = "Redo";
            this.toolbtnRedo.Click += new System.EventHandler(this.toolbtnRedo_Click);
            // 
            // formImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 512);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.checkBoxRectangle);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "formImage";
            this.Text = "Image";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menubtnFile;
        private System.Windows.Forms.ToolStripMenuItem menubtnOpen;
        private System.Windows.Forms.ToolStripMenuItem menubtnEdit;
        private System.Windows.Forms.ToolStripMenuItem menubtnToRed;
        private System.Windows.Forms.ToolStripMenuItem menubtnToGreen;
        private System.Windows.Forms.ToolStripMenuItem menubtnToBlue;
        private System.Windows.Forms.ToolStripMenuItem menubtnToGray;
        private System.Windows.Forms.ToolStripMenuItem menubtnNegative;
        private System.Windows.Forms.ToolStripMenuItem menubtnLaminate;
        private System.Windows.Forms.ToolStripMenuItem menubtnDarken;
        private System.Windows.Forms.ToolStripMenuItem menubtnUndo;
        private System.Windows.Forms.ToolStripMenuItem menubtnRedo;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel statusImgInfo;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureMain;
        private System.Windows.Forms.ToolStripMenuItem menubtnAddColor;
        private System.Windows.Forms.ToolStripMenuItem menubtnNormal;
        private System.Windows.Forms.ToolStripMenuItem menubtnWeighted;
        private System.Windows.Forms.ToolStripMenuItem menubtnGraphics;
        private System.Windows.Forms.ToolStripMenuItem menubtnAddText;
        private System.Windows.Forms.ToolStripMenuItem menubtnAddImage;
        private System.Windows.Forms.ToolStripMenuItem menubtnRotate;
        private System.Windows.Forms.ToolStripMenuItem menubtn4Colors;
        private System.Windows.Forms.CheckBox checkBoxRectangle;
        private System.Windows.Forms.ToolStripMenuItem menubtnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menubtnSave;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton toolbtnOpen;
        private System.Windows.Forms.ToolStripButton toolbtnSave;
        private System.Windows.Forms.ToolStripButton toolbtnUndo;
        private System.Windows.Forms.ToolStripButton toolbtnRedo;
    }
}

