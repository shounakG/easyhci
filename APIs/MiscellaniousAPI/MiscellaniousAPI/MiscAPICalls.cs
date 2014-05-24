using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MiscellaniousAPI
{
    public class clsMisc
    {
        private const String TASK_MANAGER = "taskmgr.exe";
        private const String CALCULATOR = "calc.exe";
        private const String COMMAND_PROMPT = "cmd.exe";
        private const String NOTEPAD = "notepad.exe";
        private const String INTERNET = "www.google.co.in";

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        public void openTaskMgr()
        {
            Process.Start(TASK_MANAGER);
        }

        public void openCalc()
        {
            Process.Start(CALCULATOR);
        }

        public void openCmd()
        {
            Process.Start(COMMAND_PROMPT);
        }

        public void openNotepad()
        {
            Process.Start(NOTEPAD);
        }

        public void openInternet()
        {
            Process.Start(INTERNET);
        }

        public void shutdown60()
        {
            Process.Start("shutdown", "-s -t 60");
        }

        public void restart60()
        {
            Process.Start("shutdown", "-r -t 60");
        }

        public void hibernate()
        {
            Process.Start("powercfg", "-hibernate on");
            Process.Start("rundll32.exe", "PowrProf.dll,SetSuspendState");
        }

        public void sleep()
        {
            Process.Start("powercfg", "-hibernate off");
            Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState 0,1,0");
            Process.Start("powercfg", "-hibernate on");
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        public void muteUnmute(IntPtr handle)
        {
            SendMessageW(handle, WM_APPCOMMAND, handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        public void incrVolume(IntPtr handle)
        {
            SendMessageW(handle, WM_APPCOMMAND, handle, (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        public void decrVolume(IntPtr handle)
        {
            SendMessageW(handle, WM_APPCOMMAND, handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }
    }
}
