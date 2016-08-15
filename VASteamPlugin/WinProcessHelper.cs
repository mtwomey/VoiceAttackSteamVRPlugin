using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WinProcess
{
    static class WinProcessHelper
    {

        public static void closeAllByName(string processName)
        {
            Process[] processes;
            processes = Process.GetProcessesByName(processName);
            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                process.WaitForExit();
            }
        }

        public static void killAllByName(string processName)
        {
            Process[] processes;
            processes = Process.GetProcessesByName(processName);
            foreach (Process process in processes)
            {
                process.Kill();
                process.WaitForExit();
            }
        }

        public static void waitForExit(string processName)
        {
            Process[] processes;
            processes = Process.GetProcessesByName(processName);
            foreach (Process process in processes)
            {
                process.WaitForExit();
            }
        }
    }
}
