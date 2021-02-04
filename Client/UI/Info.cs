using System;
using System.Windows.Forms;
using Client.Manager;

namespace Client.UI
{
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e) => iconStore.Image = Globals.m_logoApp;
    }
}
