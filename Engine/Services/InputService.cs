using Engine.Enums;
using Engine.Services.Interfaces;
using System.Runtime.InteropServices;

namespace Engine.Services
{
    public class WinInputService : IInputService
    {
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        private static extern short VkKeyScan(char ch);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out POINT lpPoint);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_WHEEL = 0x0800;

        private const uint KEYEVENTF_KEYDOWN = 0x0000;
        private const uint KEYEVENTF_KEYUP = 0x0002;
        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        private void Wait(int delayMilliseconds = 10)
        {
            Thread.Sleep(delayMilliseconds);
        }

        public (int x, int y) GetCursorPosition()
        {
            POINT point;
            if (GetCursorPos(out point))
            {
                return (point.X, point.Y);
            }
            return (0, 0);
        }

        public void LeftClick()
        {
            HoldLeftMouseButton();
            Wait();
            ReleaseLeftMouseButton();
        }

        public void LeftClick(int x, int y)
        {
            SetCursorPos(x, y);
            Wait();
            LeftClick();
        }

        public void HoldLeftMouseButton()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        }

        public void HoldLeftMouseButton(int x, int y)
        {
            SetCursorPos(x, y);
            Wait();
            HoldLeftMouseButton();
        }

        public void ReleaseLeftMouseButton()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        public void RightClick()
        {
            HoldRightMouseButton();
            Wait();
            ReleaseRightMouseButton();
        }

        public void RightClick(int x, int y)
        {
            SetCursorPos(x, y);
            Wait();
            RightClick();
        }

        public void HoldRightMouseButton()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
        }

        public void HoldRightMouseButton(int x, int y)
        {
            SetCursorPos(x, y);
            Wait();
            HoldRightMouseButton();
        }

        public void ReleaseRightMouseButton()
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        public void MoveMouse(int x, int y)
        {
            SetCursorPos(x, y);
        }

        public void ScrollMouse(int delta)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (uint)delta, 0);
        }

        public void HoldButton(string buttonName)
        {
            var buttonCode = InputButtons.GetButtonCode(buttonName);
            var flags = KEYEVENTF_KEYDOWN;

            if (InputButtons.IsExtendedButton(buttonName))
            {
                flags |= KEYEVENTF_EXTENDEDKEY;
            }

            keybd_event((byte)buttonCode, 0, flags, 0);
        }

        public void ReleaseButton(string buttonName)
        {
            var buttonCode = InputButtons.GetButtonCode(buttonName);
            var flags = KEYEVENTF_KEYUP;

            if (InputButtons.IsExtendedButton(buttonName))
            {
                flags |= KEYEVENTF_EXTENDEDKEY;
            }

            keybd_event((byte)buttonCode, 0, flags, 0);
        }

        public void PressButton(string buttonName)
        {
            HoldButton(buttonName);
            Wait();
            ReleaseButton(buttonName);
        }

        public void PressButtons(params string[] buttonNames)
        {
            if (buttonNames == null || buttonNames.Length == 0)
                return;

            var modifierButtonNames = buttonNames.Where(InputButtons.IsModifierButton);
            var ordinaryButtonNames = buttonNames.Where(b => !InputButtons.IsModifierButton(b));

            foreach (var buttonName in modifierButtonNames)
            {
                HoldButton(buttonName);
                Wait();
            }

            foreach (var buttonName in ordinaryButtonNames)
            {
                HoldButton(buttonName);
                Wait();
            }

            foreach (var buttonName in ordinaryButtonNames)
            {
                ReleaseButton(buttonName);
                Wait();
            }

            foreach (var buttonName in modifierButtonNames)
            {
                ReleaseButton(buttonName);
                Wait();
            }
        }
    }
}
