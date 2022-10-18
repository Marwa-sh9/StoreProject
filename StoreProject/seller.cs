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
    public partial class seller : Form
    {
        public seller()
        {
            InitializeComponent();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            add_user su = new add_user();
            su.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            signin su = new signin();
            su.Show();
            Visible = false;
        }

        private void ptn_product_Click(object sender, EventArgs e)
        {
              produt su = new produt();
            su.Show();
            Visible = false;
        }

        private void seller_Load(object sender, EventArgs e)
        {

        }
    }
}
