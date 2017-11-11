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
        public static string ApplicationId { get; } = "a95005b278ce780e20480b976747170f1089a242f65288c4f442d7c1a1a6a462";
        public static string ApplicationSecret { get; } = "7df9cfd236e632dcb84318992eb9ffc379d100e9f1e9333fb414d05d15deba53";
        public static string CallbackUrl { get; } = "urn:ietf:wg:oauth:2.0:oob";

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

                // Hide connect button
                connectButton.InvokeIfRequired(c => c.Visible = false);
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
    }
}
