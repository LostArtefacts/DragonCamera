using System;
using System.IO;
using System.Windows.Forms;

namespace TRCinematicImporter
{
    public partial class MainForm : Form
    {
        private FramesetImporter _importer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _importer = new FramesetImporter();
            cinematicComboBox.Items.AddRange(_importer.Cinematics);
            cinematicComboBox.SelectedIndex = 0;
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
                Cursor = Cursors.WaitCursor;
                savedLabel.Visible = false;
                labelTimer.Stop();

                string path = lvlTextBox.Text.Trim();
                if (!File.Exists(path))
                {
                    throw new IOException(path + " does not exist.");
                }

                Frameset cinematic = cinematicComboBox.SelectedItem as Frameset;

                _importer.Import(cinematic, path);

                savedLabel.Visible = true;
                labelTimer.Enabled = true;
                labelTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LabelTimer_Tick(object sender, EventArgs e)
        {
            savedLabel.Visible = false;
            labelTimer.Stop();
        }
    }
}
