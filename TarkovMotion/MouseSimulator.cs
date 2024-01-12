using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TarkovMotion
{
    public class MouseSimulator
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_WHEEL = 0x0800;

        public static void MoveMouseWheel(int amount)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, amount, 0);
        }
    }
}
