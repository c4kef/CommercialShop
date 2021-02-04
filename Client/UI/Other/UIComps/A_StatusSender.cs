using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Client.Manager;

namespace Client.UI.Other.UIComps
{
    public partial class A_StatusSender : UserControl
    {
        public A_StatusSender()
        {
            InitializeComponent();
        }

        public void ShowStatus(bool isSuccessful)
        {
            labelStatus.Text = (isSuccessful) ? Globals.m_Interface.m_successful : Globals.m_Interface.m_unsuccessful;
            iconStatus.Image = (isSuccessful) ? Properties.Resources.fi_sr_cloud : Properties.Resources.fi_sr_cloud_1;
            Task.Run(new Action(() =>
            { 
                Thread.Sleep(3_000);
                BeginInvoke(new Action(() => Admin.GetInstance().BackToStart()));
            }));
        }
    }
}
