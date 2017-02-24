using System;
using System.Diagnostics;
using System.Threading;

namespace Loader
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                Process p = new Process();
                p.StartInfo.FileName = "v2ray.exe";
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                EventWaitHandle signal = new EventWaitHandle(false, EventResetMode.AutoReset, "MyV2rayLoader");
                signal.WaitOne();
                p.Kill();
            }
            else
            {
                EventWaitHandle signal = new EventWaitHandle(false, EventResetMode.AutoReset, "MyV2rayLoader");
                signal.Set();
            }
        }
    }
}
