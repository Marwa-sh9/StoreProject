
namespace StoreProject
{
    partial class Admin
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
            this.imgAdmin = new System.Windows.Forms.PictureBox();
            this.btnUpdDeleSarch = new System.Windows.Forms.Button();
            this.btnaddItem = new System.Windows.Forms.Button();
            this.btnDelUpd = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.btnEditPro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAdmin
            // 
            this.imgAdmin.Location = new System.Drawing.Point(123, 28);
            this.imgAdmin.Name = "imgAdmin";
            this.imgAdmin.Size = new System.Drawing.Size(180, 111);
            this.imgAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAdmin.TabIndex = 9;
            this.imgAdmin.TabStop = false;
            // 
            // btnUpdDeleSarch
            // 
            this.btnUpdDeleSarch.Location = new System.Drawing.Point(219, 224);
            this.btnUpdDeleSarch.Name = "btnUpdDeleSarch";
            this.btnUpdDeleSarch.Size = new System.Drawing.Size(161, 23);
            this.btnUpdDeleSarch.TabIndex = 8;
            this.btnUpdDeleSarch.Text = "Edit Item";
            this.btnUpdDeleSarch.UseVisualStyleBackColor = true;
            this.btnUpdDeleSarch.Click += new System.EventHandler(this.btnUpdDeleSarch_Click);
            // 
            // btnaddItem
            // 
            this.btnaddItem.Location = new System.Drawing.Point(69, 224);
            this.btnaddItem.Name = "btnaddItem";
            this.btnaddItem.Size = new System.Drawing.Size(75, 23);
            this.btnaddItem.TabIndex = 7;
            this.btnaddItem.Text = "Add Item";
            this.btnaddItem.UseVisualStyleBackColor = true;
            this.btnaddItem.Click += new System.EventHandler(this.btnaddItem_Click);
            // 
            // btnDelUpd
            // 
            this.btnDelUpd.Location = new System.Drawing.Point(219, 159);
            this.btnDelUpd.Name = "btnDelUpd";
            this.btnDelUpd.Size = new System.Drawing.Size(161, 23);
            this.btnDelUpd.TabIndex = 6;
            this.btnDelUpd.Text = "Edit User";
            this.btnDelUpd.UseVisualStyleBackColor = true;
            this.btnDelUpd.Click += new System.EventHandler(this.btnDelUpd_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(69, 159);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddPro
            // 
            this.btnAddPro.Location = new System.Drawing.Point(69, 282);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(75, 23);
            this.btnAddPro.TabIndex = 10;
            this.btnAddPro.Text = "Add Product";
            this.btnAddPro.UseVisualStyleBackColor = true;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // btnEditPro
            // 
            this.btnEditPro.Location = new System.Drawing.Point(219, 281);
            this.btnEditPro.Name = "btnEditPro";
            this.btnEditPro.Size = new System.Drawing.Size(161, 23);
            this.btnEditPro.TabIndex = 11;
            this.btnEditPro.Text = "Edit Product";
            this.btnEditPro.UseVisualStyleBackColor = true;
            this.btnEditPro.Click += new System.EventHandler(this.btnEditPro_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 370);
            this.Controls.Add(this.btnEditPro);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.imgAdmin);
            this.Controls.Add(this.btnUpdDeleSarch);
            this.Controls.Add(this.btnaddItem);
            this.Controls.Add(this.btnDelUpd);
            this.Controls.Add(this.btnAddUser);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAdmin;
        private System.Windows.Forms.Button btnUpdDeleSarch;
        private System.Windows.Forms.Button btnaddItem;
        private System.Windows.Forms.Button btnDelUpd;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddPro;
        private System.Windows.Forms.Button btnEditPro;
    }
}