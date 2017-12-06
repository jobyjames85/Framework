using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Helpers
{
    /// <summary>
    /// Represent the MemoryManagement
    /// </summary>
    public class MemoryManagement
    {
        /// <summary>
        /// Flush System Memory
        /// </summary>
        public static void FlushMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        /// <summary>
        /// SetProcess WorkingSetSize
        /// </summary>
        /// <param name="process">Application Process</param>
        /// <param name="minimumWorkingSetSize">MinimumWorking SetSize</param>
        /// <param name="maximumWorkingSetSize">MaximumWorking SetSize</param>
        /// <returns>Return Value</returns>
        [DllImportAttribute("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);
    }
}
