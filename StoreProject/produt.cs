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
    public partial class produt : Form
    {
        public produt()
        {
            InitializeComponent();
            DisplayData();
        }
        private List<item> comboitems()
        {
            using (StoreEntities3 db = new StoreEntities3())
            {
                return db.items.ToList();
            }

        }
        StoreEntities3 db = new StoreEntities3();

        private void DisplayData()
        {

            var it = from item in db.items
                     select item;

            comboitem.DataSource = it.ToList();
            comboitem.DisplayMember = "NameItem";
            comboitem.ValueMember = "iditem";

        }
        private void SAVE_Click(object sender, EventArgs e)
        {
            if (namepro.Text != "" && txtPrice.Text != "" && txtamount.Text != "")
            {
                savepro(ConvertImageToByte(img.Image));
            }
            else
            {
                MessageBox.Show("Please fill data correctly!");
            }
        }
        private void savepro(byte[] image)
        {
            //item i = new item();
            //var itms = db.items.Where(x => x.iditem ==1).SingleOrDefault();
            ////var selectedit = comboitem.SelectedValue;
            ////item ii = db.items.SingleOrDefault(x => x.iditem==selectedit);
            object v = comboitem.SelectedItem;

            product u = new product
            {
                Name_pro = namepro.Text,                
                Price = int.Parse(txtPrice.Text),
                location = location.Text,
                img = image,
                //idItem =comboitem.SelectedIndex+1,
                idItem = (int)v,
                qty = int.Parse(txtamount.Text),
            };

            db.products.Add(u);
            db.SaveChanges();
            MessageBox.Show("item saved");
        }

        private void produt_Load(object sender, EventArgs e)
        {

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
        private void btnopen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Images(.jpg,.png,.gif,.bmp)|*.png;*.jpg;*.gif;*.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    img.Image = Image.FromFile(openFileDialog1.FileName);
                //MemoryStream ms = new MemoryStream();
                
                location.Text = openFileDialog1.FileName;
                // DisplayData();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose photo!");

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            Visible = false;

        }
    }

   

  
}


