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
using System.IO;


namespace StoreProject
{
    public partial class save_user : Form
    {
        StoreEntities3 db = new StoreEntities3();
        public save_user()
        {
            InitializeComponent();
        }

        private void save_user_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && location.Text != "" && password.Text != "" && email.Text != "" && phone.Text != "")
            {
                insert(ConvertImageToByte(img.Image));
            }
            else
            {
                MessageBox.Show("Please fill data correctly!");
            }

        }
        public void insert(byte[] image)
        {
            if (radioAdmin.Checked)
            {
                User u = new User
                {
                    Name = name.Text,
                    Email = email.Text,
                    password = password.Text,
                    phone = phone.Text,
                    location = location.Text,
                    img = image,
                    isAdmin = true
                };

                db.Users.Add(u);
                db.SaveChanges();
                MessageBox.Show("information entered Successfully");
                ClearData();
            }
            else
            {
                User u = new User
                {
                    Name = name.Text,
                    Email = email.Text,
                    password = password.Text,
                    phone = phone.Text,
                    location = location.Text,
                    img = image,
                    isAdmin = false
                };
                db.Users.Add(u);
                db.SaveChanges();
                MessageBox.Show("information entered Successfully");
                ClearData();
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

        private void back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            Visible = false;
        }
    }
}

