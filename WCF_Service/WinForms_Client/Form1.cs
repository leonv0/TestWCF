using WPF_Client_Sender;

namespace WinForms_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            TestServiceClient test = new TestServiceClient();
            string res = test.EchoTest(txtInput.Text);
            lblReturn.Text = res;
        }
    }
}