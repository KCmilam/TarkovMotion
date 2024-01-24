namespace TarkovMotion
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TarkovMonitorEXETextbox = new System.Windows.Forms.TextBox();
            this.TarkovMonitorBrowseButton = new System.Windows.Forms.Button();
            this.AITrackerBrowseButton = new System.Windows.Forms.Button();
            this.AITrackerEXETextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LaunchProgramsCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowserCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarkov Monitor EXE Path:";
            // 
            // TarkovMonitorEXETextbox
            // 
            this.TarkovMonitorEXETextbox.Location = new System.Drawing.Point(147, 60);
            this.TarkovMonitorEXETextbox.Name = "TarkovMonitorEXETextbox";
            this.TarkovMonitorEXETextbox.Size = new System.Drawing.Size(520, 20);
            this.TarkovMonitorEXETextbox.TabIndex = 1;
            // 
            // TarkovMonitorBrowseButton
            // 
            this.TarkovMonitorBrowseButton.Location = new System.Drawing.Point(673, 58);
            this.TarkovMonitorBrowseButton.Name = "TarkovMonitorBrowseButton";
            this.TarkovMonitorBrowseButton.Size = new System.Drawing.Size(53, 23);
            this.TarkovMonitorBrowseButton.TabIndex = 2;
            this.TarkovMonitorBrowseButton.Text = "...";
            this.TarkovMonitorBrowseButton.UseVisualStyleBackColor = true;
            this.TarkovMonitorBrowseButton.Click += new System.EventHandler(this.TarkovMonitorBrowseButton_Click);
            // 
            // AITrackerBrowseButton
            // 
            this.AITrackerBrowseButton.Location = new System.Drawing.Point(673, 31);
            this.AITrackerBrowseButton.Name = "AITrackerBrowseButton";
            this.AITrackerBrowseButton.Size = new System.Drawing.Size(53, 23);
            this.AITrackerBrowseButton.TabIndex = 5;
            this.AITrackerBrowseButton.Text = "...";
            this.AITrackerBrowseButton.UseVisualStyleBackColor = true;
            this.AITrackerBrowseButton.Click += new System.EventHandler(this.AITrackerBrowseButton_Click);
            // 
            // AITrackerEXETextBox
            // 
            this.AITrackerEXETextBox.Location = new System.Drawing.Point(147, 33);
            this.AITrackerEXETextBox.Name = "AITrackerEXETextBox";
            this.AITrackerEXETextBox.Size = new System.Drawing.Size(520, 20);
            this.AITrackerEXETextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AITracker EXE Path:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(651, 84);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LaunchProgramsCheckBox
            // 
            this.LaunchProgramsCheckBox.AutoSize = true;
            this.LaunchProgramsCheckBox.Location = new System.Drawing.Point(147, 10);
            this.LaunchProgramsCheckBox.Name = "LaunchProgramsCheckBox";
            this.LaunchProgramsCheckBox.Size = new System.Drawing.Size(161, 17);
            this.LaunchProgramsCheckBox.TabIndex = 7;
            this.LaunchProgramsCheckBox.Text = "Launch Programs on Startup";
            this.LaunchProgramsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Browser:";
            // 
            // BrowserCombobox
            // 
            this.BrowserCombobox.FormattingEnabled = true;
            this.BrowserCombobox.Location = new System.Drawing.Point(147, 86);
            this.BrowserCombobox.Name = "BrowserCombobox";
            this.BrowserCombobox.Size = new System.Drawing.Size(210, 21);
            this.BrowserCombobox.TabIndex = 11;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(740, 114);
            this.Controls.Add(this.BrowserCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LaunchProgramsCheckBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AITrackerBrowseButton);
            this.Controls.Add(this.AITrackerEXETextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TarkovMonitorBrowseButton);
            this.Controls.Add(this.TarkovMonitorEXETextbox);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TarkovMonitorEXETextbox;
        private System.Windows.Forms.Button TarkovMonitorBrowseButton;
        private System.Windows.Forms.Button AITrackerBrowseButton;
        private System.Windows.Forms.TextBox AITrackerEXETextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox LaunchProgramsCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BrowserCombobox;
    }
}