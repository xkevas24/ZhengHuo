using System.Diagnostics;
using System.Linq;

namespace ZhengHuo
{
    class ProcessHelper
    {
        public static string GetProcessPathByName(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            var process = processes.FirstOrDefault();
            var path = process?.MainModule?.FileName;
            return path;
        }

        public static int GetProcessIdByName(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            var process = processes.FirstOrDefault();
            int id = 0;
            if (process != null)
            {
                id = process.Id;
            }
            return id;
        }

    }
}
