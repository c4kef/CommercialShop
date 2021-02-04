using System;
using System.Windows.Forms;

namespace Client.UI.Other.UIComps
{
    public partial class A_Account : UserControl
    {
        public delegate void m_ClickNext(Control control, string[] data);
        public event m_ClickNext m_Click;

        public A_Account()
        {
            InitializeComponent();
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            if (inputCountKeys.Text == string.Empty || inputLoginAccount.Text == string.Empty || inputPasswordAccount.Text == string.Empty)
                return;

            m_Click?.Invoke(this, new string[] { inputCountKeys.Text, inputLoginAccount.Text, inputPasswordAccount.Text });
        }

        private void inputCountKeys_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void inputPasswordAccount_KeyPress(object sender, KeyPressEventArgs e) => inputPasswordAccount.PasswordChar = inputPasswordAccount.Text.Length >= 2 ? '*' : '\0';
    }
}
