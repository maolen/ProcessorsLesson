using System;
using System.Diagnostics;

namespace ProcessorsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("notepad");

            var currentProcess = Process.GetCurrentProcess();
            Console.WriteLine($"{currentProcess.Id} - {currentProcess.ProcessName}");
            currentProcess.Kill();

            var chromeProcesses = Process.GetProcessesByName("chrome");
            foreach (var chrome in chromeProcesses)
            {
                chrome.Kill();
            }
        }
    }
}
