#region Using directives

using System;
using System.Runtime.InteropServices;

#endregion

namespace Svatky
{
    /// <summary>
    /// Summary description for Keyboard.
    /// </summary>
    public class Keyboard
    {
        // Methods
        [DllImport("coredll.dll")]
        private static extern IntPtr GetFocus();

        [DllImport("coredll.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Message, int wParam, int lParam);

        public static void SetType(Modes mode)
        {
            IntPtr ptr1 = GetFocus();
            SendMessage(ptr1, 0xde, 0, (ushort)mode);
        }

        public enum Modes
        {
            Spell = 0,
            T9 = 1,
            Numbers = 2,
            Text = 3
        }
    }
}
