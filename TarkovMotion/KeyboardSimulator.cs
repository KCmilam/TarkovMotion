using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarkovMotion
{
    public class KeyboardSimulator
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        private const int KEYEVENTF_KEYUP = 0x0002; //Key up flag

        public static void PressKey(Keys key, bool up)
        {
            if (up)
            {
                // Release the key
                keybd_event((byte)key, 0, KEYEVENTF_KEYUP, 0);
            }
            else
            {
                // Press the key
                keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY, 0);
            }
        }
    }
}
