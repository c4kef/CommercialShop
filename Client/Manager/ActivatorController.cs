using System;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using Client.UI.Other;

namespace Client.Manager
{
    class ActivatorController
    {
        public static IntPtr m_WindowHandle;

        public static Process m_procClient;

        public static  bool m_isActive;
        public static bool m_isStart;

        private static string m_pMagazine;

        public static void InputData()
        {
            switch (Globals.m_AccountStore)
            {
                case "Steam":
                    Loading.GetInstance().SetProgressPercent(20);
                    FocusOnApp();
                    m_isActive = true;
                    Thread.Sleep(3_500);
                    SendKeys.SendWait(Globals.m_AccountLogin);
                    Loading.GetInstance().SetProgressPercent(40);
                    Thread.Sleep(3_500);
                    FocusOnApp();
                    SendKeys.SendWait("{TAB}");
                    Loading.GetInstance().SetProgressPercent(60);
                    Thread.Sleep(3_500);
                    FocusOnApp();
                    SendKeys.SendWait(Globals.m_AccountPassword);
                    Loading.GetInstance().SetProgressPercent(80);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{Enter}");
                    Loading.GetInstance().SetProgressPercent(100);
                    m_isActive = false;
                    break;
                case "UPlay":
                    FocusOnApp();
                    m_isActive = true;
                    Loading.GetInstance().SetProgressPercent(20);
                    Thread.Sleep(12_000);
                    SendKeys.SendWait(Globals.m_AccountLogin);
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(40);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{TAB}");
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(60);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait(Globals.m_AccountPassword);
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(75);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{TAB}");
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(85);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait(" ");
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(95);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{Enter}");
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(100);
                    m_isActive = false;
                    break;
                case "EpicGames":
                    WinAPI.MoveWindow(m_WindowHandle, 0, 0, 0, 0, true);
                    FocusOnApp();
                    m_isActive = true;
                    Loading.GetInstance().SetProgressPercent(10);
                    Thread.Sleep(15_000);
                    SendKeys.SendWait("{TAB}");
                    Loading.GetInstance().SetProgressPercent(15);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{TAB}");
                    Loading.GetInstance().SetProgressPercent(20);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{TAB}");
                    Loading.GetInstance().SetProgressPercent(25);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{Enter}");
                    Loading.GetInstance().SetProgressPercent(30);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{TAB}");
                    Loading.GetInstance().SetProgressPercent(35);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait($"{Globals.m_AccountLogin}");
                    Loading.GetInstance().SetProgressPercent(45);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{TAB}");
                    Loading.GetInstance().SetProgressPercent(50);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait($"{Globals.m_AccountPassword}");
                    Loading.GetInstance().SetProgressPercent(65);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{Enter}");
                    Loading.GetInstance().SetProgressPercent(75);
                    Thread.Sleep(6_000);
                    int countTry = 0;

                    try
                    {
                        if (File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EpicGamesLauncher\Saved\Logs\EpicGamesLauncher.log"))
                        {
                            back:
                            countTry++;

                            Thread.Sleep(3_000);

                            if (countTry > 3)
                                goto end;

                            using (var fs = new FileStream($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EpicGamesLauncher\Saved\Logs\EpicGamesLauncher.log", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                            using (var sr = new StreamReader(fs, System.Text.Encoding.Default))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                    if (line.Contains("FAccountService::OnLoginChanged - LoggedIn 0"))
                                        goto end;

                                goto back;
                            }
                        }
                    }
                    catch { }

                    Loading.GetInstance().SetProgressPercent(90);
                    Thread.Sleep(3_000);

                    end:
                    Loading.GetInstance().SetProgressPercent(100);
                    m_isActive = false;
                    break;
                case "Origin":
                    FocusOnApp();
                    m_isActive = true;
                    Loading.GetInstance().SetProgressPercent(10);
                    Thread.Sleep(15_000);
                    SendKeys.SendWait(Globals.m_AccountLogin);
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(40);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{TAB}");
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(50);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait(Globals.m_AccountPassword);
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(60);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{TAB}");
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(70);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait(" ");
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(80);
                    Thread.Sleep(3_500);
                    SendKeys.SendWait("{Enter}");
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(100);
                    m_isActive = false;
                    break;
                case "Microsoft":
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(10);
                    SendKeys.SendWait("{Enter}");
                    Thread.Sleep(2_000);
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(15);
                    SendKeys.SendWait("{Enter}");
                    Thread.Sleep(13_500);
                    m_WindowHandle = WinAPI.MicrosoftStoreWindow();
                    m_isActive = true;
                    Loading.GetInstance().SetProgressPercent(50);
                    Thread.Sleep(3_500);
                    FocusOnApp();
                    SendKeys.SendWait(Globals.m_AccountLogin);
                    Loading.GetInstance().SetProgressPercent(60);
                    Thread.Sleep(3_500);
                    FocusOnApp();
                    SendKeys.SendWait("{Enter}");
                    Loading.GetInstance().SetProgressPercent(70);
                    Thread.Sleep(3_500);
                    FocusOnApp();
                    SendKeys.SendWait(Globals.m_AccountPassword);
                    Loading.GetInstance().SetProgressPercent(80);
                    Thread.Sleep(3_500);
                    FocusOnApp();
                    SendKeys.SendWait("{Enter}");
                    Loading.GetInstance().SetProgressPercent(90);
                    Thread.Sleep(3_500);
                    FocusOnApp();
                    Loading.GetInstance().SetProgressPercent(100);
                    m_isActive = false;
                    break;
            }
        }

        public static void ControlOfInterceptions()
        {
            while (true)
            {
                if (m_isActive && (WinAPI.GetForegroundWindow() != m_WindowHandle))
                {
                    uint pid = 0;
                    WinAPI.GetWindowThreadProcessId(m_WindowHandle, out pid);

                    if (pid != 0 && Process.GetProcessById((int)pid) != null)
                        Process.GetProcessById((int)pid).Kill();

                    Environment.Exit(0);
                }

                Thread.Sleep(50);
            }
        }

        public static void TransferOffline()
        {
            try
            {
                bool check = false;
                while (true)
                {
                    if (!m_isStart)
                    {
                        Thread.Sleep(3_000);
                        continue;
                    }

                    if (Globals.m_AccountStore == "Steam")
                    {
                        if (WinAPI.RegistryValueExists(Registry.Users.OpenSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true), "AlreadyRetriedOfflineMode"))
                            Registry.Users.OpenSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true).SetValue("AlreadyRetriedOfflineMode", 1, RegistryValueKind.DWord);
                        else
                            Registry.Users.CreateSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true).SetValue("AlreadyRetriedOfflineMode", 1, RegistryValueKind.DWord);


                        if ((int)Registry.Users.OpenSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true).GetValue("RunningAppID") != 0)
                            check = true;

                        if (!check)
                        {
                            Thread.Sleep(3_000);
                            continue;
                        }

                        Thread.Sleep(50_000);

                        if (WinAPI.RegistryValueExists(Registry.Users.OpenSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true), "SteamPath"))
                            m_pMagazine = (string)Registry.Users.OpenSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true).GetValue("SteamPath");

