using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Client.Manager;
using Client.UI.Other.UIComps;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using System.Threading.Tasks;

namespace Client.UI.Other
{
    public partial class Admin : Form
    {
        private static Admin m_Instance;

        private List<Control> uiControls;
        private BunifuTransition transition;
        private Animation[] animations;
        private Control currentControl;

        private int currentStep;

        public string a_Count;
        public string a_Login;
        public string a_Password;
        public string a_Store;
        public string a_MailLogin;
        public string a_MailPassword;
        public string a_MailServer;

        public Admin()
        {
            try
            {
                Globals.PreparingInterface();

                if (!File.Exists(Globals.m_pathToConfig))
                {
                    MessageBox.Show(Globals.m_Interface.m_adminConfigNotFound);
                    Environment.Exit(0);
                }

                InitializeComponent();

                m_Instance = this;

                uiControls = new List<Control>();
                transition = new BunifuTransition();
                animations = new Animation[2];

                //Slide to down
                animations[0] = Animation.VertSlide;
                animations[0].SlideCoeff = new PointF(0, -1.5f);

                //Slide to up
                animations[1] = Animation.VertSlide;
                animations[1].SlideCoeff = new PointF(0, 1.5f);

                Globals.m_userHello = $"{CSystem.GetTime()}, {Environment.UserName}";
                Globals.m_userIcon = CSystem.GetUserTile(Environment.UserName);

            }
            catch (Exception ex)
            {
                Globals.Log(ex);
                Environment.Exit(0);
            }
        }

        public static Admin GetInstance() => m_Instance;

        public void BackToStart()
        {
            currentStep = 2;
            firstStep_Click(null, null);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Task.Run(new Action(() =>
            {
                try
                {
                    string[] data_to_connect = File.ReadAllLines("config.cfg");

                    if (data_to_connect.Length != 4)
                    {
                        MessageBox.Show(Globals.m_Interface.m_adminConfigIncorrect);
                        Environment.Exit(0);
                    }

                    //0 - Server
                    //1 - User
                    //2 - Password
                    //3 - Databaase

                    Globals.m_sqlRequests = new SQLRequests();
                    Globals.m_sqlRequests.Connect(data_to_connect[0], data_to_connect[1], data_to_connect[2], data_to_connect[3]);

                    uiControls.AddRange(new Control[] { a_Account1, a_ChooseStore1, a_Mail1, a_SendData1, a_StatusSender1 });

                    BeginInvoke(new Action(() => uiControls[0].Visible = true));

                    currentControl = uiControls[0];

                    (uiControls[0] as A_Account).m_Click += NextStep;
                    (uiControls[1] as A_ChooseStore).m_Click += NextStep;
                    (uiControls[2] as A_Mail).m_Click += NextStep;
                    (uiControls[3] as A_SendData).DataSendedStatus += DataSendedStatus;
                }
                catch (Exception ex)
                {
                    Globals.Log(ex);
                    Environment.Exit(0);
                }
            }));

            userName.Text = Globals.m_userHello;
            userImage.Image = Globals.m_userIcon;
        }

        private void DataSendedStatus(Exception ex)
        {
            BeginInvoke(new Action(() =>
            {
                transition.HideSync(currentControl, true, animations[1]);
                transition.ShowSync(uiControls[4], true, animations[0]);

                currentControl = uiControls[4];

                (currentControl as A_StatusSender).ShowStatus(ex is null);

            }));
        }

        private void NextStep(Control control, string[] data)
        {
            try
            {
                if (!(control as A_Account is null))
                {
                    currentStep = 1;
                    a_Count = data[0];
                    a_Login = data[1];
                    a_Password = data[2];

                    firstStep.BorderColor = Color.Transparent;

                    secondStep.FillColor = Globals.colorBlue;
                    secondStep.BorderColor = Color.White;

                    transition.HideSync(control, true, animations[1]);
                    transition.ShowSync(uiControls[1], true, animations[0]);

                    currentControl = uiControls[1];
                }
                else if (!(control as A_ChooseStore is null))
                {
                    currentStep = 2;
                    a_Store = data[0];

                    secondStep.BorderColor = Color.Transparent;

                    thirdStep.FillColor = Globals.colorBlue;
                    thirdStep.BorderColor = Color.White;

                    transition.HideSync(control, true, animations[1]);
                    transition.ShowSync(uiControls[2], true, animations[0]);

                    currentControl = uiControls[2];
                }
                else if (!(control as A_Mail is null))
                {
                    currentStep = 3;
                    a_MailLogin = data[0];
                    a_MailPassword = data[1];
                    a_MailServer = data[2];

                    thirdStep.BorderColor = Color.Transparent;

                    transition.HideSync(control, true, animations[1]);
                    transition.ShowSync(uiControls[3], true, animations[0]);

                    currentControl = uiControls[3];

                    (currentControl as A_SendData).SendData();

                    currentStep = 0;
                }
            }
            catch (Exception ex)
            {
                Globals.Log(ex);
            }
        }

        private void firstStep_Click(object sender, EventArgs e)
        {
            try 
            {
                if (currentStep < 1)
                    return;

                currentStep = 1;

                firstStep.FillColor = Globals.colorBlue;
                firstStep.BorderColor = Color.White;

                secondStep.FillColor = Color.Transparent;
                secondStep.BorderColor = Globals.colorGrey;

                thirdStep.FillColor = Color.Transparent;
                thirdStep.BorderColor = Globals.colorGrey;

                transition.HideSync(currentControl, true, animations[0]);
                transition.ShowSync(uiControls[0], true, animations[1]);

                currentControl = uiControls[0];
            }
            catch (Exception ex)
            {
                Globals.Log(ex);
            }
        }

        private void secondStep_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentStep < 2)
                    return;

                currentStep = 2;

                firstStep.FillColor = Globals.colorBlue;
                firstStep.BorderColor = Color.Transparent;

                secondStep.FillColor = Globals.colorBlue;
                secondStep.BorderColor = Color.White;

                thirdStep.FillColor = Color.Transparent;
                thirdStep.BorderColor = Globals.colorGrey;

                transition.HideSync(currentControl, true, animations[0]);
                transition.ShowSync(uiControls[1], true, animations[1]);

                currentControl = uiControls[1];
            }
            catch (Exception ex)
            {
                Globals.Log(ex);
            }
        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            base.WndProc(ref m);
        }

        private void hideBtn_Click(object sender, EventArgs e) => Environment.Exit(0);
    }
}
