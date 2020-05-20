﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinAnim
{
    public class WinAPIClass
    {
        #region
        [Flags]
        public enum AnimateWindowFlags:int
        {
            AW_HOR_POSITIVE = 1,
            AW_HOR_NEGATIVE = 2,
            AW_VER_POSITIVE = 4,
            AW_VER_NEGATIVE = 8,
            AW_CENTER       = 16,
            AW_HIDE         = 65536,
            AW_ACTIVATE     = 131072,
            AW_SLIDE        = 262144,
            AW_BLEND        = 524288
        }

        internal static void AnimateWindow(Form1 form1, int v, AnimateWindowFlags aW_ACTIVATE, AnimateWindowFlags aW_BLEND)
        {
            throw new NotImplementedException();
        }

        [DllImportAttribute("user32.dll", EntryPoint = "AnimateWindow", SetLastError = true)]
        public static extern bool AnimateWindow(IntPtr hwnd, int intdwTime, int dwFlags);

        public static bool AnimateWindow(Control ctrl, int dwTime,
        AnimateWindowFlags Flags)
        {
            return AnimateWindow(ctrl.Handle, dwTime, (int)Flags);
        }
        #endregion
    }
}