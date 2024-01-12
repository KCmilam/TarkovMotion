using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

        public bool _qDown = false;
        public bool _eDown = false;

        public double lastYUpdate = 0;

        public bool transitionShoulder = true;
        public bool shoulderTransitioned = false;
        public Keys shoulderKey = Keys.Divide;
        public Keys leanLeftKey = Keys.Q;
        public Keys leanRightKey = Keys.E;

        public double triggerDistance = 8;

        public bool mirrored = false;

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
            }
        }

        public Main()
        {
            InitializeComponent();

            initialBackColor = this.BackColor;

            TriggerDistanceTextBox.Text = triggerDistance.ToString();
            TransitionShoulderCheckBox.Checked = transitionShoulder;
            TransitionKeybind.Text = shoulderKey.ToString();
            LeanLeftTextBox.Text = leanLeftKey.ToString();
            LeanRightTextBox.Text = leanRightKey.ToString();

            MotionDataRecievedEvent += ProcessMotionData;

            //Create a call to the sub Listen() that runs continuously in a separate thread.
            Task.Run(() => Listen());
        }

        private void ProcessMotionData(object sender, MotionData e)
        {
            string activeWindow = ActiveWindowTitleFetcher.GetActiveWindowTitle();


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

            double xDiff = StartX - e.X;
            double yDiff = StartY - e.Y;

            if (mirrored)
            {
                xDiff = e.X - StartX;
                yDiff = e.Y - StartY;
            }

            DeltaXTextBox.Text = xDiff.ToString();
            DeltaYTextBox.Text = yDiff.ToString();

            bool triggerKeyBind = true;
            if (!(activeWindow == "EscapeFromTarkov" || activeWindow == "PUBG: BATTLEGROUNDS"))
            {
                triggerKeyBind = false;
            }

            if (xDiff < -triggerDistance)
            {
                if (!EDown)
                {
                    if (triggerKeyBind)
                    {
                        if (shoulderTransitioned && transitionShoulder)
                        {
                            KeyboardSimulator.PressKey(shoulderKey, false);
                            KeyboardSimulator.PressKey(shoulderKey, true);
                            shoulderTransitioned = false;
                        }
                        KeyboardSimulator.PressKey(leanRightKey, false);
                    }
                    EDown = true;
                }
            }
            else if (xDiff > triggerDistance)
            {
                if (!QDown)
                {
                    if (triggerKeyBind)
                    {
                        if (!shoulderTransitioned && transitionShoulder)
                        {
                            KeyboardSimulator.PressKey(shoulderKey, false);
                            KeyboardSimulator.PressKey(shoulderKey, true);
                            shoulderTransitioned = true;
                        }

                        KeyboardSimulator.PressKey(leanLeftKey, false);
                    }
                    QDown = true;
                }

            }
            else if (EDown)
            {
                if (triggerKeyBind)
                {
                    KeyboardSimulator.PressKey(leanRightKey, true);
                }
                EDown = false;
            }
            else if (QDown)
            {
                if (triggerKeyBind)
                {
                    if (shoulderTransitioned && transitionShoulder)
                    {
                        KeyboardSimulator.PressKey(shoulderKey, false);
                        KeyboardSimulator.PressKey(shoulderKey, true);
                        shoulderTransitioned = false;
                    }

                    KeyboardSimulator.PressKey(leanLeftKey, true);
                }
                QDown = false;
            }


            LastX = e.X;

            lastProcessed = DateTime.Now;
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

        private void TriggerDistanceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TriggerDistanceTextBox.Text, out int triggerDistanceInt))
            {
                triggerDistance = triggerDistanceInt;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            StartX = -99;
            StartY = -99;
        }

        private void TransitionShoulderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            transitionShoulder = TransitionShoulderCheckBox.Checked;
        }

        private void TransitionKeybind_KeyUp(object sender, KeyEventArgs e)
        {
            shoulderKey = e.KeyCode;
            if (TransitionKeybind.Text != shoulderKey.ToString())
            {
                TransitionKeybind.Text = shoulderKey.ToString();
            }
        }

        private void LeanLeftTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            leanLeftKey = e.KeyCode;
            if (LeanLeftTextBox.Text != leanLeftKey.ToString())
            {
                LeanLeftTextBox.Text = leanLeftKey.ToString();
            }
        }

        private void LeanRightTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            leanRightKey = e.KeyCode;
            if (LeanRightTextBox.Text != leanRightKey.ToString())
            {
                LeanRightTextBox.Text = leanRightKey.ToString();
            }
        }

        private void MirroredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mirrored = MirroredCheckBox.Checked;
        }
    }
}
