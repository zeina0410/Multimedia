using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject {
    public partial class formImage : Form {
        Bitmap b;
        Stack<Bitmap> undo = new Stack<Bitmap>();
        Stack<Bitmap> redo = new Stack<Bitmap>();
        Byte[] bitmapBytes;

        void addToUndo() {
            menubtnUndo.Enabled = true;
            toolbtnUndo.Enabled = true;
            undo.Push(new Bitmap(b));
        }

        void addToRedo() {
            menubtnRedo.Enabled = true;
            toolbtnRedo.Enabled = true;
            redo.Push(new Bitmap(b));
        }

        void action() {
            addToUndo();
            redo.Clear();
            menubtnRedo.Enabled = false;
            toolbtnRedo.Enabled = false;
        }

        void lockPasteUnlock() {
            var imageLock = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, b.PixelFormat);
            Marshal.Copy(imageLock.Scan0, bitmapBytes, 0, bitmapBytes.Length);
            b.UnlockBits(imageLock);
        }

        void lockCopyUnlock() {
            var imageLock = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, b.PixelFormat);
            Marshal.Copy(bitmapBytes, 0, imageLock.Scan0, bitmapBytes.Length);
            b.UnlockBits(imageLock);
        }

        public formImage() {
            InitializeComponent();
        }

        String fname;
        private void menubtnOpen_Click(object sender, EventArgs e) {
            var p = new OpenFileDialog();
            p.Filter = "Image File |*jpg";
            if (p.ShowDialog() == DialogResult.Cancel)
                return;
            try {
                b = new Bitmap(p.FileName);
                b = new Bitmap(b);
                fname = p.FileName;

                bitmapBytes = new Byte[b.Width * b.Height * 4];
                lockPasteUnlock();

                pictureMain.Image = b;
                statusImgInfo.Text = b.Width.ToString() + " x " + b.Height + "   |Pixel Format: " + b.PixelFormat + "   |Ver Res: " + b.VerticalResolution + "   |Hor Res: " + b.HorizontalResolution;
                
                menubtnEdit.Enabled = true;
                menubtnAddColor.Enabled = true;
                menubtnGraphics.Enabled = true;
                menubtnSave.Enabled = true;
                menubtnSaveAs.Enabled = true;
                toolbtnSave.Enabled = true;
            }
            catch {
                MessageBox.Show("File Error");
            }
        }

        private void menubtnSaveAs_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                try {
                    var f = new SaveFileDialog();
                    f.Filter = "Image File |*jpg";
                    f.Title = "Save Image";
                    f.FileName = ".jpg";
                    if (f.ShowDialog() == DialogResult.Cancel)
                        return;
                    b.Save(f.FileName);
                }
                catch {
                    MessageBox.Show("File Error");
                }
            }
        }

        private void menubtnSave_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                try {
                    lockCopyUnlock();
                    b.Save(fname);
                }
                catch {
                    MessageBox.Show("File Error");
                }
            }
        }

        private void menubtnToRed_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                action();
                for (int i=0; i< bitmapBytes.Length; i += 4) {
                    bitmapBytes[i + 0] = 0; //Blue
                    bitmapBytes[i + 1] = 0; //Green
                }
                lockCopyUnlock();
                pictureMain.Image = b;
            }
        }

        private void menubtnToGreen_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                action();
                for (int i = 0; i < bitmapBytes.Length; i += 4) {
                    bitmapBytes[i + 0] = 0; //Blue
                    bitmapBytes[i + 2] = 0; //Red
                }
                lockCopyUnlock();
                pictureMain.Image = b;
            }
        }

        private void menubtnToBlue_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                action();
                for (int i = 0; i < bitmapBytes.Length; i += 4) {
                    bitmapBytes[i + 1] = 0; //Green
                    bitmapBytes[i + 2] = 0; //Red
                }
                lockCopyUnlock();
                pictureMain.Image = b;
            }
        }

        private void menubtnToGray_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                action();
                for (int i = 0; i < bitmapBytes.Length; i += 4) {
                    double Y = (0.3 * bitmapBytes[i + 2]) + (0.6 * bitmapBytes[i + 1]) + (0.1 * bitmapBytes[i + 0]);
                    bitmapBytes[i + 0] = (byte)Y; //Blue
                    bitmapBytes[i + 1] = (byte)Y; //Green
                    bitmapBytes[i + 2] = (byte)Y; //Red
                }
                lockCopyUnlock();
                pictureMain.Image = b;
            }
        }

        private void menubtnNegative_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                action();
                for (int i = 0; i < bitmapBytes.Length; i += 4) {
                    double Y = (0.3 * bitmapBytes[i + 2]) + (0.6 * bitmapBytes[i + 1]) + (0.1 * bitmapBytes[i + 0]);
                    bitmapBytes[i + 0] = (byte)(255 - bitmapBytes[i + 0]); //Blue
                    bitmapBytes[i + 1] = (byte)(255 - bitmapBytes[i + 1]); //Green
                    bitmapBytes[i + 2] = (byte)(255 - bitmapBytes[i + 2]); //Red
                }
                lockCopyUnlock();
                pictureMain.Image = b;
            }
        }

        private void menubtnLaminate_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                action();
                for (int i = 0; i < bitmapBytes.Length; i += 4) {
                    double Y = (0.3 * bitmapBytes[i + 2]) + (0.6 * bitmapBytes[i + 1]) + (0.1 * bitmapBytes[i + 0]);
                    bitmapBytes[i + 0] = (byte)(bitmapBytes[i + 0] + (255 - bitmapBytes[i + 0]) * 0.3); //Blue
                    bitmapBytes[i + 1] = (byte)(bitmapBytes[i + 1] + (255 - bitmapBytes[i + 1]) * 0.3); //Green
                    bitmapBytes[i + 2] = (byte)(bitmapBytes[i + 2] + (255 - bitmapBytes[i + 2]) * 0.3); //Red
                }
                lockCopyUnlock();
                pictureMain.Image = b;
            }
        }

        private void menubtnDarken_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                action();
                for (int i = 0; i < bitmapBytes.Length; i += 4) {
                    double Y = (0.3 * bitmapBytes[i + 2]) + (0.6 * bitmapBytes[i + 1]) + (0.1 * bitmapBytes[i + 0]);
                    bitmapBytes[i + 0] = (byte)(bitmapBytes[i + 0] * 0.8); //Blue
                    bitmapBytes[i + 1] = (byte)(bitmapBytes[i + 1] * 0.8); //Green
                    bitmapBytes[i + 2] = (byte)(bitmapBytes[i + 2] * 0.8); //Red
                }
                lockCopyUnlock();
                pictureMain.Image = b;
            }
        }

        private void menubtnUndo_Click(object sender, EventArgs e) {
            try {
                if (undo.Count() != 0)
                    addToRedo();
                b = undo.Pop();
                lockPasteUnlock();
                pictureMain.Image = b;
                if (undo.Count() == 0) {
                    menubtnUndo.Enabled = false;
                    toolbtnUndo.Enabled = false;
                }
            }
            catch {
                return;
            }
        }

        private void menubtnRedo_Click(object sender, EventArgs e) {
            try {
                if (redo.Count() != 0)
                    addToUndo();
                b = redo.Pop();
                lockPasteUnlock();
                pictureMain.Image = b;
                if (redo.Count() == 0) {
                    menubtnRedo.Enabled = false;
                    toolbtnRedo.Enabled = false;
                }
            }
            catch {
                return;
            }
        }

        private void menubtnNormal_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                ColorDialog c = new ColorDialog();
                if (c.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                action();
                for (int i = 0; i < bitmapBytes.Length; i += 4) {
                    bitmapBytes[i + 0] = (byte)((bitmapBytes[i + 0] + c.Color.B) / 2); //Blue
                    bitmapBytes[i + 1] = (byte)((bitmapBytes[i + 1] + c.Color.G) / 2); //Green
                    bitmapBytes[i + 2] = (byte)((bitmapBytes[i + 2] + c.Color.R) / 2); //Red
                }
                lockCopyUnlock();
                pictureMain.Image = b;
            }
        }

        private void menubtnWeighted_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                ColorDialog c = new ColorDialog();
                if (c.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                try {
                    String input = Interaction.InputBox("Enter weight value:", "Enter weight value:", "0.", 450, 200);
                    action();

                    float r = float.Parse(input);
                    for (int i = 0; i < bitmapBytes.Length; i += 4) {
                        bitmapBytes[i + 0] = (byte)(bitmapBytes[i + 0] * (1 - r) + c.Color.B * r); //Blue
                        bitmapBytes[i + 1] = (byte)(bitmapBytes[i + 1] * (1 - r) + c.Color.G * r); //Green
                        bitmapBytes[i + 2] = (byte)(bitmapBytes[i + 2] * (1 - r) + c.Color.R * r); //Red
                    }
                    lockCopyUnlock();
                    pictureMain.Image = b;
                }
                catch {
                    return;
                }
            }
        }

        private void menubtnAddText_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                try {
                    String input = Interaction.InputBox("Enter text to add:", "Enter text to add:", "", 90, 150);
                    action();

                    using (Graphics g = Graphics.FromImage(b)) {
                        g.DrawString(
                            input,
                            DefaultFont,
                            new SolidBrush(Color.Red),
                            0, 0
                            );
                    }
                    pictureMain.Image = b;
                }
                catch { 
                    return;
                }
            }
        }

        private void menubtnAddImage_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                try {
                    var p1 = new OpenFileDialog();
                    p1.Filter = "Image File |*jpg";
                    if (p1.ShowDialog() == DialogResult.Cancel)
                        return;
                    action();

                    using (Graphics g = Graphics.FromImage(b)) {
                        Bitmap l = new Bitmap(p1.FileName);
                        g.DrawImage(
                            l,
                            150,
                            50
                            );
                    }
                    pictureMain.Image = b;
                }
                catch {
                    return;
                }
            }
        }

        private void menubtnRotate_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                try {
                    String input = Interaction.InputBox("Enter rotation radius:", "Enter rotation radius:", "", 90, 150);
                    action();

                    int r = int.Parse(input);
                    Bitmap temp = new Bitmap(b);
                    using (Graphics g = Graphics.FromImage(b)) {
                        g.Clear(Color.Transparent);
                        g.TranslateTransform(
                            temp.Width / 2,
                            temp.Height / 2
                            );

                        while (r > 360)
                            r = r - 360;
                        while (r < 0)
                            r = 360 + r;

                        if (r > 0 && r < 90) {
                            double rad = (r * Math.PI) / 180;
                            g.ScaleTransform(
                                temp.Width / (float)((temp.Width * Math.Cos(rad)) + (temp.Height * Math.Sin(rad))),
                                temp.Height / (float)((temp.Width * Math.Sin(rad)) + (temp.Height * Math.Cos(rad)))
                                );
                        }
                        if (r == 90) {
                            g.ScaleTransform(
                               (float)0.6, (float)0.6
                               );
                        }
                        if (r > 90 && r < 180) {
                            double rad = (((r - 90) * Math.PI) / 180);
                            g.ScaleTransform(
                                temp.Width / (float)((temp.Height * Math.Cos(rad)) + (temp.Width * Math.Sin(rad))),
                                temp.Height / (float)((temp.Height * Math.Sin(rad)) + (temp.Width * Math.Cos(rad)))
                                );
                        }
                        if (r > 180 && r < 270) {
                            double rad = (r * Math.PI) / 180;
                            g.ScaleTransform(
                                -temp.Width / (float)((temp.Width * Math.Cos(rad)) + (temp.Height * Math.Sin(rad))),
                                -temp.Height / (float)((temp.Width * Math.Sin(rad)) + (temp.Height * Math.Cos(rad)))
                                );
                        }
                        if (r == 270) {
                            g.ScaleTransform(
                               (float)0.6, (float)0.6
                               );
                        }
                        if (r > 270 && r < 360) {
                            double rad = (((r - 90) * Math.PI) / 180);
                            g.ScaleTransform(
                                -temp.Width / (float)((temp.Height * Math.Cos(rad)) + (temp.Width * Math.Sin(rad))),
                                -temp.Height / (float)((temp.Height * Math.Sin(rad)) + (temp.Width * Math.Cos(rad)))
                                );
                        }

                        g.RotateTransform(r);
                        g.DrawImage(
                            temp,
                            -temp.Width / 2,
                            -temp.Height / 2
                            );
                    }
                    pictureMain.Image = b;
                }
                catch {
                    return;
                }
            }
        }

        int x, y;
        private void pictureMain_MouseDown(object sender, MouseEventArgs e) {
            if (checkBoxRectangle.Checked == true) {
                x = e.X;
                y = e.Y;
            }
        }

        private void pictureMain_MouseMove(object sender, MouseEventArgs e) {
            if (b == null)
                return;
            else {
                if (checkBoxRectangle.Checked == true) {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                        Bitmap temp = new Bitmap(b);
                        using (Graphics g = Graphics.FromImage(temp)) {
                            g.DrawRectangle(new Pen(Color.Red),
                                Math.Min(e.X, x),
                                Math.Min(e.Y, y),
                                Math.Abs(e.X - x),
                                Math.Abs(e.Y - y)
                                );
                        }
                        pictureMain.Image = temp;
                    }
                }
            }
        }

        private void pictureMain_MouseUp(object sender, MouseEventArgs e) {
            if (b == null)
                return;
            else {
                if (checkBoxRectangle.Checked == true) {
                    action();
                    using (Graphics g = Graphics.FromImage(b)) {
                        g.FillRectangle(new SolidBrush(Color.Red),
                        Math.Min(e.X, x),
                        Math.Min(e.Y, y),
                        Math.Abs(e.X - x),
                        Math.Abs(e.Y - y)
                        ); ;
                    }
                    pictureMain.Image = b;
                }
            }
        }

        private void menubtn4Colors_Click(object sender, EventArgs e) {
            if (b == null)
                return;
            else {
                action();

                for (int i = 0; i < bitmapBytes.Length / 2; i += b.Width * 4) {
                    for (int j = 0; j < b.Width * 2; j += 4) {
                        bitmapBytes[i + j + 0] = 0; //Blue
                        bitmapBytes[i + j + 1] = 0; //Green
                    }
                }

                for (int i = 0; i < bitmapBytes.Length / 2; i += b.Width * 4) {
                    for (int j = b.Width * 2; j < b.Width * 4; j += 4) {
                        bitmapBytes[i + j + 0] = 0; //Blue
                        bitmapBytes[i + j + 2] = 0; //Red
                    }
                }

                for (int i = (bitmapBytes.Length / 2) + b.Width * 2; i < bitmapBytes.Length; i += b.Width * 4) {
                    for (int j = 0; j < b.Width * 2; j += 4) {
                        bitmapBytes[i + j + 1] = 0; //Green
                        bitmapBytes[i + j + 2] = 0; //Red
                    }
                }

                for (int i = bitmapBytes.Length / 2; i < bitmapBytes.Length; i += b.Width * 4) {
                    for (int j = 0; j < b.Width * 2; j += 4) {
                        double Y = (0.3 * bitmapBytes[i + j + 2]) + (0.6 * bitmapBytes[i + j + 1]) + (0.1 * bitmapBytes[i + j + 0]);
                        bitmapBytes[i + j + 0] = (byte)Y; //Blue
                        bitmapBytes[i + j + 1] = (byte)Y; //Green
                        bitmapBytes[i + j + 2] = (byte)Y; //Red
                    }
                }

                lockCopyUnlock();
                pictureMain.Image = b;
            }
        }

        private void toolbtnOpen_Click(object sender, EventArgs e) {
            menubtnOpen_Click(sender, e);
        }

        private void toolbtnSave_Click(object sender, EventArgs e) {
            menubtnSave_Click(sender, e);
        }

        private void toolbtnUndo_Click(object sender, EventArgs e) {
            menubtnUndo_Click(sender, e);
        }

        private void toolbtnRedo_Click(object sender, EventArgs e) {
            menubtnRedo_Click(sender, e);
        }

        private void pictureMain_Click(object sender, EventArgs e)
        {

        }
        private void checkBoxRectangle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menubtnFile_Click(object sender, EventArgs e)
        {

        }

        private void menubtnAddColor_Click(object sender, EventArgs e)
        {
        }
    }
}
