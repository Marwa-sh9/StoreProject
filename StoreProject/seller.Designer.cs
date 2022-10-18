
namespace StoreProject
{
    partial class seller
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
            this.ptn_product = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.POS = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.imgseller = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgseller)).BeginInit();
            this.SuspendLayout();
            // 
            // ptn_product
            // 
            this.ptn_product.Location = new System.Drawing.Point(68, 124);
            this.ptn_product.Name = "ptn_product";
            this.ptn_product.Size = new System.Drawing.Size(75, 23);
            this.ptn_product.TabIndex = 0;
            this.ptn_product.Text = "product";
            this.ptn_product.UseVisualStyleBackColor = true;
            this.ptn_product.Click += new System.EventHandler(this.ptn_product_Click);
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(219, 124);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(75, 23);
            this.profile.TabIndex = 1;
            this.profile.Text = "profile";
            this.profile.UseVisualStyleBackColor = true;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // POS
            // 
            this.POS.Location = new System.Drawing.Point(68, 203);
            this.POS.Name = "POS";
            this.POS.Size = new System.Drawing.Size(75, 23);
            this.POS.TabIndex = 2;
            this.POS.Text = "POS";
            this.POS.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "LOGOUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // imgseller
            // 
            this.imgseller.Location = new System.Drawing.Point(124, 27);
            this.imgseller.Name = "imgseller";
            this.imgseller.Size = new System.Drawing.Size(120, 76);
            this.imgseller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgseller.TabIndex = 4;
            this.imgseller.TabStop = false;
            // 
            // seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 298);
            this.Controls.Add(this.imgseller);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.POS);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.ptn_product);
            this.Name = "seller";
            this.Text = "seller";
            this.Load += new System.EventHandler(this.seller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgseller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ptn_product;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Button POS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox imgseller;
    }
}