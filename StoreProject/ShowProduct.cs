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
    public partial class ShowProduct : Form
    {
        public ShowProduct()
        {
            InitializeComponent();
            DisplayData();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            product u = new product();

            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text= dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
        private void DisplayData()
        {
            StoreEntities3 db = new StoreEntities3();
            var us = from item in db.items
                     select item;
            dataGridView1.DataSource = us.ToList();

            var us1 = from product in db.products
                     select product;
            dataGridView2.DataSource = us1.ToList();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //  qty = int.Parse(textBox1.Text),
                //var item1 = Convert.ToString(dataGridView2.Rows[i].Cells[1].Value;

            }
            StoreEntities3 db = new StoreEntities3();
            ////int q = int.Parse(textBox1.Text);
            ////DateTime TodayDate = Convert.ToDateTime(DateTime.Now.ToString());
            //////int prod = ;

            //product p = new product();
            //invoice ii =new invoice();
            ////var t = p.Price;

            ////invoice u1 = db.invoices.SingleOrDefault(x => x.item == num);
            //  //ii.Date = DateTime.Now();
            //for (int i = 0; i < dataGridView2.Rows.Count ; i++)
            //{
            //    ii.item = Convert.ToString(dataGridView2.Rows[i].Cells[1].Value);
            //    //ii.Date = DateTime.Now();
            //    //stokHareketModel.stokKodu = dgvSepet.Rows[i].Cells[1].Value.ToString();
            //    //stokHareketModel.stharGcMik1 = Convert.ToDecimal(dgvSepet.Rows[i].Cells[4].Value);

            //    using (StoreEntities3 db1 = new StoreEntities3())
            //    {
            //        db1.invoices.Add(ii);
            //        db1.SaveChanges();
            //    }
            //}

            invoice u2 = new invoice
            {
               //item =item1,
                 qty = int.Parse(textBox1.Text),
                 item = textBox2.Text,
                 total=int.Parse(textBox3.Text)* int.Parse(textBox1.Text),

                // Date = TodayDate,
                // total=(t*q).Value,

            };

            db.invoices.Add(u2);
            db.SaveChanges();
            MessageBox.Show("information entered Successfully");
            //ClearData();
        }

        private void ShowProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
