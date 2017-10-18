using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        HandleLogin HandleLogin = new HandleLogin();
        Results dashboard = new Results();
        
        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Username")
            {
                Console.WriteLine("username enter");
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
            Console.WriteLine("Login Form Loaded");
            authStatus.Visible = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool loginAuth;

            if (loginAuth = HandleLogin.Authenticate(username, password))
            {
                this.Visible = false;
                dashboard.Visible = true;
            } else
            {
                authStatus.Visible = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Console.WriteLine("key 13");
                BtnLogin_Click(sender, e);
            }
        }
    }
}
