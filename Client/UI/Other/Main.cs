using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Manager;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;

namespace Client.UI.Other
{
    public partial class Main : Form
    {
        private static Main m_Instance;

        private List<Control> uiComponents;
        private List<BunifuImageButton> uiButtons;
        private Control activePanel;
        private BunifuTransition transition;
        private Animation[] animations;
        private bool transitionEnd;

        public Main()
        {
            InitializeComponent();

            m_Instance = this;

            uiComponents = new List<Control>();
            uiButtons = new List<BunifuImageButton>();
            transition = new BunifuTransition();
            animations = new Animation[2];

            //Slide to right
            animations[0] = Animation.VertSlide;
            animations[0].SlideCoeff = new PointF(-1.5f, 0);

            //Slide to left
            animations[1] = Animation.VertSlide;
            animations[1].SlideCoeff = new PointF(1.5f, 0);

            try
            {
                Globals.m_userHello = $"{CSystem.GetTime()}, {Environment.UserName}";
                Globals.m_userIcon = CSystem.GetUserTile(Environment.UserName);

                Globals.PreparingInterface();
            }
            catch(Exception ex)
            {
                Globals.Log(ex);
                Environment.Exit(0);
            }
        }

        public static Main GetInstance() => m_Instance;

        private void Main_Load(object sender, EventArgs e)
        {
            userName.Text = Globals.m_userHello;
            userImage.Image = Globals.m_userIcon;

            Task.Run(() =>
            {
                try
                {
                    transitionEnd = true;

                    if (new WebRequests(Globals.m_linkVersion).Send() != Globals.m_versionServer)
                    {
                        MessageBox.Show("Вышла новая версия клиента!");
                        Process.Start($"{Globals.m_linkServer}");
                        Environment.Exit(0);
                    }

                    uiComponents.AddRange(new Control[] { activation1, info1, connection1 });
                    uiButtons.AddRange(new BunifuImageButton[] { btnActivation, btnInfo, btnConnection });
                    activePanel = uiComponents[0];

                    Invoke(new Action(() =>
                        {
                            uiComponents[0].Visible = true;
                            uiButtons[0].Image = Properties.Resources.Game_Active;

                            awake1.Hide();
                            awake1.Dispose();
                        }));
                    transitionEnd = false;
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() => Globals.Log(ex)));
                    Environment.Exit(0);
                }
            });

            Task.Run(connection1.ThreadCheckConnection);
            Task.Run(ActivatorController.ControlOfInterceptions);
        }

        private void ChooseComponent(BunifuImageButton btn, Bitmap iconBtn, Control panelOpen)
        {
            try
            {
                if (transitionEnd || activePanel == panelOpen)
                    return;

                transitionEnd = true;

                uiButtons[0].Image = Properties.Resources.Game_Inactive;
                uiButtons[1].Image = Properties.Resources.Info_Inactive;
                uiButtons[2].Image = Properties.Resources.CheckConn_Inactive;

                int indexOpenPanel = uiComponents.FindIndex(panel => panel == panelOpen);
                int indexActivePanel = uiComponents.FindIndex(panel => panel == activePanel);

                btn.Image = iconBtn;

                transition.HideSync(activePanel, true, (indexActivePanel < indexOpenPanel) ? animations[1] : animations[0]);
                transition.ShowSync(panelOpen, true, (indexActivePanel > indexOpenPanel) ? animations[1] : animations[0]);

                activePanel = panelOpen;

                transitionEnd = false;
            }
            catch(Exception ex)
            {
                Globals.Log(ex);
            }
        }

        private void btnActivation_Click(object sender, EventArgs e) => ChooseComponent(btnActivation, Properties.Resources.Game_Active, activation1);

        private void btnInfo_Click(object sender, EventArgs e) => ChooseComponent(btnInfo, Properties.Resources.Info_Active, info1);

        private void btnConnection_Click(object sender, EventArgs e) => ChooseComponent(btnConnection, Properties.Resources.CheckConn_Active, connection1);

        private void hideBtn_Click(object sender, EventArgs e)
        {
            if (Globals.m_CanCloseApp)
                Environment.Exit(0);
            else
            {
                Hide();
                notify.Visible = true;
                notify.ShowBalloonTip(3000);
            }
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notify.Visible = false;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            base.WndProc(ref m);
        }
    }
}
