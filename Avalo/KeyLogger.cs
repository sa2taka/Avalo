using System.Windows.Forms;


namespace Avalo {
    class KeyLogger {
        // WindowsAPIのインポート
        [System.Runtime.InteropServices.DllImport("user32.dll",
            CharSet = System.Runtime.InteropServices.CharSet.Auto,
            CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern short GetKeyState(int nVirtKey);

        public static bool IsKeyLocked(Keys key_val) {
            return (GetKeyState((int)key_val) & 0x80) != 0;
        }
    }

}

