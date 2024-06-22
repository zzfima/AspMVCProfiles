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
        }

        private async void btnGetProfiles_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7147/dcp/profiles");
            response.EnsureSuccessStatusCode();
            string requestBody = await response.Content.ReadAsStringAsync();
            txtProfiles.Text = requestBody;
        }

        private async void btnGetAligners_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:7147/dcp/aligners");
            response.EnsureSuccessStatusCode();
            string requestBody = await response.Content.ReadAsStringAsync();
            txtAligners.Text = requestBody;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("https://localhost:7147/");
        }
    }
}
