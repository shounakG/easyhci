using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace AllExplorerWindowOperations
{
    public class windowOperations
    {
        const int WM_SYSCOMMAND = 274;
        const int SC_MINIMIZE = 0xF020;
        const int SC_MAXIMIZE = 0xF030;
        const int SC_CLOSE = 0xF060;

        delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn, IntPtr lParam);

        static IEnumerable<IntPtr> EnumerateProcessWindowHandles(int processID)
        {
            List<IntPtr> handles = new List<IntPtr>();

            EnumThreadDelegate addWindowHandle = delegate(IntPtr hWnd, IntPtr param)
            {
                string className = GetDaClassName(hWnd);        //hWnd is the handle to a window. A handle is an abstract reference to a resource
                //Every hWnd is a handle, but not every handle is a hWnd

                switch (className)
                {
                    case null:
                        break;
                    case "ExploreWClass":                   //if the folder tree view is enabled, i.e if the explorer is opened by winkey+E or from start, we get the ExploreWClass, else CabinetWClass
                        handles.Add(hWnd);
                        break;
                    case "CabinetWClass":
                        handles.Add(hWnd);
                        break;
                    default:
                        break;
                }

                return true;
            };

            foreach (ProcessThread thread in Process.GetProcessById(processID).Threads)
                EnumThreadWindows(thread.Id, addWindowHandle, IntPtr.Zero);

            return handles;
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);      //Retrieves the name of the class to which the specified window belongs.

        static string GetDaClassName(IntPtr hWnd)
        {
            int nRet;
            StringBuilder ClassName = new StringBuilder(100);
            //Get the window class name
            nRet = GetClassName(hWnd, ClassName, ClassName.Capacity);
            if (nRet != 0)
            {
                return ClassName.ToString();
            }
            else
            {
                return null;
            }
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        public void performWindowOperations(int opIdentifier)
        {
            foreach (IntPtr handle in EnumerateProcessWindowHandles(Process.GetProcessesByName("explorer")[0].Id))
            {
                SendMessage(handle, WM_SYSCOMMAND, opIdentifier, 0);
            }
        }
    }
}
