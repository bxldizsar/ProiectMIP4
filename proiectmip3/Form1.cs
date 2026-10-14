using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectmip3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void NavigateToUrl()
        {
            string url = txtUrl.Text.Trim();
            if (url == "") return;

            // ha csak "google.com"-ot írnak, hozzátesszük a https://-t
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                url = "https://" + url;

            webBrowser1.Navigate(url);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            NavigateToUrl();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;   // ne legyen "ding" hang
                NavigateToUrl();
            }
        }
    }
}
