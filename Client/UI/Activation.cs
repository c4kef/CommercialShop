using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Manager;
using Client.UI.Other;

namespace Client.UI
{
    public partial class Activation : UserControl
    {
        private bool isBusy;

        public Activation()
        {
            InitializeComponent();
        }

        private void btnSendKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputKeyText.Text.Length != 10 || isBusy)
                    return;

                ActivatorController.Dispose();

                copyMail.Visible = false;
                copyCodeFromMail.Visible = false;

                isBusy = true;

                WebRequests request = new WebRequests(Globals.m_linkKeyCheck);

                request.Add("KeyActivation", inputKeyText.Text, true);
                request.Add("Software", CSystem.GetHashedDisk().ToString());

                string[] answer = request.Send(true).Split('|');

                request.Clear();

                if (answer[0] == "Err")
                {
                    MessageBox.Show(Globals.m_Interface.m_incorrectKey);
                    goto end;
                }
                else if (answer.Length < 3)
                {
                    MessageBox.Show(Globals.m_Interface.m_incorrectAnswer);
                    goto end;
                }

                Globals.m_AccountLogin = answer[1];
                Globals.m_AccountPassword = answer[2];
                Globals.m_AccountStore = answer[3];
                Globals.m_MailLogin = answer[4];
                Globals.m_MailPassword = answer[5];
                Globals.m_MailServer = answer[6];

                Loading.GetInstance().Show();
                Loading.GetInstance().Hide();

                Task.Run(new Action(() =>
                {
                    try
                    {
                        if (ActivatorController.FindWindow())
                        {
                            Invoke(new Action(() => Main.GetInstance().Hide()));

                            Invoke(new Action(() => Loading.GetInstance().progressValue.Value = 0));

                            Globals.m_CanCloseApp = false;

                            Task.Run(ActivatorController.TransferOffline);

                            WinAPI.SetCenter(ActivatorController.m_WindowHandle);

                            Invoke(new Action(() => Loading.GetInstance().Show()));

                            ActivatorController.InputData();

                            Globals.m_CanCloseApp = true;

                            Invoke(new Action(() =>
                            {
                                if (Globals.m_AccountStore != "Microsoft")
                                    ActivatorController.m_isStart = true;
                                else
                                {
                                    copyMail.Visible = true;
                                    copyCodeFromMail.Visible = true;
                                }

                                Loading.GetInstance().Close(5_000);
                                WinAPI.ShowWindow(Main.GetInstance().Handle, 9);
                                WinAPI.SetForegroundWindow(Main.GetInstance().Handle);
                                Main.GetInstance().Show();
                            }));
                            isBusy = false;
                        }
                        else
                        {
                            MessageBox.Show(Globals.m_Interface.m_windowNotFound);
                            isBusy = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() =>
                        {
                            Main.GetInstance().Show();
                            Loading.GetInstance().Hide();
                        }));
                        Globals.Log(ex);
                    }
                }));

                goto finaly;

                end:
                isBusy = false;

                finaly:
                return;
            }
            catch (Exception ex)
            {
                Globals.Log(ex);
            }
        }

        private void inputKeyText_TextChanged(object sender, EventArgs e) => checkCorrectInput.LineColor = inputKeyText.Text.Length >= 10 ? Globals.colorGreen : Globals.colorRed;

        private void copyCodeFromMail_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(EMail.GetMailCode());
                MessageBox.Show(Globals.m_Interface.m_copiedMailCode, Globals.m_Interface.m_successful);
            }
            catch (Exception ex)
            {
                Globals.Log(ex);
            }
        }

        private void copyMail_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Globals.m_MailLogin);
                MessageBox.Show(Globals.m_Interface.m_copiedMail, Globals.m_Interface.m_successful);
            }
            catch (Exception ex)
            {
                Globals.Log(ex);
            }
        }
    }
}
