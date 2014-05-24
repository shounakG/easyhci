using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using SHDocVw;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ShellWindows sw = new ShellWindows();

        const int WM_SYSCOMMAND = 274;
        const int SC_MINIMIZE = 0xF020;
        const int SC_MAXIMIZE = 0xF030;
        const int SC_CLOSE = 0xF060;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (InternetExplorer window in sw)
            {
                if (!window.Path.Contains("Internet Explorer"))
                {
                    listBox1.Items.Add(window.LocationName);
                    listBox2.Items.Add(window.LocationURL);
                    listBox3.Items.Add(window.HWND);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr p = new IntPtr((Int32)listBox3.SelectedItem);
            SendMessage(p,WM_SYSCOMMAND,SC_CLOSE,0);
            int index = listBox3.SelectedIndices[0];
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);
            listBox3.Items.RemoveAt(index);
        }
    }
}
