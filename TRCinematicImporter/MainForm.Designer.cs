namespace TRCinematicImporter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.lvlTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.savedLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cinematicComboBox = new System.Windows.Forms.ComboBox();
            this.labelTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custom level";
            // 
            // lvlTextBox
            // 
            this.lvlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlTextBox.Location = new System.Drawing.Point(86, 39);
            this.lvlTextBox.Name = "lvlTextBox";
            this.lvlTextBox.Size = new System.Drawing.Size(487, 20);
            this.lvlTextBox.TabIndex = 2;
            this.lvlTextBox.TextChanged += new System.EventHandler(this.LvlTextBox_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(579, 38);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "&Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(579, 99);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "&Import";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your custom level and choose the relevant cinematic frame set to import.";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "TR Levels|*.phd;*.tr2";
            // 
            // savedLabel
            // 
            this.savedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savedLabel.AutoSize = true;
            this.savedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedLabel.ForeColor = System.Drawing.Color.Green;
            this.savedLabel.Location = new System.Drawing.Point(517, 102);
            this.savedLabel.Name = "savedLabel";
            this.savedLabel.Size = new System.Drawing.Size(48, 16);
            this.savedLabel.TabIndex = 5;
            this.savedLabel.Text = "Done!";
            this.savedLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinematic";
            // 
            // cinematicComboBox
            // 
            this.cinematicComboBox.DisplayMember = "Description";
            this.cinematicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinematicComboBox.FormattingEnabled = true;
            this.cinematicComboBox.Location = new System.Drawing.Point(86, 68);
            this.cinematicComboBox.Name = "cinematicComboBox";
            this.cinematicComboBox.Size = new System.Drawing.Size(264, 21);
            this.cinematicComboBox.TabIndex = 7;
            // 
            // labelTimer
            // 
            this.labelTimer.Interval = 5000;
            this.labelTimer.Tick += new System.EventHandler(this.LabelTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 134);
            this.Controls.Add(this.cinematicComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.savedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.lvlTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinematic Frame Importer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lvlTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label savedLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cinematicComboBox;
        private System.Windows.Forms.Timer labelTimer;
    }
}

