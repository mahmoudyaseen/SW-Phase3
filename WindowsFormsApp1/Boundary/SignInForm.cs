using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Boundary
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        Services.VerificationServices verification = new Services.VerificationServices();
        private void signinbutn_Click(object sender, EventArgs e)
        {
            if(verification.VerifyData(usernametext.Text , passwordtext.Text))
            {
                Program.username = usernametext.Text;
                this.Visible = false;
                new PostSearchForm().ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("You entered Wrong username or Password", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void closebutn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