                        string[] stuff = File.ReadAllLines($@"{m_pMagazine}\config\loginusers.vdf");
                        int min = 2;
                        int max = stuff.Length - 2;
                        for (int i = 0; i < stuff.Length; i++)
                            if (i >= min && i <= max)
                            {
                                if (stuff[i].Contains("SkipOfflineModeWarning") && stuff[i].Contains("0"))
                                    stuff[i] = $"        \"SkipOfflineModeWarning\"        \"1\"";
                                if (stuff[i].Contains("WantsOfflineMode") && stuff[i].Contains("0"))
                                    stuff[i] = $"		\"WantsOfflineMode\"		\"1\"";
                                if (i + 1 <= max && stuff[i + 1].Contains("}") && (!stuff[i].Contains("WantsOfflineMode") && !stuff[i].Contains("SkipOfflineModeWarning")))
                                    stuff[i] = $"{stuff[i]}\n		\"WantsOfflineMode\"		\"1\"\n        \"SkipOfflineModeWarning\"        \"1\"";
                            }
                        File.WriteAllLines($@"{m_pMagazine}\config\loginusers.vdf", stuff);
                        Thread.Sleep(500);
                        WinAPI.KillTree(Process.GetProcessesByName("Steam")[0].Id);
                        break;
                    }
                    else if (Globals.m_AccountStore == "UPlay")
                    {
                        Process[] process = Process.GetProcesses();
                        foreach (var proc in process)
                            try
                            {
                                if (proc.MainWindowHandle == IntPtr.Zero || !proc.Parent().ProcessName.Contains("Ubisoft"))
                                    continue;

                                m_procClient = proc;
                                check = true;
                                break;
                            }
                            catch
                            {
                                continue;
                            }

                        if (!check)
                        {
                            Thread.Sleep(3_000);
                            continue;
                        }

                        Thread.Sleep(50_000);

                        m_procClient?.Kill();

                        string[] stuff = File.ReadAllLines($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Ubisoft Game Launcher\settings.yml");
                        int min = 2;
                        int max = stuff.Length - 2;
                        for (int i = 0; i < stuff.Length; i++)
                            if (i >= min && i <= max)
                            {
                                if (stuff[i].Contains("forceoffline") && stuff[i].Contains("false"))
                                    stuff[i] = $"  forceoffline: true";
                            }
                        File.WriteAllLines($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Ubisoft Game Launcher\settings.yml", stuff);
                        Thread.Sleep(500);
                        Process.GetProcessesByName("upc")[0].Kill();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Globals.Log(ex);
            }
        }

        public static bool FindWindow()
        {
            try
            {
                Process[] process = Process.GetProcesses();
                foreach (var proces in process)
                    switch (Globals.m_AccountStore)
                    {
                        case "Steam":
                            if (proces.MainWindowHandle != IntPtr.Zero && (proces.MainWindowTitle.Contains(" Steam") || proces.MainWindowTitle.Contains("Steam") || proces.MainWindowTitle.Contains("Steam ")))
                            {
                                if (!proces.MainModule.FileName.ToLower().Contains("steam.exe"))
                                    continue;

                                string path = proces.MainModule.FileName;
                                proces.Kill();

                                Thread.Sleep(6_000);

                                if (WinAPI.RegistryValueExists(Registry.Users.OpenSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true), "AutoLoginUser"))
                                    Registry.Users.OpenSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true).SetValue("AutoLoginUser", string.Empty, RegistryValueKind.String);
                                else
                                    Registry.Users.CreateSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true).SetValue("AutoLoginUser", string.Empty, RegistryValueKind.String);

                                if (WinAPI.RegistryValueExists(Registry.Users.OpenSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true), "RememberPassword"))
                                    Registry.Users.OpenSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true).SetValue("RememberPassword", 1, RegistryValueKind.DWord);
                                else
                                    Registry.Users.CreateSubKey($@"{Globals.m_sidClient}\Software\Valve\Steam", true).SetValue("RememberPassword", 1, RegistryValueKind.DWord);

