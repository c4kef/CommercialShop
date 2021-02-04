using System;
using System.Threading;
using System.Windows.Forms;
using Client.Manager;

namespace Client.UI.Other
{
    public partial class Loading : Form
    {
        private static Loading m_Instance;
        private int percent;

        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            labelInfo.Text = $"{Environment.UserName}, {Globals.m_Interface.m_infoLoading}";
            userImage.Image = Globals.m_userIcon;
            animateProgress.Start();
        }

        public void Close(int time = 0)
        {
            Thread.Sleep(time);
            this.Hide();
        }

        public void SetProgressPercent(int percent) => this.percent = percent;

        public static Loading GetInstance()
        {
            if (m_Instance is null)
                m_Instance = new Loading();

            return m_Instance;
        }

        private void animateProgress_Tick(object sender, EventArgs e)
        {
            if (progressValue.Value < percent)
                progressValue.Value += 1;
            else if (progressValue.Value > percent)
                progressValue.Value -= 1;
        }
    }
}
