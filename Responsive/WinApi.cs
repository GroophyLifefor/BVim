using System.Runtime.InteropServices;

namespace BVim.Responsive
{
    static class WinApi
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);
        [DllImport("user32.dll")]
        static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        [DllImport("user32.dll")]
        static extern IntPtr SetCursor(IntPtr hCursor);
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();
    }
}