                                Process.Start(path);

                                Thread.Sleep(5_000);

                                bool work = true;

                                while (work)
                                {
                                    process = Process.GetProcesses();
                                    foreach (var processs in process)
                                        if (processs.MainWindowHandle != IntPtr.Zero && (processs.MainWindowTitle.Contains(" Steam") || processs.MainWindowTitle.Contains("Steam") || processs.MainWindowTitle.Contains("Steam ")))
                                        {
                                            if (!processs.MainModule.FileName.ToLower().Contains("steam.exe"))
                                                continue;
                                            m_pMagazine = processs.MainModule.FileName.Remove(processs.MainModule.FileName.Length - 10, 10);
                                            m_WindowHandle = processs.MainWindowHandle;
                                            m_procClient = processs;
                                            work = false;
                                            break;
                                        }
                                }
                                return true;
                            }
                            break;
                        case "UPlay":
                            if (proces.MainWindowHandle != IntPtr.Zero && proces.MainWindowTitle.ToLower().Contains("ubisoft connect"))
                            {
                                string path = proces.MainModule.FileName;
                                string folderPath = proces.MainModule.FileName.Remove(proces.MainModule.FileName.Length - 8, 8);
                                proces.Kill();

                                Thread.Sleep(6_000);

                                WinAPI.SafeDeleteDirs($@"{folderPath}\cache");

                                string[] stuff = File.ReadAllLines($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Ubisoft Game Launcher\settings.yml");
                                int min = 0;
                                int max = stuff.Length;
                                for (int i = 0; i < stuff.Length; i++)
                                    if (i >= min && i <= max)
                                    {
                                        if (stuff[i].Contains("synucsavegames"))
                                            stuff[i] = $"  syncsavegames: false";
                                        else if (stuff[i].Contains("spotlight"))
                                            stuff[i + 1] = $"  enabled: false";
                                        else if (stuff[i].Contains("autoPatching"))
                                            stuff[i + 1] = $"  enabled: false";
                                        else if (stuff[i].Contains("pauseOnGameLaunch"))
                                            stuff[i] = $"  pauseOnGameLaunch: false";
                                        else if (stuff[i].Contains("password:"))
                                            stuff[i] = $"  password: \"\"";
                                    }

                                File.WriteAllLines($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Ubisoft Game Launcher\settings.yml", stuff);

                                Process.Start(path);

                                bool work = true;
                                while (work)
                                {
                                    process = Process.GetProcesses();
                                    foreach (var processs in process)
                                        if (processs.MainWindowHandle != IntPtr.Zero && processs.MainWindowTitle.ToLower().Contains("ubisoft connect"))
                                        {
                                            m_WindowHandle = processs.MainWindowHandle;
                                            m_procClient = processs;
                                            work = false;
                                            break;
                                        }
                                }

                                return true;
                            }
                            break;
                        case "EpicGames":
                            if (proces.MainWindowHandle != IntPtr.Zero && (proces.ProcessName.Contains("Epic Games") || proces.ProcessName.Contains("EpicGames")))
                            {
                                if (!proces.MainModule.FileName.ToLower().Contains("epicgameslauncher"))
                                    continue;

                                string path = proces.MainModule.FileName;
                                proces.Kill();

                                Thread.Sleep(6_000);

                                if (Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EpicGamesLauncher"))
                                    WinAPI.SafeDeleteDirs($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EpicGamesLauncher");

                                Process.Start(path);

                                bool work = true;
                                while (work)
                                {
                                    process = Process.GetProcesses();
                                    foreach (var processs in process)
                                        if (processs.MainWindowHandle != IntPtr.Zero && (processs.ProcessName.Contains("Epic Games") || processs.ProcessName.Contains("EpicGames")))
                                        {
                                            if (!processs.MainModule.FileName.ToLower().Contains("epicgameslauncher"))
                                                continue;

                                            m_WindowHandle = processs.MainWindowHandle;
                                            m_procClient = processs;
                                            work = false;
                                            break;
                                        }
                                }
                                return true;
                            }
                            break;
                        case "Origin":
                            if (proces.MainWindowHandle != IntPtr.Zero && (proces.ProcessName.ToLower().Contains("origin")))
                            {
                                if (!proces.MainModule.FileName.Contains("Origin"))
                                    continue;

                                string path = proces.MainModule.FileName;
                                proces.Kill();

                                Thread.Sleep(6_000);

                                if (Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Origin"))
                                    WinAPI.SafeDeleteDirs($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Origin");

                                Process.Start(path);

                                Thread.Sleep(5_000);

                                bool work = true;

                                while (work)
                                {
                                    process = Process.GetProcesses();
                                    foreach (var processs in process)
                                        if (processs.MainWindowHandle != IntPtr.Zero && (processs.ProcessName.ToLower().Contains("origin")))
                                        {
                                            if (!processs.MainModule.FileName.Contains("Origin.exe"))
                                                continue;

                                            m_WindowHandle = processs.MainWindowHandle;
                                            m_procClient = processs;
                                            work = false;
                                            break;
                                        }
                                }
                                return true;
                            }
                            break;
                        case "Microsoft":
                            foreach (var handle in new WindowControl(proces.MainWindowHandle).GetAllChildHandles())
                            {
                                if (WinAPI.GetText(handle) == string.Empty || !(
                                    WinAPI.GetText(handle) == "Войти"
                                    || WinAPI.GetText(handle) == "Sign in"
                                    || WinAPI.GetText(handle) == "Кіру"
                                    || WinAPI.GetText(handle) == "Вхід"
                                    || WinAPI.GetText(handle) == "Увайсці"
                                    || WinAPI.GetText(handle) == "Anmelden"
                                    || WinAPI.GetText(handle) == "Oturum aç"
                                    || WinAPI.GetText(handle) == "Iniciar sessão"
                                    || WinAPI.GetText(handle) == "Accedi"
                                    || WinAPI.GetText(handle) == "Iniciar sesión"
                                    || WinAPI.GetText(handle) == "Se connecter"
                                    || WinAPI.GetText(handle) == "Aanmelden"
                                    || WinAPI.GetText(handle) == "登录"
                                    || WinAPI.GetText(handle) == "登入"
                                    || WinAPI.GetText(handle) == "Přihlásit se"
                                    || WinAPI.GetText(handle) == "Logg på"
                                    || WinAPI.GetText(handle) == "Logga in"
                                    || WinAPI.GetText(handle) == "Zaloguj się"
                                    || WinAPI.GetText(handle) == "Pierakstīties"
                                    || WinAPI.GetText(handle) == "Sisselogimine"
                                    || WinAPI.GetText(handle) == "로그인"
                                    || WinAPI.GetText(handle) == "サインイン"
                                    || WinAPI.GetText(handle) == "Conectare"
                                    || WinAPI.GetText(handle) == "ลงชื่อเข้าใช้"
                                    || WinAPI.GetText(handle) == "تسجيل الدخول"
                                    ))
                                    continue;

                                m_WindowHandle = handle;
                                FocusOnApp();
                                return true;
                            }
                            break;
                    }
                return false;
            }
            catch (Exception ex)
            {
                Globals.Log(ex);
                return false;
            }
        }

        public static void FocusOnApp()
        {
            if (m_WindowHandle == IntPtr.Zero)
                return;

            WinAPI.SetCenter(m_WindowHandle);
            WinAPI.ShowWindow(m_WindowHandle, 9);
            WinAPI.SetForegroundWindow(m_WindowHandle);
        }

        public static void Dispose()
        {
            m_WindowHandle = IntPtr.Zero;
            
            m_procClient?.Dispose();

            m_procClient = null;

            m_isActive = m_isStart = false;

            m_pMagazine = string.Empty;
        }
    }
}
