using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal_assistant
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtboxuser .Text;
            string password = txtboxpass.Text;

            if (ValidateLogin(username, password))
            {
                // Hide the login form and open the main application
                this.Hide();
                Form1.CurrentUser = username;

                // Assuming the main form is named "personalAssistant"
                Form1  mainForm = new Form1();
                mainForm.Show();
            }
            
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private bool ValidateLogin(string username, string password)
        {
            // Hardcoded credentials for simplicity (use a secure method in real applications)
            string validUsername = "ishdeep";
            string validPassword = "password123";

            return username == validUsername && password == validPassword;
        }

    }
}
    

