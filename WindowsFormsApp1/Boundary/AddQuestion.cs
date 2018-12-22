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
    public partial class AddQuestion : Form
    {
        Services.PostServices services = new Services.PostServices();
        public AddQuestion()
        {
            InitializeComponent();
        }
        
        private void AddQuesbtn_Click(object sender, EventArgs e)
        {
            services.AddQues(new Entity.Question(services.QuesNum()+1, textBox1.Text), Convert.ToInt32(IIdtext.Text.ToString()));
            textBox1.Text = "";
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
