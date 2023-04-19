using WPF_Client_Sender;

namespace WinForms_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
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