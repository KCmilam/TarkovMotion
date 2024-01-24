namespace TarkovMotion
{
    partial class Main
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
            this.DeltaXTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TriggerDistanceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CenterButton = new System.Windows.Forms.Button();
            this.TransitionShoulderCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TransitionKeybind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LeanLeftTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LeanRightTextBox = new System.Windows.Forms.TextBox();
            this.MirroredCheckBox = new System.Windows.Forms.CheckBox();
            this.ActiveKeyPressLabel = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.SaveButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SettingsButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeltaXTextBox
            // 
            this.DeltaXTextBox.Location = new System.Drawing.Point(113, 122);
            this.DeltaXTextBox.Name = "DeltaXTextBox";
            this.DeltaXTextBox.Size = new System.Drawing.Size(60, 20);
            this.DeltaXTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trigger Distance:";
            // 
            // TriggerDistanceTextBox
            // 
            this.TriggerDistanceTextBox.Location = new System.Drawing.Point(113, 96);
            this.TriggerDistanceTextBox.Name = "TriggerDistanceTextBox";
            this.TriggerDistanceTextBox.Size = new System.Drawing.Size(60, 20);
            this.TriggerDistanceTextBox.TabIndex = 7;
            this.TriggerDistanceTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TriggerDistanceTextBox_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X Dist:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CenterButton
            // 
            this.CenterButton.Location = new System.Drawing.Point(103, 240);
            this.CenterButton.Name = "CenterButton";
            this.CenterButton.Size = new System.Drawing.Size(70, 23);
            this.CenterButton.TabIndex = 10;
            this.CenterButton.Text = "Re-center";
            this.CenterButton.UseVisualStyleBackColor = true;
            this.CenterButton.Click += new System.EventHandler(this.CenterButton_Click);
            // 
            // TransitionShoulderCheckBox
            // 
            this.TransitionShoulderCheckBox.AutoSize = true;
            this.TransitionShoulderCheckBox.Location = new System.Drawing.Point(68, 161);
            this.TransitionShoulderCheckBox.Name = "TransitionShoulderCheckBox";
            this.TransitionShoulderCheckBox.Size = new System.Drawing.Size(117, 17);
            this.TransitionShoulderCheckBox.TabIndex = 12;
            this.TransitionShoulderCheckBox.Text = "Transition Shoulder";
            this.TransitionShoulderCheckBox.UseVisualStyleBackColor = true;
            this.TransitionShoulderCheckBox.CheckedChanged += new System.EventHandler(this.TransitionShoulderCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Transition Keybind:";
            // 
            // TransitionKeybind
            // 
            this.TransitionKeybind.Location = new System.Drawing.Point(113, 184);
            this.TransitionKeybind.Name = "TransitionKeybind";
            this.TransitionKeybind.Size = new System.Drawing.Size(60, 20);
            this.TransitionKeybind.TabIndex = 13;
            this.TransitionKeybind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TransitionKeybind_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lean Left Key:";
            // 
            // LeanLeftTextBox
            // 
            this.LeanLeftTextBox.Location = new System.Drawing.Point(113, 33);
            this.LeanLeftTextBox.Name = "LeanLeftTextBox";
            this.LeanLeftTextBox.Size = new System.Drawing.Size(60, 20);
            this.LeanLeftTextBox.TabIndex = 15;
            this.LeanLeftTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LeanLeftTextBox_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lean Right Key:";
            // 
            // LeanRightTextBox
            // 
            this.LeanRightTextBox.Location = new System.Drawing.Point(113, 59);
            this.LeanRightTextBox.Name = "LeanRightTextBox";
            this.LeanRightTextBox.Size = new System.Drawing.Size(60, 20);
            this.LeanRightTextBox.TabIndex = 17;
            this.LeanRightTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LeanRightTextBox_KeyUp);
            // 
            // MirroredCheckBox
            // 
            this.MirroredCheckBox.AutoSize = true;
            this.MirroredCheckBox.Location = new System.Drawing.Point(109, 217);
            this.MirroredCheckBox.Name = "MirroredCheckBox";
            this.MirroredCheckBox.Size = new System.Drawing.Size(64, 17);
            this.MirroredCheckBox.TabIndex = 19;
            this.MirroredCheckBox.Text = "Mirrored";
            this.MirroredCheckBox.UseVisualStyleBackColor = true;
            this.MirroredCheckBox.CheckedChanged += new System.EventHandler(this.MirroredCheckBox_CheckedChanged);
            // 
            // ActiveKeyPressLabel
            // 
            this.ActiveKeyPressLabel.AutoSize = true;
            this.ActiveKeyPressLabel.Location = new System.Drawing.Point(34, 11);
            this.ActiveKeyPressLabel.Name = "ActiveKeyPressLabel";
            this.ActiveKeyPressLabel.Size = new System.Drawing.Size(93, 13);
            this.ActiveKeyPressLabel.TabIndex = 23;
            this.ActiveKeyPressLabel.Text = "Active Key Press: ";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.SaveButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LeanLeftTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ActiveKeyPressLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.DeltaXTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.MirroredCheckBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TriggerDistanceTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.LeanRightTextBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.CenterButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TransitionShoulderCheckBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.TransitionKeybind);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(207, 303);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(207, 328);
            this.toolStripContainer1.TabIndex = 24;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(103, 269);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(70, 23);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(61, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(49, 22);
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(207, 328);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Tarkov Motion";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox DeltaXTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TriggerDistanceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CenterButton;
        private System.Windows.Forms.CheckBox TransitionShoulderCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TransitionKeybind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LeanLeftTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LeanRightTextBox;
        private System.Windows.Forms.CheckBox MirroredCheckBox;
        private System.Windows.Forms.Label ActiveKeyPressLabel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel SettingsButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

