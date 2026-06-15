using LibLoginAuthenticator;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {

        private LoginAuthenticator _auth = new LoginAuthenticator();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, System.EventArgs e)
        {
            _auth.Username = txtUsername.Text == "" ? null : txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, System.EventArgs e)
        {
            _auth.SetPassword(txtPassword.Text == "" ? null : txtPassword.Text);
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            bool? result = _auth.Authenticate();

            if (result == null)
            {
                MessageBox.Show("Username and password must be provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == false)
            {
                MessageBox.Show("Authentication was not successful.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Authentication successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
