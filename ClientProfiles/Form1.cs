using Microsoft.Web.WebView2.Core;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ClientProfiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeAsync();
        }

        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.Navigate(txtAddressBar.Text);
            }
        }

        private async void btnGetProfiles_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"{txtAddressBar.Text}dcp/profiles");
            response.EnsureSuccessStatusCode();
            string requestBody = await response.Content.ReadAsStringAsync();
            txtProfiles.Text = requestBody;
        }

        private async void btnGetAligners_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"{txtAddressBar.Text}dcp/aligners");
            response.EnsureSuccessStatusCode();
            string requestBody = await response.Content.ReadAsStringAsync();
            txtAligners.Text = requestBody;
        }
    }
}
