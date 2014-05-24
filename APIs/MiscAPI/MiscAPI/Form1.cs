using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MiscAPI
{
    public partial class frmMain : Form
    {
        public const String TASK_MANAGER = "taskmgr.exe";
        public const String CALCULATOR = "calc.exe";
        public const String COMMAND_PROMPT = "cmd.exe";
        public const String NOTEPAD = "notepad.exe";
        public const String INTERNET = "www.google.co.in";

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTaskMgr_Click(object sender, EventArgs e)
        {
            Process.Start(TASK_MANAGER);
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            Process.Start(COMMAND_PROMPT);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Process.Start(CALCULATOR);
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Process.Start(NOTEPAD);
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            Process.Start(INTERNET);
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown","-s -t 60");
            if (MessageBox.Show("System will shutdown in a minute.\nDo you want to cancel?", "Shutdown",MessageBoxButtons.YesNo) == DialogResult.Yes)
                Process.Start("shutdown", "-a");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown","-r -t 60");
            if (MessageBox.Show("System will restart in a minute.\nDo you want to cancel?", "Restart", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Process.Start("shutdown", "-a");
        }

        private void btnHibernate_Click(object sender, EventArgs e)
        {
            Process.Start("powercfg", "-hibernate on");
            Process.Start("rundll32.exe", "PowrProf.dll,SetSuspendState");
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            Process.Start("powercfg", "-hibernate off");
            Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState 0,1,0");
            Process.Start("powercfg", "-hibernate on");
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,IntPtr wParam, IntPtr lParam);

        private void btnMuteUnmute_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void btnIncrVol_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void btnDecrVol_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }
    }
}
