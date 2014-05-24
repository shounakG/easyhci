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

namespace winAPIClose
{
    public partial class frmMain : Form
    {
        Process[] processes;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            buildList();
        }

        private void buildList()
        {
            int count = 0;
            lstProcesses.Items.Clear();
            ListViewItem lstItem;
            processes = Process.GetProcesses();
            foreach (Process proc in processes)
            {
                if(proc.MainWindowTitle.ToString() != String.Empty )
                {
                    count++;
                    lstItem = lstProcesses.Items.Add(proc.MainWindowTitle.ToString());
                    lstItem.SubItems.Add(proc.Id.ToString());
                }
            }
            MessageBox.Show(count.ToString());
        }

        private void lstProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        [DllImport("user32.dll", SetLastError=true)]
        static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Process.GetProcessesByName(lstProcesses.SelectedItems[0].Text)[0].MainWindowTitle);
            long PID;
            if (lstProcesses.SelectedItems.Count == 1)
            {
                PID = (long)Convert.ToInt64(lstProcesses.SelectedItems[0].SubItems[1].Text);
                Process tempProc = Process.GetProcessById(Convert.ToInt32(PID));
                SwitchToThisWindow(tempProc.MainWindowHandle, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long PID;
            if (lstProcesses.SelectedItems.Count == 1)
            {
                PID = (long)Convert.ToInt64(lstProcesses.SelectedItems[0].SubItems[1].Text);
                Process tempProc = Process.GetProcessById(Convert.ToInt32(PID));
                tempProc.Kill();
                buildList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getAllWindowNames().ToString());
        }
       
        public int getAllWindowNames()
        {
            int count = 0;
            String[] strProcess = new String[Process.GetProcesses().Length];
            Process[] pArray = Process.GetProcesses();
            foreach (Process nProc in pArray)
            {
                if (!String.IsNullOrEmpty(nProc.MainWindowTitle.ToString()))
                {
                    strProcess[count++] = nProc.MainWindowTitle.ToString();
                }
            }
            return strProcess.Length;
        }
    }
}
