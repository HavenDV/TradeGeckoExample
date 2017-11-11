using System;
using System.Windows.Forms;

namespace TradeGeckoExample
{
    public partial class AuthentificationCodeForm : Form
    {
        public string Code => textBox.Text;

        public AuthentificationCodeForm()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs args) => Close();
    }
}
