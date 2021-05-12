using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Manager;

namespace Client.UI.Other.UIComps
{
    public partial class A_SendData : UserControl
    {
        public delegate void m_DataSendedStatus(Exception ex);
        public event m_DataSendedStatus DataSendedStatus;

        private int percent;
        private SaveFileDialog fileDialog;

        public A_SendData()
        {
            InitializeComponent();

            fileDialog = new SaveFileDialog();
        }

        public void SendData()
        {
            progressValue.Maximum = int.Parse(Admin.GetInstance().a_Count);

            timer.Interval = 30;
            timer.Start();

            Task.Run(new Action(() =>
            {
                try
                {

                    fileDialog.Filter = Globals.m_Interface.m_adminSaveAccount;

                    Invoke(new Action(() =>
                        {
                            back:
                            if (fileDialog.ShowDialog() != DialogResult.OK)
                                goto back;
                        }));

                    string path = fileDialog.FileName;
                    File.WriteAllText(path, $"Offline activator keys\nBy C4ke\nCurrent store: {Admin.GetInstance().a_Store}\n");

                    for (int i = 0; i < int.Parse(Admin.GetInstance().a_Count); i++)
                    {
                        string keyID = CSystem.RandomString(5, 5);

                        Globals.m_sqlRequests.GetAnswer($"INSERT INTO `KeysActivation`(`KeyActivation`, `Software`, `Date`, `Login`, `Password`, `Magazine`, `MLogin`, `MPass`, `MServ`) VALUES (\"{keyID}\", \"-\", \"-\", \"{Admin.GetInstance().a_Login}\", \"{Admin.GetInstance().a_Password}\", \"{Admin.GetInstance().a_Store}\", \"{Admin.GetInstance().a_MailLogin}\", \"{Admin.GetInstance().a_MailPassword}\", \"{Admin.GetInstance().a_MailServer}\")");
                        File.AppendAllText(path, $"\nID Key: {keyID}    Login: {Admin.GetInstance().a_Login}   Password: {Admin.GetInstance().a_Password}");

                        percent = i + 1;

                        Thread.Sleep(1);
                    }

                    File.AppendAllText(path, $"\n\nCount {Admin.GetInstance().a_Count} keys");

                    wait:

                    if (progressValue.Value != percent)
                    {

                        BeginInvoke(new Action(() => timer.Interval = 5));
                        Thread.Sleep(50);

                        goto wait;
                    }

                    BeginInvoke(new Action(() => timer.Stop()));

                    DataSendedStatus?.Invoke(null);
                }
                catch (Exception ex)
                {
                    timer.Stop();
                    DataSendedStatus?.Invoke(ex);
                }
            }));
        }

        public void SetProgressPercent(int percent) => this.percent = percent;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressValue.Value < percent)
                progressValue.Value += 1;
            else if (progressValue.Value > percent)
                progressValue.Value -= 1;
        }
    }
}
