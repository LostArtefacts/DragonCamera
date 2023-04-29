using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TRLevelReader;
using TRLevelReader.Model;

namespace DragonCamera
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                lvlTextBox.Text = openFileDialog.FileName;
            }
        }

        private void LvlTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = lvlTextBox.Text.Trim().Length > 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                savedLabel.Visible = false;

                string path = lvlTextBox.Text.Trim();
                if (!File.Exists(path))
                {
                    throw new IOException(path + " does not exist.");
                }

                TR2Level level = new TR2LevelReader().ReadLevel(path);
                level.CinematicFrames = JsonConvert.DeserializeObject<TRCinematicFrame[]>(File.ReadAllText("frames.json"));
                level.NumCinematicFrames = (ushort)level.CinematicFrames.Length;
                new TR2LevelWriter().WriteLevelToFile(level, path);

                savedLabel.Visible = true;
                new Thread(HideLabel).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideLabel()
        {
            Thread.Sleep(5000);
            Invoke(new Action(() => savedLabel.Visible = false));
        }
    }
}
