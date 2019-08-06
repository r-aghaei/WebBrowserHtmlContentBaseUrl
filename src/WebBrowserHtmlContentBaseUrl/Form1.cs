using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserHtmlContentBaseUrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.SetHtmlContent(Properties.Resources.HTML, $@"{new Uri(Application.StartupPath)}/");
        }

        private void PrintToolStripButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }
    }
}
