using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarkovMotion
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            //Load the settings from the settings file
            LaunchProgramsCheckBox.Checked = Settings.Instance.LaunchProgramsOnstart;
            AITrackerEXETextBox.Text = Settings.Instance.AITrackerEXEPath;
            TarkovMonitorEXETextbox.Text = Settings.Instance.TarkovMonitorEXEPath;

            //Set the default values for the combo box
            BrowserCombobox.Items.Add("Firefox");
            BrowserCombobox.Items.Add("Chrome");
            BrowserCombobox.Items.Add("Edge");
            BrowserCombobox.SelectedItem = Settings.Instance.Browser;
        }

        private void TarkovMonitorBrowseButton_Click(object sender, EventArgs e)
        {
            //Open a file dialog to select the Tarkov Monitor executable
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
            openFileDialog.Title = "Select Tarkov Monitor Executable";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                TarkovMonitorEXETextbox.Text = openFileDialog.FileName;
            }
        }

        private void AITrackerBrowseButton_Click(object sender, EventArgs e)
        {
            //Open a file dialog to select the AITracker executable
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe";
            openFileDialog.Title = "Select AITracker Executable";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                AITrackerEXETextBox.Text = openFileDialog.FileName;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Settings.Instance.LaunchProgramsOnstart = LaunchProgramsCheckBox.Checked;
            Settings.Instance.AITrackerEXEPath = AITrackerEXETextBox.Text;
            Settings.Instance.TarkovMonitorEXEPath = TarkovMonitorEXETextbox.Text;
            Settings.Instance.Browser = BrowserCombobox.SelectedItem.ToString();
            Settings.Save();
            this.Close();
        }
    }
}
