using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WCFWindowsFormsClient
{
    public partial class WCFClientForm : Form
    {
        private readonly TestService.TestServiceClient _client;
        public WCFClientForm()
        {
            InitializeComponent();
            _client = new TestService.TestServiceClient();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _client.EchoTest(txtInput.Text);

                lblResponse.Text = result;
            }
            catch (Exception ex)
            {
                lblResponse.Text = ex.Message;
            }
        }
    }
}
