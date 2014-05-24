using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SwitchWindows
{
    public class switchwin
    {
        public struct proStruct
        {
            public String prName;
            public long prID;
        };
       
        public int proNum;
        public proStruct[] procArray;
        
        public proStruct[] getAllWindowNames()
        {
            int count=0;
            Process[] pArray = Process.GetProcesses();
            proStruct[] nPro = new proStruct[pArray.Length];
            foreach (Process nProc in pArray)
            {
                if (nProc.MainWindowTitle.ToString() != String.Empty)
                {
                    nPro[count].prName = nProc.MainWindowTitle.ToString();
                    nPro[count++].prID = nProc.Id;
                }
            }
            proNum = count;
            return nPro;
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);
        
        public void switchWindow(int windowNumber)
        {
            long PID = procArray[windowNumber].prID;
            Process tempProc = Process.GetProcessById(Convert.ToInt32(PID));
            SwitchToThisWindow(tempProc.MainWindowHandle, true);
        }
    }
}
