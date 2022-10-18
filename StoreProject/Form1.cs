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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }
        StoreEntities3 db = new StoreEntities3();

        private void bLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if(db.Users.Where(x=>x.Email==email.Text&&x.password==password.Text&&x.isAdmin==true&&radioAdmin.Checked).Count()>0)
                {
                    Admin a = new Admin();
                    a.Show();
                    Visible = false;

                    MessageBox.Show("Hello");
                }
                else if (db.Users.Where(x => x.Email == email.Text && x.password == password.Text && x.isAdmin == false && radioseller.Checked).Count() > 0)

                {
                    //Admin a = new Admin();
                    //a.Show();
                    //Visible = false;
                    MessageBox.Show("your user");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch(Exception )
            {
                MessageBox.Show("");
            }
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }

        private void signin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
