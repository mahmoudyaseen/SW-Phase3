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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        Services.VerificationServices verification = new Services.VerificationServices();
        private void usernametext_Leave(object sender, EventArgs e)
        {
            if(verification.verifyUserName(usernametext.Text))
            {
                MessageBox.Show("This user name is already found", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernametext.Focus();
                usernametext.SelectionStart = 0;
                usernametext.SelectionLength = usernametext.TextLength;
            }
              
        }

        private void closebutn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adduserbutn_Click(object sender, EventArgs e)
        {
            if (pass2text.Text != passwordtext.Text)
            {
                MessageBox.Show("This Password don't identical", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pass2text.Focus();
                pass2text.SelectionStart = 0;
                pass2text.SelectionLength = usernametext.TextLength;
                return;
            }
            verification.SetNewUser(new Entity.User( usernametext.Text, passwordtext.Text, nametext.Text, phonetext.Text));
            Program.username = usernametext.Text;
            this.Visible = false;
            new PostSearchForm().ShowDialog();
            this.Close();
        }

        private void pass2text_Leave(object sender, EventArgs e)
        {

        }
    }
}
