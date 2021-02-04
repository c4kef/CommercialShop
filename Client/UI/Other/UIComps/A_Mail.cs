using System;
using System.Windows.Forms;

namespace Client.UI.Other.UIComps
{
    public partial class A_Mail : UserControl
    {
        public delegate void m_ClickNext(Control control, string[] data);
        public event m_ClickNext m_Click;

        public A_Mail()
        {
            InitializeComponent();
        }

        private void btnNextStep_Click(object sender, EventArgs e) => m_Click?.Invoke(this, new string[] { inputLoginMail.Text == string.Empty ? "-" : inputLoginMail.Text, inputPasswordMail.Text == string.Empty ? "-" : inputPasswordMail.Text, inputServerMail.Text == string.Empty ? "-" : inputServerMail.Text });

        private void inputPasswordMail_KeyPress(object sender, KeyPressEventArgs e) => inputPasswordMail.PasswordChar = inputPasswordMail.Text.Length >= 2 ? '*' : '\0';
    }
}
