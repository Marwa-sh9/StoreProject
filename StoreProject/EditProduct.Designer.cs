
namespace StoreProject
{
    partial class EditProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.grdsearch = new System.Windows.Forms.DataGridView();
            this.nameItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.qtytxt = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.img = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.Button();
            this.iditemtxt = new System.Windows.Forms.TextBox();
            this.nameitemtxtid = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(213, 224);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 83;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(132, 224);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 82;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(51, 224);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 81;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(21, 283);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(155, 20);
            this.id.TabIndex = 80;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // grdsearch
            // 
            this.grdsearch.AllowUserToAddRows = false;
            this.grdsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdsearch.Location = new System.Drawing.Point(12, 12);
            this.grdsearch.Name = "grdsearch";
            this.grdsearch.Size = new System.Drawing.Size(785, 169);
            this.grdsearch.TabIndex = 79;
            this.grdsearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdsearch_CellContentClick);
            this.grdsearch.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdsearch_RowHeaderMouseClick);
            // 
            // nameItem
            // 
            this.nameItem.Location = new System.Drawing.Point(21, 353);
            this.nameItem.Name = "nameItem";
            this.nameItem.Size = new System.Drawing.Size(155, 20);
            this.nameItem.TabIndex = 78;
            this.nameItem.TextChanged += new System.EventHandler(this.nameItem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "price";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(215, 283);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(155, 20);
            this.pricetxt.TabIndex = 87;
            // 
            // qtytxt
            // 
            this.qtytxt.Location = new System.Drawing.Point(215, 353);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(155, 20);
            this.qtytxt.TabIndex = 86;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(404, 283);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(155, 20);
            this.location.TabIndex = 90;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(583, 216);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(169, 134);
            this.img.TabIndex = 91;
            this.img.TabStop = false;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(484, 309);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 92;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // iditemtxt
            // 
            this.iditemtxt.Location = new System.Drawing.Point(404, 353);
            this.iditemtxt.Name = "iditemtxt";
            this.iditemtxt.Size = new System.Drawing.Size(155, 20);
            this.iditemtxt.TabIndex = 93;
            // 
            // nameitemtxtid
            // 
            this.nameitemtxtid.Location = new System.Drawing.Point(404, 248);
            this.nameitemtxtid.Name = "nameitemtxtid";
            this.nameitemtxtid.ReadOnly = true;
            this.nameitemtxtid.Size = new System.Drawing.Size(155, 20);
            this.nameitemtxtid.TabIndex = 94;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.nameitemtxtid);
            this.Controls.Add(this.iditemtxt);
            this.Controls.Add(this.open);
            this.Controls.Add(this.img);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.id);
            this.Controls.Add(this.grdsearch);
            this.Controls.Add(this.nameItem);
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.DataGridView grdsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn iditemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameItemDataGridViewTextBoxColumn;
       // private StoreDataSet1 storeDataSet1;
        private System.Windows.Forms.TextBox nameItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox qtytxt;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.TextBox iditemtxt;
        private System.Windows.Forms.TextBox nameitemtxtid;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        //  private StoreDataSet1TableAdapters.itemsTableAdapter itemsTableAdapter;
    }
}