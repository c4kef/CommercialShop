using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Manager;

namespace Client.UI
{
    public partial class Connection : UserControl
    {
        public Connection()
        {
            InitializeComponent();
        }

        public Task ThreadCheckConnection()
        {
            while (true)
            {
                try
                {
                    System.Threading.Thread.Sleep(5_000);//every 5s ping

                    double ping = CSystem.PingTimeAverage(Globals.m_linkServer, 1);

                    this.Invoke(new Action(() =>
                    {
                        labelInfo.Text = $"{ping}ms";

                        if (ping <= 40)
                            statusConnection.Image = Properties.Resources.fi_sr_signal_alt_2;
                        else if (ping <= 60)
                            statusConnection.Image = Properties.Resources.fi_sr_signal_alt_1;
                        else if (ping >= 61)
                            statusConnection.Image = Properties.Resources.fi_sr_signal_alt;
                    }));
                }
                catch (Exception ex)
                {
                    Globals.Log(ex);
                }
            }
        }
    }
}
