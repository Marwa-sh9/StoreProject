using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProject
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        StoreEntities3 db = new StoreEntities3();

        private void btnSave_Click(object sender, EventArgs e)
        {
            item u = new item
            {
                NameItem = txtname.Text
            };

            db.items.Add(u);
            db.SaveChanges();
            MessageBox.Show("item saved");
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            Visible = false;

        }
    }
}
