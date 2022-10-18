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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
            display();


        }
        StoreEntities3 db = new StoreEntities3();

        private void grdsearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //int Num = int.Parse(id.Text);
            //string name1 = nameItem.Text;
            //product u = db.products.SingleOrDefault(x => x.Name_pro == name1);
            //db.Users.Remove(u);
            //db.SaveChanges();
            //MessageBox.Show("user Deleted Successfully!");
            //display();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && nameItem.Text != "" && pricetxt.Text != "")
            {
                updaterecord(ConvertImageToByte(img.Image));
                display();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void display()
        {
            StoreEntities3 db = new StoreEntities3();
            var pr = from product in db.products
                     select new
                     {
                         product.ID_Pro,
                         product.Name_pro,
                         product.Price,
                         product.qty,
                         product.location,
                         product.img,
                         product.idItem,
                     }
                     
                     ;

            grdsearch.DataSource = pr.ToList();


            
        }
        private void Search_Click(object sender, EventArgs e)
        {
            string name1 = nameItem.Text;

            product it = db.products.Find(name1);
            if (it != null)
            {
                nameItem.Text = it.Name_pro;
            }
            else
            {
                MessageBox.Show("item not found");
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void itemsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void nameItem_TextChanged(object sender, EventArgs e)
        {

        }
        private void updaterecord(byte[] image)
        {

            int num = int.Parse(id.Text);
                product u = db.products.SingleOrDefault(x => x.ID_Pro == num);
                u.Name_pro = nameItem.Text;
                u.Price = int.Parse(pricetxt.Text);
                u.qty = int.Parse(qtytxt.Text);
            int idit = int.Parse(iditemtxt.Text);
            item i = db.items.SingleOrDefault(x => x.iditem == idit);
            var c = i.NameItem;
            nameitemtxtid.Text = c;
                u.idItem = int.Parse(iditemtxt.Text);
                u.location = location.Text;
                u.img = image;
                

                db.SaveChanges();
            

            MessageBox.Show("user Update Successfully!");
            display();
            ClearData();

        }
        private void ClearData()
        {
           nameItem.Text = "";
            pricetxt.Text = "";
            qtytxt.Text = "";
            location.Text = "";
            iditemtxt.Text = "";
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
        private void EditProduct_Load(object sender, EventArgs e)
        {
            
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

        private void grdsearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            item u = new item();
            iditemtxt.Text = u.NameItem;

            id.Text = grdsearch.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameItem.Text = grdsearch.Rows[e.RowIndex].Cells[1].Value.ToString();
            pricetxt.Text = grdsearch.Rows[e.RowIndex].Cells[2].Value.ToString();
            qtytxt.Text = grdsearch.Rows[e.RowIndex].Cells[3].Value.ToString();
            //.Text = grdsearch.Rows[e.RowIndex].Cells[4].Value.ToString();
            location.Text = grdsearch.Rows[e.RowIndex].Cells[4].Value.ToString();
            img.Image = ConvertByteArrayToImage((byte[])grdsearch.Rows[e.RowIndex].Cells[5].Value);
            iditemtxt.Text= grdsearch.Rows[e.RowIndex].Cells[6].Value.ToString();




        }
    }
}
