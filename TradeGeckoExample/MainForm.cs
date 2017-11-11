using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartScreenUtilitiesLibrary.Extensions;
using TradeGeckoApi;
using TradeGeckoExample.Properties;

namespace TradeGeckoExample
{
    public partial class MainForm : Form
    {
        public string ApplicationId => applicationIdTextBox.Text;
        public string ApplicationSecret => applicationSecretTextBox.Text;
        public string CallbackUrl => callbackUrlTextBox.Text;

        public GeckoClient Client { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        public async void Connect(object sender, EventArgs args)
        {
            await Task.Run(() => Connect());
        }

        public void Connect()
        {
            try
            {
                // Create client and connect
                var client = new GeckoClient(ApplicationId, ApplicationSecret, CallbackUrl);

                // Get authorize code
                var uri = client.Authentication.GenerateAuthorizeUrl();
                using (var browserForm = new CefSharp.WinForms.Example.BrowserForm(true))
                {
                    browserForm.Url = uri.AbsoluteUri;
                    browserForm.ShowDialog();

                    client.Authentication.SetAuthorizeCode(browserForm.Code);
                }
                
                // Set client property
                Client = client;

                // Hide connection controls
                HideControls(connectButton,
                    applicationIdTextBox, applicationIdLabel,
                    applicationSecretLabel, applicationSecretTextBox,
                    callbackUrlLabel, callbackUrlTextBox);
                listView.InvokeIfRequired(c => c.Dock = DockStyle.Fill);

                // Show products
                ShowProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.Connect_Exception, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowProducts()
        {
            listView.InvokeIfRequired(c =>
            {
                listView.Clear();

                foreach (var product in Client.Products.List())
                {
                    listView.Items.Add(product.Name);
                }
            });
        }

        #region Utilities

        private void HideControls(params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.InvokeIfRequired(c => c.Visible = false);
            }
        }

        #endregion
    }
}
