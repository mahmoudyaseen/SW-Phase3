using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Boundary
{
    public partial class ItemsForm : Form
    {
        private static AddItemForm frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static AddItemForm get_form_details
        {
            get
            {
                if (frm == null)
                {
                    frm = new AddItemForm();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }

        Services.SearchServices services = new Services.SearchServices();
        public ItemsForm()
        {
            InitializeComponent();
            List<Entity.Item> list = services.SearchBy(textBox1.Text);
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "IID";
            dataGridView1.Columns[1].HeaderText = "Type";
            dataGridView1.Columns[2].HeaderText = "Location";
            dataGridView1.Columns[3].HeaderText = "Date";
            foreach (Entity.Item item1 in list)
            {
                this.dataGridView1.Rows.Add(item1.getIID(), item1.getType(), item1.getLocation(), item1.getDate());
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            List<Entity.Item> list = services.SearchBy(textBox1.Text);
            dataGridView1.Columns[0].HeaderText = "IID";
            dataGridView1.Columns[1].HeaderText = "Type";
            dataGridView1.Columns[2].HeaderText = "Location";
            dataGridView1.Columns[3].HeaderText = "Date";
            foreach (Entity.Item item1 in list)
            {
                this.dataGridView1.Rows.Add(item1.getIID(),item1.getType(),item1.getLocation(),item1.getDate());
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemForm frm = new AddItemForm();
            int iID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Entity.Item item1 = services.GetItemByID(iID);
            frm.typecombo.Text = item1.getType();
            frm.dateTime.Value = item1.getDate();
            frm.locationtext.Text = item1.getLocation();
            frm.descriptiontext.Text = item1.getDescription();
            /*MemoryStream ms = new MemoryStream(item1.getImage());
            frm.pictureBox.Image = Image.FromStream(ms);*/
            frm.browsebutton.Enabled = false;
            frm.addbutton.Enabled = false;
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
