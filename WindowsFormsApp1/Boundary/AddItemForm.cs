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
    public partial class AddItemForm : Form
    {
        private static AddQuestion frm;
        static void frm_formclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static AddQuestion get_form_details
        {
            get
            {
                if (frm == null)
                {
                    frm = new AddQuestion();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
        }

        Services.PostServices postServices = new Services.PostServices();
        public AddItemForm()
        {
            InitializeComponent();
            usernametext.Text = Program.username;
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image file |*.PNG; *.JPG; *.GIF; *BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            byte[] picturebyte = ms.ToArray();
            Entity.Item item1 = new Entity.Item(postServices.GetCount()+1, typecombo.Text, locationtext.Text
                , dateTime.Value, descriptiontext.Text, picturebyte);
            postServices.AddPost(item1);

            AddQuestion frm = new AddQuestion();
            frm.IIdtext.Text = item1.getIID().ToString();
            frm.ShowDialog();
            this.Close();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
