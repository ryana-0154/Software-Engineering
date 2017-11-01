using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGP
{
    public partial class LoginForm : Form
    {
        Dashboard dashboard = new Dashboard();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        
        private void LoginForm_Load(object sender, EventArgs e)
        {
            authStatus.Visible = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Variables to hold username and password
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(HandleLogin.Authenticate(username, password)) {
                Visible = false;
                dashboard.Visible = true;
            } else
            {
                authStatus.Visible = true;
            }
        }

        public void UnauthMsg()
        {
            authStatus.Visible = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If the return key is pressed, sent a login button click event
            if (e.KeyChar == (char)13)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
