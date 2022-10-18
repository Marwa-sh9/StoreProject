
namespace StoreProject
{
    partial class save_user
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
            this.back = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioseller = new System.Windows.Forms.RadioButton();
            this.open = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.location = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(282, 319);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 58;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioAdmin);
            this.panel3.Controls.Add(this.radioseller);
            this.panel3.Location = new System.Drawing.Point(111, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 45);
            this.panel3.TabIndex = 57;
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdmin.ForeColor = System.Drawing.Color.Red;
            this.radioAdmin.Location = new System.Drawing.Point(12, 12);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(63, 20);
            this.radioAdmin.TabIndex = 26;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioseller
            // 
            this.radioseller.AutoSize = true;
            this.radioseller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioseller.ForeColor = System.Drawing.Color.Red;
            this.radioseller.Location = new System.Drawing.Point(81, 12);
            this.radioseller.Name = "radioseller";
            this.radioseller.Size = new System.Drawing.Size(59, 20);
            this.radioseller.TabIndex = 27;
            this.radioseller.TabStop = true;
            this.radioseller.Text = "seller";
            this.radioseller.UseVisualStyleBackColor = true;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(264, 72);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(64, 23);
            this.open.TabIndex = 56;
            this.open.Text = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // img
            // 
            this.img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img.Location = new System.Drawing.Point(111, 15);
            this.img.Margin = new System.Windows.Forms.Padding(4);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(146, 80);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 54;
            this.img.TabStop = false;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(99, 225);
            this.location.Multiline = true;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Size = new System.Drawing.Size(188, 20);
            this.location.TabIndex = 53;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(127, 319);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 52;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(99, 199);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(188, 20);
            this.phone.TabIndex = 51;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(99, 172);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(188, 20);
            this.password.TabIndex = 50;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(99, 145);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(188, 20);
            this.email.TabIndex = 49;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(99, 118);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(188, 20);
            this.name.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // save_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.open);
            this.Controls.Add(this.img);
            this.Controls.Add(this.location);
            this.Controls.Add(this.save);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Name = "save_user";
            this.Text = "save_user";
            this.Load += new System.EventHandler(this.save_user_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioseller;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}