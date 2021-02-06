using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Globalization;
using System.Net;
using Newtonsoft.Json;
using Client.UI.Other;
using System.Text;

namespace Client.Manager
{
    class Globals
    {
        public static Color colorYellow = Color.FromArgb(191, 142, 27);
        public static Color colorDarkBlue = Color.FromArgb(24, 49, 91);
        public static Color colorBlue = Color.FromArgb(0, 82, 223);
        public static Color colorBlack = Color.FromArgb(32, 32, 32);
        public static Color colorRed = Color.FromArgb(183, 47, 79);
        public static Color colorGreen = Color.FromArgb(47, 183, 119);
        public static Color colorGrey = Color.FromArgb(112, 112, 112);

        public static bool m_CanCloseApp = true;

        public static InterfaceTranslation m_Interface { get; private set; }

        public static SQLRequests m_sqlRequests;

        public static Image m_logoApp;

        public static string m_versionServer = "Vers_2.0.0S";
        public static string m_versionLanguage = "Vers_1.0.0R";
        public static string m_linkServer = "https://xremote.000webhostapp.com";
        public static string m_linkVersion = $"{Globals.m_linkServer}/version_check.php";
        public static string m_linkKeyCheck = $"{Globals.m_linkServer}/key_check.php";

        public static string m_linkToRussian = $"{Globals.m_linkServer}/Languages/Russian.json";
        public static string m_linkToEnglish = $"{Globals.m_linkServer}/Languages/English.json";

        public static string m_pathToConfig = $"config.cfg";

