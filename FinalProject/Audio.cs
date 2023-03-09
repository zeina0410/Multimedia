using Microsoft.VisualBasic;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject {
    public partial class formAudio : Form {
        WaveStream reader;
        WaveOut waveOut = new WaveOut();
        short[] data;

        private short[] readData() {
            return readData(reader);
        }

        private short[] readData(WaveStream reader) {
            reader.Seek(0, System.IO.SeekOrigin.Begin);
            byte[] bytes = new byte[reader.Length];
            reader.Read(bytes, 0, bytes.Length);

            short[] data = new short[bytes.Length / 2];
            for (int i = 0; i < data.Length; i++)
                data[i] = (short)(bytes[i * 2] + bytes[i * 2 + 1] * 256);
            return data;
        }

        private void saveData(short[] data) {
            byte[] bytes = new byte[data.Length * 2];
            for (int i = 0; i < data.Length; i++) {
                bytes[i * 2]= (byte)(data[i] % 256);
                bytes[i * 2 + 1]= (byte)(data[i] / 256);
            }
            RawSourceWaveStream waveStream = new RawSourceWaveStream(bytes,0 ,bytes.Length, reader.WaveFormat);
            reader = waveStream;
        }

        void viewProp(WaveStream reader) {
            viewProperties.Items.Clear();
            viewProperties.Items.Add(
                new ListViewItem(new string[] { "Sample Rate:", reader.WaveFormat.SampleRate.ToString() })
                );
            viewProperties.Items.Add(
                new ListViewItem(new string[] { "Channels:", reader.WaveFormat.Channels.ToString() })
                );
            viewProperties.Items.Add(
                new ListViewItem(new string[] { "Bits Per Sample:", reader.WaveFormat.BitsPerSample.ToString() })
                );
            viewProperties.Items.Add(
                new ListViewItem(new string[] { "Total Time:", reader.TotalTime.ToString() })
                );
            viewProperties.Items.Add(
                new ListViewItem(new string[] { "Encoding:", reader.WaveFormat.Encoding.ToString() })
                );
            viewProperties.Items.Add(
                new ListViewItem(new string[] { "Average Bytes Per Second:", reader.WaveFormat.AverageBytesPerSecond.ToString() })
                );
        }

        public formAudio() {
            InitializeComponent();
        }

        String fname;
        private void menubtnOpen_Click(object sender, EventArgs e) {
            try {
                var o = new OpenFileDialog();
                o.Filter = "MP3 Files|*.mp3";
                o.Title = "Select audio file";
                if (o.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                fname = o.FileName;

                Mp3FileReader reader = new Mp3FileReader(o.FileName);
                this.reader = reader;

                viewProp(reader);

                byte[] b = new byte[reader.Length];
                data = new short[b.Length / 2];
                reader.Read(b, 0, b.Length);

                for (int i = 0; i < data.Length; i++) {
                    data[i] = (short)(b[i * 2] + b[i * 2 + 1] * 256);
                }

                menubtnControl.Enabled = true;
                menubtnEdit.Enabled = true;
                toolbtnPlay.Enabled = true;
                toolbtnVolumeDown.Enabled = true;
                menubtnMerge.Enabled = true;
                menubtnSave.Enabled = true;
                menubtnSaveAs.Enabled = true;
            }
            catch {
                return;
            }
        }

        private void menubtnSave_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                try {
                    reader.Seek(0, System.IO.SeekOrigin.Begin);
                    byte[] bytes = new byte[reader.Length];
                    reader.Read(bytes, 0, bytes.Length);
                    WaveFileWriter w = new WaveFileWriter(fname, reader.WaveFormat);
                    w.Write(bytes, 0, bytes.Length);
                    w.Close();
                    w.Dispose();
                }
                catch {
                    MessageBox.Show("File Error");
                }
            }
        }

        private void menubtnSaveAs_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                try {
                    reader.Seek(0, System.IO.SeekOrigin.Begin);
                    byte[] bytes = new byte[reader.Length];
                    reader.Read(bytes, 0, bytes.Length);
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "MP3 Files|*.mp3";
                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;
                    WaveFileWriter w = new WaveFileWriter(dialog.FileName, reader.WaveFormat);
                    w.Write(bytes, 0, bytes.Length);
                    w.Close();
                    w.Dispose();
                }
                catch {
                    MessageBox.Show("File Error");
                }
            }
        }

        private void menubtnPlay_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                menubtnEdit.Enabled = false;
                menubtnMerge.Enabled = false;
                menubtnSave.Enabled = false;
                menubtnSaveAs.Enabled = false;
                waveOut.Init(reader);
                reader.Seek(0, System.IO.SeekOrigin.Begin);
                waveOut.Play();
                timerAudio.Enabled = true;
                menubtnPause.Enabled = true;
                menubtnPlay.Enabled = false;
                menubtnResume.Enabled = false;
                toolbtnPause.Enabled = true;
                toolbtnPlay.Enabled = false;
                toolbtnResume.Enabled = false;
            }
        }

        int vcount = 0;
        private void menubtnPause_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                menubtnEdit.Enabled = true;
                menubtnMerge.Enabled = true;
                menubtnSave.Enabled = true;
                menubtnSaveAs.Enabled = true;
                if (vcount == 0) {
                    menubtnVolumeDown.Enabled = true;
                    toolbtnVolumeDown.Enabled = true;
                }
                else {
                    menubtnVolumeDown.Enabled = true;
                    menubtnVolumeUp.Enabled = true;
                    toolbtnVolumeDown.Enabled = true;
                    toolbtnVolumeUp.Enabled = true;
                }
                if (waveOut.PlaybackState == PlaybackState.Playing) {
                    waveOut.Stop();
                    timerAudio.Enabled = false;
                    menubtnPause.Enabled = false;
                    menubtnPlay.Enabled = true;
                    menubtnResume.Enabled = true;
                    toolbtnPause.Enabled = false;
                    toolbtnPlay.Enabled = true;
                    toolbtnResume.Enabled = true;
                }
            }
        }

         private void menubtnResume_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                menubtnEdit.Enabled = false;
                menubtnMerge.Enabled = false;
                menubtnSave.Enabled = false;
                menubtnSaveAs.Enabled = false;
                waveOut.Init(reader);
                waveOut.Play();
                timerAudio.Enabled = true;
                menubtnPause.Enabled = true;
                menubtnPlay.Enabled = false;
                menubtnResume.Enabled = false;
                toolbtnPause.Enabled = true;
                toolbtnPlay.Enabled = false;
                toolbtnResume.Enabled = false;
            }
        }

        private void timerAudio_Tick(object sender, EventArgs e) {
            scrollPlayPosition.Value = (int)(reader.Position * scrollPlayPosition.Maximum / reader.Length);
            if (waveOut.PlaybackState == PlaybackState.Playing) {
                menubtnVolumeDown.Enabled = false;
                menubtnVolumeUp.Enabled = false;
                toolbtnVolumeDown.Enabled = false;
                toolbtnVolumeUp.Enabled = false;
            }
            if (waveOut.PlaybackState == PlaybackState.Stopped) {
                menubtnPause.Enabled = false;
                menubtnPlay.Enabled = true;
                menubtnResume.Enabled = true;
                toolbtnPause.Enabled = false;
                toolbtnPlay.Enabled = true;
                toolbtnResume.Enabled = true;
            }
        }

        private void scrollPlayPosition_Scroll(object sender, ScrollEventArgs e) {
            if (reader == null)
                return;
            else {
                reader.Position = scrollPlayPosition.Value * reader.Length / scrollPlayPosition.Maximum;
            }
        }

        private void menubtnF2_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                try {
                    short[] data = readData();
                    short[] newData = new short[data.Length / 2];
                    for (int i = 0; i < newData.Length; i += 2) {
                        newData[i] = data[i * 2];
                        newData[i + 1] = data[i * 2 + 1];
                    }
                    saveData(newData);
                    viewProp(reader);
                }
                catch {
                    return;
                }
            }
        }

        private void menubtnF15_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                try {
                    short[] data = readData();
                    short[] newData = new short[(int)(data.Length / 1.5)];
                    for (int i = 0; i < newData.Length; i += 3) {
                        newData[i] = data[(int)(i * 1.5)];
                        newData[i + 1] = data[(int)(i * 1.5 + 1)];
                    }
                    saveData(newData);
                    viewProp(reader);
                }
                catch {
                    return;
                }
            }
        }

        private void menubtnS2_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                try {
                    short[] data = readData();
                    short[] newData = new short[data.Length * 2];
                    for (int i = 0; i < data.Length; i += 2) {
                        newData[i] = data[i / 2];
                        newData[i + 1] = data[i / 2 + 1];
                    }
                    saveData(newData);
                    viewProp(reader);
                }
                catch {
                    return;
                }
            }
        }

        private void menubtnS15_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                try {
                    short[] data = readData();
                    short[] newData = new short[(int)(data.Length * 1.5)];
                    for (int i = 0; i < data.Length; i += 3) {
                        newData[i] = data[(int)(i / 1.5)];
                        newData[i + 1] = data[(int)(i / 1.5 + 1)];
                    }
                    saveData(newData);
                    viewProp(reader);
                }
                catch {
                    return;
                }
            }
        }

        private void menubtnReverse_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                try {
                    short[] data = readData();
                    short[] newData = data.Reverse().ToArray();
                    saveData(newData);
                }
                catch {
                    return;
                }
            }
        }

        private void menubtnVolumeUp_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                try {
                    short[] data = readData();
                    short[] newData = new short[data.Length];
                    for (int i = 0; i < data.Length; i++) {
                        newData[i] = (short)(data[i] * 2);
                        if (data[i] > short.MaxValue)
                            newData[i] = short.MaxValue;
                        else if (data[i] < short.MinValue)
                            newData[i] = short.MinValue;
                    }
                    vcount--;
                    if (vcount == 0) {
                        menubtnVolumeUp.Enabled = false;
                        toolbtnVolumeUp.Enabled = false;
                    }
                    saveData(newData);
                }
                catch {
                    return;
                }
            }
        }

        private void menubtnVolumeDown_Click(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                try {
                    short[] data = readData();
                    short[] newData = new short[data.Length];
                    for (int i = 0; i < data.Length; i++) {
                        newData[i] = (short)(data[i] / 2);
                        if (data[i] > short.MaxValue)
                            newData[i] = short.MaxValue;
                        else if (data[i] < short.MinValue)
                            newData[i] = short.MinValue;
                    }
                    vcount++;
                    if (vcount != 0) {
                        menubtnVolumeUp.Enabled = true;
                        toolbtnVolumeUp.Enabled = true;
                    }
                    saveData(newData);
                }
                catch {
                    return;
                }
            }
        }

        private void menubtnMerge_Click_1(object sender, EventArgs e) {
            if (reader == null)
                return;
            else {
                try {
                    OpenFileDialog o = new OpenFileDialog();
                    o.Filter = "MP3 Files|*.mp3";
                    o.Title = "Select audio file";
                    if (o.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        return;

                    Mp3FileReader r = new Mp3FileReader(o.FileName);
                    if (r.WaveFormat.Channels != reader.WaveFormat.Channels) {
                        r.ToSampleProvider();
                        new MediaFoundationResampler(r, WaveFormat.CreateIeeeFloatWaveFormat(reader.WaveFormat.SampleRate, 2)).ToSampleProvider(); 
                    }
                    if (r.WaveFormat.SampleRate != reader.WaveFormat.SampleRate) {
                        r.ToSampleProvider();
                        new MediaFoundationResampler(r, WaveFormat.CreateIeeeFloatWaveFormat(44100, reader.WaveFormat.Channels)).ToSampleProvider();
                    }
                    if (r.WaveFormat.BitsPerSample != reader.WaveFormat.BitsPerSample) {
                        MessageBox.Show("Bits per sample are not equal");
                        return;
                    }

                    short[] d1 = readData();
                    short[] d2 = readData(r);

                    String input1 = Interaction.InputBox("Enter merge ratio:", "Enter merge ratio:", "", 90, 150);
                    float mRatio = float.Parse(input1);

                    String input2 = Interaction.InputBox("Enter time to start from:", "Enter time to start from:", "", 90, 150);
                    int sFrom = int.Parse(input2);
                    int MergeIndex = sFrom * r.WaveFormat.SampleRate * r.WaveFormat.Channels;

                    short[] data = new short[Math.Max(d1.Length, MergeIndex + d2.Length)];

                    for (int i = 0; i < data.Length; i++) {
                        int j = i - MergeIndex;
                        if (i < MergeIndex || j >= d2.Length)
                            data[i] = d1[i];
                        else if (i >= d1.Length)
                            data[i] = d2[j];
                        else
                            data[i] = (short)((d1[i] * (1 - mRatio)) + (d2[j] * mRatio));
                    }
                    saveData(data);
                    viewProp(reader);
                }
                catch {
                    return;
                }
            }
        }

        private void toolbtnPlay_Click(object sender, EventArgs e) {
            menubtnPlay_Click(sender, e);
        }

        private void toolbtnPause_Click(object sender, EventArgs e) {
            menubtnPause_Click(sender, e);
        }

        private void toolbtnVolumeDown_Click(object sender, EventArgs e) {
            menubtnVolumeDown_Click(sender, e);
        }

        private void toolbtnVolumeUp_Click(object sender, EventArgs e) {
            menubtnVolumeUp_Click(sender, e);
        }

        private void toolbtnResume_Click(object sender, EventArgs e) {
            menubtnResume_Click(sender, e);
        }

        private void menubtnSlower_Click(object sender, EventArgs e)
        {
        }
        private void viewProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void menubtnFaster_Click(object sender, EventArgs e)
        {
        }
    }
}
