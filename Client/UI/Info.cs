using System;
using System.Windows.Forms;
using Client.Manager;
using Client.Properties;

namespace Client.UI
{
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e) => iconStore.Image = Resources.Game_Inactive;
    }
}