        public static string m_pathToLog = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Error.log";
        public static string m_pathToLanguage = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Templates)}\Language.json";

        public static string m_MailLogin;
        public static string m_MailPassword;
        public static string m_MailServer;

        public static string m_AccountStore;
        public static string m_AccountLogin;
        public static string m_AccountPassword;

        public static string m_userHello;
        public static string m_sidClient;
        public static Image m_userIcon;

        public static void PreparingInterface()
        {
            if (Main.GetInstance() is null)
                goto Admin;

            //Main
            Main.GetInstance().toolTip.SetToolTip(Main.GetInstance().btnConnection, m_Interface.m_mainBtnTooltipConnection);
            Main.GetInstance().toolTip.SetToolTip(Main.GetInstance().btnInfo, m_Interface.m_mainBtnTooltipInfo);
            Main.GetInstance().toolTip.SetToolTip(Main.GetInstance().btnActivation, m_Interface.m_mainBtnTooltipActivation);
            Main.GetInstance().toolTip.SetToolTip(Main.GetInstance().hideBtn, m_Interface.m_btnTooltipHide);
            Main.GetInstance().notify.BalloonTipText = m_Interface.m_mainBalloonTipText;
            Main.GetInstance().notify.BalloonTipTitle = m_Interface.m_mainBalloonTipTitle;
            Main.GetInstance().notify.Text = m_Interface.m_mainTooltipText;
            Main.GetInstance().Text = m_Interface.m_mainFormText;

            //Main -> Activation 
            Main.GetInstance().activation1.btnSendKey.Text = m_Interface.m_activationBtnSendKeyText;
            Main.GetInstance().activation1.inputKeyText.PlaceholderText = m_Interface.m_activationInputKeyPlaceholderText;
            Main.GetInstance().activation1.inputKeyText.TextPlaceholder = m_Interface.m_activationInputKeyPlaceholderText;
            Main.GetInstance().activation1.copyCodeFromMail.Text = m_Interface.m_activationBtnCopyCodeFromMailText;
            Main.GetInstance().activation1.copyMail.Text = m_Interface.m_activationBtnCopyMailText;

            //Main -> Awake
            Main.GetInstance().awake1.pleaseWait.Text = m_Interface.m_awakeLabelWait;

            //Main -> Info
            Main.GetInstance().info1.labelInfo.Text = m_Interface.m_infoLabelInfo;
            Main.GetInstance().info1.labelContacts.Text = m_Interface.m_infoLabelContacts;

            Admin:

            if (Admin.GetInstance() is null)
                goto Loading;

            //Admin
            Admin.GetInstance().toolTip.SetToolTip(Admin.GetInstance().hideBtn, m_Interface.m_btnTooltipHide);
            Admin.GetInstance().Text = m_Interface.m_adminFormText;

            //Admin -> Account
            Admin.GetInstance().a_Account1.inputPasswordAccount.PlaceholderText = m_Interface.m_adminAccountPasswordPlaceholderText;
            Admin.GetInstance().a_Account1.inputPasswordAccount.TextPlaceholder = m_Interface.m_adminAccountPasswordPlaceholderText;
            Admin.GetInstance().a_Account1.inputLoginAccount.PlaceholderText = m_Interface.m_adminAccountLoginPlaceholderText;
            Admin.GetInstance().a_Account1.inputLoginAccount.TextPlaceholder = m_Interface.m_adminAccountLoginPlaceholderText;
            Admin.GetInstance().a_Account1.inputCountKeys.PlaceholderText = m_Interface.m_adminAccountCountPlaceholderText;
            Admin.GetInstance().a_Account1.inputCountKeys.TextPlaceholder = m_Interface.m_adminAccountCountPlaceholderText;

            //Admin -> Mail
            Admin.GetInstance().a_Mail1.inputServerMail.PlaceholderText = m_Interface.m_adminMailServerPlaceholderText;
            Admin.GetInstance().a_Mail1.inputServerMail.TextPlaceholder = m_Interface.m_adminMailServerPlaceholderText;
            Admin.GetInstance().a_Mail1.inputPasswordMail.PlaceholderText = m_Interface.m_adminMailPasswordPlaceholderText;
            Admin.GetInstance().a_Mail1.inputPasswordMail.TextPlaceholder = m_Interface.m_adminMailPasswordPlaceholderText;
            Admin.GetInstance().a_Mail1.inputLoginMail.PlaceholderText = m_Interface.m_adminMailLoginPlaceholderText;
            Admin.GetInstance().a_Mail1.inputLoginMail.TextPlaceholder = m_Interface.m_adminMailLoginPlaceholderText;

            //Admin -> Data Send
            Admin.GetInstance().a_SendData1.labelDataSend.Text = m_Interface.m_adminDataSendLabelDataLoad;

            //Admin -> Choose Store
            Admin.GetInstance().a_ChooseStore1.dropdownStore.Text = m_Interface.m_adminChooseStoreDropdownText;

            Loading:

            //Loading
            Loading.GetInstance().Text = m_Interface.m_loadingTextForm;
        }

        public static void InitLanguage()
        {
            if (File.Exists(m_pathToLanguage) && File.ReadAllText(m_pathToLanguage).Contains(m_versionLanguage))
                goto init;

            string language = CultureInfo.InstalledUICulture.Name;
            WebClient wClient = new WebClient();

            if (language == "ru-RU")
                wClient.DownloadFile(m_linkToRussian, m_pathToLanguage);
            else
                wClient.DownloadFile(m_linkToEnglish, m_pathToLanguage);

            init:
            m_Interface = JsonConvert.DeserializeObject<InterfaceTranslation>(File.ReadAllText(m_pathToLanguage));
        }

        public static void Log(Exception ex)
        {
            StringBuilder logInformation = new StringBuilder();
            logInformation.AppendLine($"DO NOT CHANGE THE FILE!\n");
            logInformation.AppendLine($"System information:");
            logInformation.AppendLine($"Size screen: {SystemInformation.PrimaryMonitorSize.Width}x{SystemInformation.PrimaryMonitorSize.Height}");
            logInformation.AppendLine($"Debug OS: {SystemInformation.DebugOS}");
            logInformation.AppendLine($"OS: {CSystem.GetOSInfo()}");
            logInformation.AppendLine($"Processor: {Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")}");
            logInformation.AppendLine($"RAM Size: {CSystem.GetRamSize() / 1_000_000_000 - 1}GB");
            logInformation.AppendLine("\nError info:");
            logInformation.AppendLine(ex.Message);

            File.WriteAllText(m_pathToLog, logInformation.ToString());
            MessageBox.Show(m_Interface?.m_errorMessage ?? "A critical error has occurred, the log has been created on the desktop.");
        }
    }
}
