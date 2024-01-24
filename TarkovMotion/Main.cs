using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarkovMotion
{
    public partial class Main : Form
    {
        public event EventHandler<MotionData> MotionDataRecievedEvent;

        public double LastX = -99;
        public double LastY = -99;

        public double StartX = -99;
        public double StartY = -99;
        public double StartYaw = -999;   

        public bool _qDown = false;
        public bool _eDown = false;

        public double lastYUpdate = 0;

        public bool shoulderTransitioned = false;

        public Color initialBackColor;

        public DateTime lastProcessed = DateTime.Now;

        public bool EDown
        {
            get
            {
                return _eDown;
            }
            set
            {
                _eDown = value;
                ShowTriggerActivation(value);
                if (value)
                {
                    SetActiveKeyPressLabel("E");
                }
                else
                {
                    SetActiveKeyPressLabel("");
                }
            }
        }

        public bool QDown
        {
            get
            {
                return _qDown;
            }
            set
            {
                _qDown = value;
                ShowTriggerActivation(value);
                if (value)
                {
                    SetActiveKeyPressLabel("Q");    
                }
                else
                {
                    SetActiveKeyPressLabel("");
                }
            }
        }

        public Main()
        {
            InitializeComponent();

            initialBackColor = this.BackColor;

            TriggerDistanceTextBox.Text = Settings.Instance.TriggerDistance.ToString();
            TransitionShoulderCheckBox.Checked = Settings.Instance.ShoulderTransition;
            TransitionKeybind.Text = Settings.Instance.ShoulderTransitionKey.ToString();
            LeanLeftTextBox.Text = Settings.Instance.LeftLeanKey.ToString();
            LeanRightTextBox.Text = Settings.Instance.RightLeanKey.ToString();

            MotionDataRecievedEvent += ProcessMotionData;

            //Create a call to the sub Listen() that runs continuously in a separate thread.
            Task.Run(() => Listen());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Settings.Instance.LaunchProgramsOnstart)
            {
                //Check if Settings.Instance.AITrackerEXEPath is already running. If not, start it.
                if (Settings.Instance.AITrackerEXEPath != "" && !Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(Settings.Instance.AITrackerEXEPath)).Any())
                {
                    string programPath = Settings.Instance.AITrackerEXEPath;
                    string workingDirectory = System.IO.Path.GetDirectoryName(programPath);

                    ProcessStartInfo startInfo = new ProcessStartInfo(programPath);
                    startInfo.WorkingDirectory = workingDirectory;

                    Process.Start(startInfo);
                }

                if (Settings.Instance.TarkovMonitorEXEPath != "" && !Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(Settings.Instance.TarkovMonitorEXEPath)).Any())
                {
                    string programPath = Settings.Instance.TarkovMonitorEXEPath;
                    string workingDirectory = System.IO.Path.GetDirectoryName(programPath);

                    ProcessStartInfo startInfo = new ProcessStartInfo(programPath);
                    startInfo.WorkingDirectory = workingDirectory;

                    Process.Start(startInfo);

                }
                if (Settings.Instance.Browser == "Chrome")
                {
                    //Launch chrome and go to https://tarkov.dev/maps
                    Process.Start("chrome.exe", "https://tarkov.dev/maps");
                    Process.Start("chrome.exe", "https://tarkovtracker.io/tasks");
                }
                else if (Settings.Instance.Browser == "Firefox")
                {
                    //Launch firefox and go to https://tarkov.dev/maps
                    Process.Start("firefox.exe", "https://tarkov.dev/maps");
                    Process.Start("firefox.exe", "https://tarkovtracker.io/tasks");
                }
                else if (Settings.Instance.Browser == "Edge")
                {
                    //Launch Edge and go to https://tarkov.dev/maps
                    Process.Start("microsoft-edge:https://tarkov.dev/maps");
                    Process.Start("microsoft-edge:https://tarkovtracker.io/tasks");
                }       
            }
        }

        private void ProcessMotionData(object sender, MotionData e)
        {
            string activeWindow = ActiveWindowTitleFetcher.GetActiveWindowTitle();
            if (activeWindow != null) { activeWindow = activeWindow.Trim();}


            if (InvokeRequired)
            {
                Invoke(new Action(() => ProcessMotionData(sender, e)));
                return;
            }

            if (LastX == -99)
            {
                LastX = e.X;
                LastY = e.Y;
            }
            if (StartX == -99)
            {
                StartX = e.X;
                StartY = e.Y;
            }
            if (StartYaw == -999)
            {
                StartYaw = e.Yaw;
            }   

            double xDiff = StartX - e.X;
            double yDiff = StartY - e.Y;

            if (Settings.Instance.Mirrored )
            {
                xDiff = e.X - StartX;
                yDiff = e.Y - StartY;
            }

            DeltaXTextBox.Text = xDiff.ToString();

            //YawLabel.Text = e.Yaw.ToString();
            //PitchLabel.Text = e.Pitch.ToString();
            //RollLabel.Text = e.Roll.ToString();

            bool triggerKeyBind = true;

            ShowActiveWindow(activeWindow);

            if (!(activeWindow == "EscapeFromTarkov" || activeWindow == "PUBG: BATTLEGROUNDS"))
            {
                triggerKeyBind = false;
            }

            if (e.Yaw > 35 || e.Yaw < -35)
            {
                if (!EDown && !QDown)
                {
                    return;
                }

            }

            if (xDiff > Settings.Instance.TriggerDistance)
            {
                if (!EDown)
                {
                    if (triggerKeyBind)
                    {
                        if (shoulderTransitioned && Settings.Instance.ShoulderTransition)
                        {
                            KeyboardSimulator.PressKey(Settings.Instance.ShoulderTransitionKey, false);
                            KeyboardSimulator.PressKey(Settings.Instance.ShoulderTransitionKey, true);
                            shoulderTransitioned = false;
                        }
                        KeyboardSimulator.PressKey(Settings.Instance.RightLeanKey, false);
                    }
                    EDown = true;
                }
            }
            else if (xDiff < -Settings.Instance.TriggerDistance)
            {
                if (!QDown)
                {
                    if (triggerKeyBind)
                    {
                        if (!shoulderTransitioned && Settings.Instance.ShoulderTransition)
                        {
                            KeyboardSimulator.PressKey(Settings.Instance.ShoulderTransitionKey, false);
                            KeyboardSimulator.PressKey(Settings.Instance.ShoulderTransitionKey, true);
                            shoulderTransitioned = true;
                        }

                        KeyboardSimulator.PressKey(Settings.Instance.LeftLeanKey, false);
                    }
                    QDown = true;
                }

            }
            else if (EDown)
            {
                if (triggerKeyBind)
                {
                    KeyboardSimulator.PressKey(Settings.Instance.RightLeanKey , true);
                }
                EDown = false;
            }
            else if (QDown)
            {
                if (triggerKeyBind)
                {
                    if (shoulderTransitioned && Settings.Instance.ShoulderTransition)
                    {
                        KeyboardSimulator.PressKey(Settings.Instance.ShoulderTransitionKey, false);
                        KeyboardSimulator.PressKey(Settings.Instance.ShoulderTransitionKey, true);
                        shoulderTransitioned = false;
                    }

                    KeyboardSimulator.PressKey(Settings.Instance.LeftLeanKey, true);
                }
                QDown = false;
            }


            LastX = e.X;

            lastProcessed = DateTime.Now;
        }

        private void SetActiveKeyPressLabel(string key)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SetActiveKeyPressLabel(key)));
                return;
            }

            ActiveKeyPressLabel.Text = "Active Key Press: " + key;
        }

        private void ShowTriggerActivation(bool leaning)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ShowTriggerActivation(leaning)));
                return;
            }

            if (leaning)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = initialBackColor;
            }
        }

        public void Listen()
        {
            //Create a new UDP client.
            UdpClient udpClient = new UdpClient(4242);

            //Create an IPEndPoint to record the IP Address and port number of the sender.  
            // The IPEndPoint will allow you to read datagrams sent from any source.
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                try
                {
                    // Blocks until a message returns on this socket from a remote host.
                    byte[] receivedBytes = udpClient.Receive(ref RemoteIpEndPoint);

                    string[] labels = { "X:", "Y:", "Z:", "Yaw:", "Pitch:", "Roll:" };

                    MotionData motionData = new MotionData();
                    motionData.X = BitConverter.ToDouble(receivedBytes, 0);
                    motionData.Y = BitConverter.ToDouble(receivedBytes, 8);
                    motionData.Z = BitConverter.ToDouble(receivedBytes, 16);
                    motionData.Yaw = BitConverter.ToDouble(receivedBytes, 24);
                    motionData.Pitch = BitConverter.ToDouble(receivedBytes, 32);
                    motionData.Roll = BitConverter.ToDouble(receivedBytes, 40);

                    MotionDataRecievedEvent?.Invoke(this, motionData);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            StartX = -99;
            StartY = -99;
            StartYaw = -999;
        }

        private void TransitionShoulderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance.ShoulderTransition  = TransitionShoulderCheckBox.Checked;
        }

        private void ShowActiveWindow(string activeWindow)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ShowActiveWindow(activeWindow)));
                return;
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Settings.Save();
            MessageBox.Show("Settings Saved!"); 
        }

        private void LeanLeftTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Settings.Instance.LeftLeanKey  = e.KeyCode;
            if (LeanLeftTextBox.Text != Settings.Instance.LeftLeanKey.ToString())
            {
                LeanLeftTextBox.Text = Settings.Instance.LeftLeanKey.ToString();
            }
        }

        private void LeanRightTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Settings.Instance.RightLeanKey = e.KeyCode;
            if (LeanRightTextBox.Text != Settings.Instance.RightLeanKey.ToString())
            {
                LeanRightTextBox.Text = Settings.Instance.RightLeanKey.ToString();
            }
        }

        private void TriggerDistanceTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(TriggerDistanceTextBox.Text, out int triggerDistanceInt))
            {
                Settings.Instance.TriggerDistance = triggerDistanceInt;
            }
        }

        private void TransitionKeybind_KeyUp(object sender, KeyEventArgs e)
        {
            Settings.Instance.ShoulderTransitionKey = e.KeyCode;
            if (TransitionKeybind.Text != Settings.Instance.ShoulderTransitionKey.ToString())
            {
                TransitionKeybind.Text = Settings.Instance.ShoulderTransitionKey.ToString();
            }
        }

        private void MirroredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance.Mirrored  = MirroredCheckBox.Checked;
        }


    }
}
