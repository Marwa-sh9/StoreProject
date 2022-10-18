using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;

namespace StoreProject
{
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
            DisplayData();

        }
        StoreEntities3 db = new StoreEntities3();
        private void DisplayData()
        {
            StoreEntities3 db = new StoreEntities3();
            var us = from User in db.Users
                     select new
                     {
                         User.ID,
                         User.Name,
                         User.Email,
                         User.password,
                         User.phone,
                         User.location,
                         User.img,
                         User.isAdmin,

                     };
            grdusers.DataSource = us.ToList();
            
        }
        private void add_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.Users' table. You can move, or remove it, as needed.
         //   this.usersTableAdapter.Fill(this.storeDataSet.Users);

        }
        byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void ClearData()
        {
            name.Text = "";
            email.Text = "";
            password.Text = "";
            location.Text = "";
            phone.Text = "";
            img.Image = null;
        }
        private void grdusers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            User u = new User();

            id.Text = grdusers.Rows[e.RowIndex].Cells[0].Value.ToString();
            name.Text = grdusers.Rows[e.RowIndex].Cells[1].Value.ToString();
            email.Text = grdusers.Rows[e.RowIndex].Cells[2].Value.ToString();
            password.Text = grdusers.Rows[e.RowIndex].Cells[3].Value.ToString();
            phone.Text = grdusers.Rows[e.RowIndex].Cells[4].Value.ToString();
            location.Text = grdusers.Rows[e.RowIndex].Cells[5].Value.ToString();
            //location.Text = u.location;
            img.Image = ConvertByteArrayToImage((byte[])grdusers.Rows[e.RowIndex].Cells[6].Value);

            if ((bool)grdusers.Rows[e.RowIndex].Cells[7].Value == true)
            {
                radioAdmin.Checked = (bool)grdusers.Rows[e.RowIndex].Cells[7].Value;
            }
            else
            {
                radioseller.Checked = (bool)grdusers.Rows[e.RowIndex].Cells[7].Value;

            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int Num=int.Parse(id.Text);
            string name1 = name.Text;        
           User  u= db.Users.SingleOrDefault( x => x.Name == name1);
            db.Users.Remove(u);
            db.SaveChanges();
            MessageBox.Show("user Deleted Successfully!");
            DisplayData();

        }
        private void updaterecord(byte[] image)
        {

            int num = int.Parse(id.Text);
            if (radioAdmin.Checked)
            {
                User u = db.Users.SingleOrDefault(x => x.ID == num);
                u.Name = name.Text;
                u.Email = email.Text;
                u.password = password.Text;
                u.phone = phone.Text;
                u.location = location.Text;
                u.img = image;
                u.isAdmin = true;

                db.SaveChanges();               
            }
            else
            {
                User u = db.Users.SingleOrDefault(x => x.ID == num);
                u.Name = name.Text;
                u.Email = email.Text;
                u.password = password.Text;
                u.phone = phone.Text;
                u.location = location.Text;
                u.img = image;
                u.isAdmin = false;

                db.SaveChanges();
            }
            MessageBox.Show("user Update Successfully!");
            DisplayData();
            ClearData();

        }
        private void update_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && name.Text != "" && email.Text != "" )
            {
                updaterecord(ConvertImageToByte(img.Image));
                DisplayData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }

        }
        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Images(.jpg,.png,.gif,.bmp)|*.png;*.jpg;*.gif;*.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    img.Image = Image.FromFile(openFileDialog1.FileName);
                location.Text = openFileDialog1.FileName;
                // DisplayData();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose photo!");

            }
        }
        private void grdusers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
