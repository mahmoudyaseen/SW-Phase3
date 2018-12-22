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
    public partial class PostSearchForm : Form
    {
        public PostSearchForm()
        {
            InitializeComponent();
            label1.Text = "HI " + Program.username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new ItemsForm().ShowDialog();
            this.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new AddItemForm().ShowDialog();
            this.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
