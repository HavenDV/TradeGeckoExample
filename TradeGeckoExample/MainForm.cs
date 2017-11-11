using System;
using System.Drawing;
using System.IO;
using System.Net;
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

            listView.SmallImageList = imageList;
            listView.LargeImageList = imageList;
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
            var products = Client.Products.List();

            imageList.Images.Clear();
            foreach (var product in products)
            {
                var path = Path.GetTempFileName();
                using (var client = new WebClient())
                {
                    client.DownloadFile(product.ImageUrl, path);
                }

                imageList.Images.Add(Image.FromFile(path));
            }

            listView.InvokeIfRequired(c =>
            {
                c.Clear();

                var i = 0;
                foreach (var product in products)
                {
                    c.Items.Add(product.Name, i);
                    ++i;
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
