using System;
using System.Windows.Forms;

namespace TradeGeckoExample
{
    public partial class AuthentificationCodeForm : Form
    {
        public string Code { get => textBox.Text; set => textBox.Text = value; }

        public AuthentificationCodeForm()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs args) => Close();
    }
}
