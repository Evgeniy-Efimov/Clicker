using Engine.Helpers;

namespace Engine.Enums
{
    public static class InputButtons
    {
        public const string A = "A";
        public const string B = "B";
        public const string C = "C";
        public const string D = "D";
        public const string E = "E";
        public const string F = "F";
        public const string G = "G";
        public const string H = "H";
        public const string I = "I";
        public const string J = "J";
        public const string K = "K";
        public const string L = "L";
        public const string M = "M";
        public const string N = "N";
        public const string O = "O";
        public const string P = "P";
        public const string Q = "Q";
        public const string R = "R";
        public const string S = "S";
        public const string T = "T";
        public const string U = "U";
        public const string V = "V";
        public const string W = "W";
        public const string X = "X";
        public const string Y = "Y";
        public const string Z = "Z";

        // Number keys
        public const string Num0 = "0";
        public const string Num1 = "1";
        public const string Num2 = "2";
        public const string Num3 = "3";
        public const string Num4 = "4";
        public const string Num5 = "5";
        public const string Num6 = "6";
        public const string Num7 = "7";
        public const string Num8 = "8";
        public const string Num9 = "9";

        public const string F1 = "F1";
        public const string F2 = "F2";
        public const string F3 = "F3";
        public const string F4 = "F4";
        public const string F5 = "F5";
        public const string F6 = "F6";
        public const string F7 = "F7";
        public const string F8 = "F8";
        public const string F9 = "F9";
        public const string F10 = "F10";
        public const string F11 = "F11";
        public const string F12 = "F12";

        public const string Escape = "Escape";
        public const string Esc = "Esc";
        public const string Tab = "Tab";
        public const string CapsLock = "CapsLock";
        public const string Shift = "Shift";
        public const string Control = "Control";
        public const string Ctrl = "Ctrl";
        public const string Alt = "Alt";
        public const string Space = "Space";
        public const string Spacebar = "Spacebar";
        public const string Enter = "Enter";
        public const string Return = "Return";
        public const string Backspace = "Backspace";
        public const string Delete = "Delete";
        public const string Del = "Del";
        public const string Insert = "Insert";
        public const string Ins = "Ins";
        public const string Home = "Home";
        public const string End = "End";
        public const string PageUp = "PageUp";
        public const string PgUp = "PgUp";
        public const string PageDown = "PageDown";
        public const string PgDown = "PgDown";

        public const string LeftArrow = "LeftArrow";
        public const string Left = "Left";
        public const string UpArrow = "UpArrow";
        public const string Up = "Up";
        public const string RightArrow = "RightArrow";
        public const string Right = "Right";
        public const string DownArrow = "DownArrow";
        public const string Down = "Down";

        public const string NumPad0 = "NumPad0";
        public const string NumPad1 = "NumPad1";
        public const string NumPad2 = "NumPad2";
        public const string NumPad3 = "NumPad3";
        public const string NumPad4 = "NumPad4";
        public const string NumPad5 = "NumPad5";
        public const string NumPad6 = "NumPad6";
        public const string NumPad7 = "NumPad7";
        public const string NumPad8 = "NumPad8";
        public const string NumPad9 = "NumPad9";
        public const string NumPadMultiply = "NumPadMultiply";
        public const string NumPadAdd = "NumPadAdd";
        public const string NumPadPlus = "NumPadPlus";
        public const string NumPadSeparator = "NumPadSeparator";
        public const string NumPadSubtract = "NumPadSubtract";
        public const string NumPadMinus = "NumPadMinus";
        public const string NumPadDecimal = "NumPadDecimal";
        public const string NumPadDivide = "NumPadDivide";

        public const string LeftShift = "LeftShift";
        public const string RightShift = "RightShift";
        public const string LeftControl = "LeftControl";
        public const string LeftCtrl = "LeftCtrl";
        public const string RightControl = "RightControl";
        public const string RightCtrl = "RightCtrl";
        public const string LeftAlt = "LeftAlt";
        public const string RightAlt = "RightAlt";
        public const string LeftWindows = "LeftWindows";
        public const string LeftWin = "LeftWin";
        public const string RightWindows = "RightWindows";
        public const string RightWin = "RightWin";
        public const string Applications = "Applications";
        public const string App = "App";

        public const string Minus = "Minus";
        public const string Plus = "Plus";
        public const string OpenBracket = "OpenBracket";
        public const string CloseBracket = "CloseBracket";
        public const string Semicolon = "Semicolon";
        public const string Quote = "Quote";
        public const string Comma = "Comma";
        public const string Period = "Period";
        public const string Dot = "Dot";
        public const string Slash = "Slash";
        public const string Backslash = "Backslash";
        public const string Tilde = "Tilde";
        public const string Grave = "Grave";

        public const string MouseLeft = "MouseLeft";
        public const string MouseRight = "MouseRight";
        public const string MouseMiddle = "MouseMiddle";
        public const string MouseXButton1 = "MouseXButton1";
        public const string MouseXButton2 = "MouseXButton2";
        public const string MouseWheelUp = "MouseWheelUp";
        public const string MouseWheelDown = "MouseWheelDown";

