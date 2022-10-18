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
    public partial class SUDItem : Form
    {
        public SUDItem()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {

            StoreEntities3 db = new StoreEntities3();
            var im = from item in db.items
                     select new
                     { item.iditem
                     ,item.NameItem};
            grdsearch.DataSource = im.ToList();

        }

        private void SUDItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet1.items' table. You can move, or remove it, as needed.
          //  this.itemsTableAdapter.Fill(this.storeDataSet1.items);

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void grdsearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id.Text = grdsearch.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameItem.Text = grdsearch.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        StoreEntities3 db = new StoreEntities3();

        private void Search_Click(object sender, EventArgs e)
        {
            string name1 = nameItem.Text;

            item it = db.items.Find(name1);
            if (it != null)
            {
                nameItem.Text = it.NameItem;
            }
            else
            {
                MessageBox.Show("item not found");
            }
        }

        private void nameItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            int num = int.Parse(id.Text);

            item u = db.items.SingleOrDefault(x => x.iditem == num);
            u.NameItem = nameItem.Text;


            db.SaveChanges();
            MessageBox.Show("item Update Successfully!");
            nameItem.Text = "";
            id.Text = "";
            DisplayData();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string name1 = nameItem.Text;
            item u = db.items.SingleOrDefault(x => x.NameItem == name1);
            db.items.Remove(u);
            db.SaveChanges();
            MessageBox.Show("item Deleted Successfully!");
            DisplayData();
        }

        private void grdsearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
