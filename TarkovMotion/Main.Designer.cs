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
            this.DeltaYTextBox = new System.Windows.Forms.TextBox();
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
            this.YawLabel = new System.Windows.Forms.Label();
            this.PitchLabel = new System.Windows.Forms.Label();
            this.RollLabel = new System.Windows.Forms.Label();
            this.ActiveKeyPressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeltaXTextBox
            // 
            this.DeltaXTextBox.Location = new System.Drawing.Point(109, 120);
            this.DeltaXTextBox.Name = "DeltaXTextBox";
            this.DeltaXTextBox.Size = new System.Drawing.Size(60, 20);
            this.DeltaXTextBox.TabIndex = 4;
            // 
            // DeltaYTextBox
            // 
            this.DeltaYTextBox.Location = new System.Drawing.Point(364, 264);
            this.DeltaYTextBox.Name = "DeltaYTextBox";
            this.DeltaYTextBox.Size = new System.Drawing.Size(76, 20);
            this.DeltaYTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trigger Distance:";
            // 
            // TriggerDistanceTextBox
            // 
            this.TriggerDistanceTextBox.Location = new System.Drawing.Point(109, 94);
            this.TriggerDistanceTextBox.Name = "TriggerDistanceTextBox";
            this.TriggerDistanceTextBox.Size = new System.Drawing.Size(60, 20);
            this.TriggerDistanceTextBox.TabIndex = 7;
            this.TriggerDistanceTextBox.TextChanged += new System.EventHandler(this.TriggerDistanceTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X Dist:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CenterButton
            // 
            this.CenterButton.Location = new System.Drawing.Point(99, 238);
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
            this.TransitionShoulderCheckBox.Location = new System.Drawing.Point(64, 159);
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
            this.label1.Location = new System.Drawing.Point(10, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Transition Keybind:";
            // 
            // TransitionKeybind
            // 
            this.TransitionKeybind.Location = new System.Drawing.Point(109, 182);
            this.TransitionKeybind.Name = "TransitionKeybind";
            this.TransitionKeybind.Size = new System.Drawing.Size(60, 20);
            this.TransitionKeybind.TabIndex = 13;
            this.TransitionKeybind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TransitionKeybind_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lean Left Key:";
            // 
            // LeanLeftTextBox
            // 
            this.LeanLeftTextBox.Location = new System.Drawing.Point(109, 31);
            this.LeanLeftTextBox.Name = "LeanLeftTextBox";
            this.LeanLeftTextBox.Size = new System.Drawing.Size(60, 20);
            this.LeanLeftTextBox.TabIndex = 15;
            this.LeanLeftTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LeanLeftTextBox_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lean Right Key:";
            // 
            // LeanRightTextBox
            // 
            this.LeanRightTextBox.Location = new System.Drawing.Point(109, 57);
            this.LeanRightTextBox.Name = "LeanRightTextBox";
            this.LeanRightTextBox.Size = new System.Drawing.Size(60, 20);
            this.LeanRightTextBox.TabIndex = 17;
            this.LeanRightTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LeanRightTextBox_KeyUp);
            // 
            // MirroredCheckBox
            // 
            this.MirroredCheckBox.AutoSize = true;
            this.MirroredCheckBox.Location = new System.Drawing.Point(105, 215);
            this.MirroredCheckBox.Name = "MirroredCheckBox";
            this.MirroredCheckBox.Size = new System.Drawing.Size(64, 17);
            this.MirroredCheckBox.TabIndex = 19;
            this.MirroredCheckBox.Text = "Mirrored";
            this.MirroredCheckBox.UseVisualStyleBackColor = true;
            this.MirroredCheckBox.CheckedChanged += new System.EventHandler(this.MirroredCheckBox_CheckedChanged);
            // 
            // YawLabel
            // 
            this.YawLabel.AutoSize = true;
            this.YawLabel.Location = new System.Drawing.Point(22, 270);
            this.YawLabel.Name = "YawLabel";
            this.YawLabel.Size = new System.Drawing.Size(38, 13);
            this.YawLabel.TabIndex = 20;
            this.YawLabel.Text = "X Dist:";
            // 
            // PitchLabel
            // 
            this.PitchLabel.AutoSize = true;
            this.PitchLabel.Location = new System.Drawing.Point(22, 293);
            this.PitchLabel.Name = "PitchLabel";
            this.PitchLabel.Size = new System.Drawing.Size(38, 13);
            this.PitchLabel.TabIndex = 21;
            this.PitchLabel.Text = "X Dist:";
            // 
            // RollLabel
            // 
            this.RollLabel.AutoSize = true;
            this.RollLabel.Location = new System.Drawing.Point(22, 320);
            this.RollLabel.Name = "RollLabel";
            this.RollLabel.Size = new System.Drawing.Size(38, 13);
            this.RollLabel.TabIndex = 22;
            this.RollLabel.Text = "X Dist:";
            // 
            // ActiveKeyPressLabel
            // 
            this.ActiveKeyPressLabel.AutoSize = true;
            this.ActiveKeyPressLabel.Location = new System.Drawing.Point(30, 9);
            this.ActiveKeyPressLabel.Name = "ActiveKeyPressLabel";
            this.ActiveKeyPressLabel.Size = new System.Drawing.Size(93, 13);
            this.ActiveKeyPressLabel.TabIndex = 23;
            this.ActiveKeyPressLabel.Text = "Active Key Press: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(192, 266);
            this.Controls.Add(this.ActiveKeyPressLabel);
            this.Controls.Add(this.RollLabel);
            this.Controls.Add(this.PitchLabel);
            this.Controls.Add(this.YawLabel);
            this.Controls.Add(this.MirroredCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LeanRightTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LeanLeftTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransitionKeybind);
            this.Controls.Add(this.TransitionShoulderCheckBox);
            this.Controls.Add(this.CenterButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TriggerDistanceTextBox);
            this.Controls.Add(this.DeltaYTextBox);
            this.Controls.Add(this.DeltaXTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Tarkov Motion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DeltaXTextBox;
        private System.Windows.Forms.TextBox DeltaYTextBox;
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
        private System.Windows.Forms.Label YawLabel;
        private System.Windows.Forms.Label PitchLabel;
        private System.Windows.Forms.Label RollLabel;
        private System.Windows.Forms.Label ActiveKeyPressLabel;
    }
}