        private static readonly Dictionary<string, int> ButtonCodes = new Dictionary<string, int>()
        {
            [A] = 0x41,
            [B] = 0x42,
            [C] = 0x43,
            [D] = 0x44,
            [E] = 0x45,
            [F] = 0x46,
            [G] = 0x47,
            [H] = 0x48,
            [I] = 0x49,
            [J] = 0x4A,
            [K] = 0x4B,
            [L] = 0x4C,
            [M] = 0x4D,
            [N] = 0x4E,
            [O] = 0x4F,
            [P] = 0x50,
            [Q] = 0x51,
            [R] = 0x52,
            [S] = 0x53,
            [T] = 0x54,
            [U] = 0x55,
            [V] = 0x56,
            [W] = 0x57,
            [X] = 0x58,
            [Y] = 0x59,
            [Z] = 0x5A,

            [Num0] = 0x30,
            [Num1] = 0x31,
            [Num2] = 0x32,
            [Num3] = 0x33,
            [Num4] = 0x34,
            [Num5] = 0x35,
            [Num6] = 0x36,
            [Num7] = 0x37,
            [Num8] = 0x38,
            [Num9] = 0x39,

            [F1] = 0x70,
            [F2] = 0x71,
            [F3] = 0x72,
            [F4] = 0x73,
            [F5] = 0x74,
            [F6] = 0x75,
            [F7] = 0x76,
            [F8] = 0x77,
            [F9] = 0x78,
            [F10] = 0x79,
            [F11] = 0x7A,
            [F12] = 0x7B,

            [Escape] = 0x1B,
            [Esc] = 0x1B,
            [Tab] = 0x09,
            [CapsLock] = 0x14,
            [Shift] = 0x10,
            [Control] = 0x11,
            [Ctrl] = 0x11,
            [Alt] = 0x12,
            [Space] = 0x20,
            [Spacebar] = 0x20,
            [Enter] = 0x0D,
            [Backspace] = 0x08,
            [Delete] = 0x2E,
            [Del] = 0x2E,
            [Insert] = 0x2D,
            [Ins] = 0x2D,
            [Home] = 0x24,
            [End] = 0x23,
            [PageUp] = 0x21,
            [PgUp] = 0x21,
            [PageDown] = 0x22,
            [PgDown] = 0x22,

            [LeftArrow] = 0x25,
            [Left] = 0x25,
            [UpArrow] = 0x26,
            [Up] = 0x26,
            [RightArrow] = 0x27,
            [Right] = 0x27,
            [DownArrow] = 0x28,
            [Down] = 0x28,

            [NumPad0] = 0x60,
            [NumPad1] = 0x61,
            [NumPad2] = 0x62,
            [NumPad3] = 0x63,
            [NumPad4] = 0x64,
            [NumPad5] = 0x65,
            [NumPad6] = 0x66,
            [NumPad7] = 0x67,
            [NumPad8] = 0x68,
            [NumPad9] = 0x69,
            [NumPadMultiply] = 0x6A,
            [NumPadAdd] = 0x6B,
            [NumPadPlus] = 0x6B,
            [NumPadSeparator] = 0x6C,
            [NumPadSubtract] = 0x6D,
            [NumPadMinus] = 0x6D,
            [NumPadDecimal] = 0x6E,
            [NumPadDivide] = 0x6F,

            [LeftShift] = 0xA0,
            [RightShift] = 0xA1,
            [LeftControl] = 0xA2,
            [LeftCtrl] = 0xA2,
            [RightControl] = 0xA3,
            [RightCtrl] = 0xA3,
            [LeftAlt] = 0xA4,
            [RightAlt] = 0xA5,
            [LeftWindows] = 0x5B,
            [LeftWin] = 0x5B,
            [RightWindows] = 0x5C,
            [RightWin] = 0x5C,
            [Applications] = 0x5D,
            [App] = 0x5D,

            [Minus] = 0xBD,
            [Plus] = 0xBB,
            [OpenBracket] = 0xDB,
            [CloseBracket] = 0xDD,
            [Semicolon] = 0xBA,
            [Quote] = 0xDE,
            [Comma] = 0xBC,
            [Period] = 0xBE,
            [Dot] = 0xBE,
            [Slash] = 0xBF,
            [Backslash] = 0xDC,
            [Tilde] = 0xC0,
            [Grave] = 0xC0,

            [MouseLeft] = 0x01,
            [MouseRight] = 0x02,
            [MouseMiddle] = 0x04,
            [MouseXButton1] = 0x05,
            [MouseXButton2] = 0x06,
            [MouseWheelUp] = 0x07,
            [MouseWheelDown] = 0x08
        };

        private static readonly List<string> ExtendedButtons = new List<string>()
        {
            Insert, Delete, PageUp, PageDown, End, Home, Left, Up, Right, Down, NumPadDivide, NumPadSubtract, Enter, LeftWin, RightWin, App
        };

        private static readonly List<string> ModifierButtons = new List<string>()
        {
            Shift, Alt, Control, LeftShift, RightShift, LeftAlt, RightAlt, LeftControl, RightControl, LeftWin, RightWin
        };

        public static int GetButtonCode(string buttonName)
        {
            var buttons = ButtonCodes.Where(b => b.Key.NormalizeString() == buttonName.NormalizeString());

            if (buttons.Any())
            {
                return buttons.First().Value;
            }

            throw new Exception($"Unknown input button '{buttonName}'");
        }

        public static bool IsExtendedButton(string buttonName)
        {
            return ExtendedButtons.Select(e => e.NormalizeString()).Contains(buttonName.NormalizeString());
        }

        public static bool IsModifierButton(string buttonName)
        {
            return ModifierButtons.Select(e => e.NormalizeString()).Contains(buttonName.NormalizeString());
        }
    }
}