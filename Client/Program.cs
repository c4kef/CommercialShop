using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Security.Principal;
using Client.UI.Other;
using Client.Manager;

namespace Client
{
    static class Program
    {
        [STAThread]
        static void Main(string[] arg)
        {
            try
            {
                foreach (var proc in Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName))
                    if (proc.Id != Process.GetCurrentProcess().Id)
                        proc.Kill();

                Globals.m_sidClient = WindowsIdentity.GetCurrent().User.Value;

                if (Globals.m_sidClient.Length < 3)
                {
                    Globals.Log(new Exception("Can't get client's SID..."));
                    Environment.Exit(0);
                }

                Globals.InitLanguage();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (arg.Length == 0)
                    Application.Run(new Main());
                else if (arg[0] == "-admin")
                    Application.Run(new Admin());
            }
            catch (Exception ex)
            {
                Globals.Log(ex);
                Environment.Exit(0);
            }
        }
    }
}
