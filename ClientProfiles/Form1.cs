using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
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
    }
}
