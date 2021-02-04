using System;
using System.Windows.Forms;

namespace Client.UI.Other.UIComps
{
    public partial class A_ChooseStore : UserControl
    {
        public delegate void m_ClickNext(Control control, string[] data);
        public event m_ClickNext m_Click;

        public A_ChooseStore()
        {
            InitializeComponent();
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (dropdownStore.SelectedIndex < 0)
                return;

            m_Click?.Invoke(this, new string[] { dropdownStore.Items[dropdownStore.SelectedIndex].ToString() });
        }
    }
}
