using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.IO;


namespace StoreProject
{
    public partial class Admin : Form
    {
        StoreEntities3 db = new StoreEntities3();

        public Admin()
        {
            InitializeComponent();
          //  isadminfalse();
            displayimage();
        }

        private void isadminfalse()
        {         
                if (db.Users.Where(x=>x.isAdmin == false).Count() > 0)
                {
                    //Admin a = new Admin();
                    //a.Show();
                    //Visible = false;
                    //MessageBox.Show("your user");
                    this.Close();
                    signin a = new signin();
                    a.Show();
                    // this.Close();
                    //Visible = false;
                }
                else
                {
                    //Admin a = new Admin();
                    //a.Show();
                    //Visible = false;
                }
        }

        private void displayimage()
        {
            try
            {
                //using (StoreEntities2 db = new StoreEntities2())
                //{

                //    var it = from User in db.Users
                //             select User;
                //}

               
                StoreEntities3 d = new StoreEntities3();
                User u = new User();
                var i = u.ID;
                var photo = d.Users.Where(x => x.ID == 1).SingleOrDefault();
                byte[] arr = photo.img;
                MemoryStream ms = new MemoryStream(arr);
                imgAdmin.Image = Image.FromStream(ms);
               
            }
            catch (Exception)
            {

            }           

        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            save_user su = new save_user();
            su.Show();
            Visible = false;
        }

        private void btnaddItem_Click(object sender, EventArgs e)
        {
            AddItem su = new AddItem();
            su.Show();
            Visible = false;
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            produt p = new produt();
            p.Show();
            Visible = false;
        }

        private void btnDelUpd_Click(object sender, EventArgs e)
        {
           add_user p = new add_user();
            p.Show();
            Visible = false;
        }

        private void btnUpdDeleSarch_Click(object sender, EventArgs e)
        {
            SUDItem p = new SUDItem();
            p.Show();
            Visible = false;
        }

        private void btnEditPro_Click(object sender, EventArgs e)
        {
            EditProduct ed = new EditProduct();
            ed.Show();
            Visible = false;
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
