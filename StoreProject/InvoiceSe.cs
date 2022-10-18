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
    public partial class InvoiceSe : Form
    {
        public InvoiceSe()
        {
            InitializeComponent();

            StoreEntities3 db = new StoreEntities3();
            var us = from invoice in db.invoices
                     select invoice;
            dataGridView1.DataSource = us.ToList();



            invoice i = new invoice();
            label1.Text = textBox1.Text;

            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                // textBox1.Text += Convert.ToString(i.total);
                textBox1.Text += dataGridView1.Rows[j].Cells["total"].Value.ToString();
            }
        }
        StoreEntities3 db = new StoreEntities3();

        private void InvoiceSe_Load(object sender, EventArgs e)
        {
            
        }
    }
}
