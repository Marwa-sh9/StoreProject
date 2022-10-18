
namespace StoreProject
{
    partial class signin
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioseller = new System.Windows.Forms.RadioButton();
            this.bLogIn = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioAdmin);
            this.panel3.Controls.Add(this.radioseller);
            this.panel3.Location = new System.Drawing.Point(65, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 39);
            this.panel3.TabIndex = 68;
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
            // bLogIn
            // 
            this.bLogIn.Location = new System.Drawing.Point(108, 189);
            this.bLogIn.Name = "bLogIn";
            this.bLogIn.Size = new System.Drawing.Size(75, 23);
            this.bLogIn.TabIndex = 67;
            this.bLogIn.Text = "LogIn";
            this.bLogIn.UseVisualStyleBackColor = true;
            this.bLogIn.Click += new System.EventHandler(this.bLogIn_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(65, 40);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(168, 20);
            this.email.TabIndex = 66;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(65, 75);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(168, 20);
            this.password.TabIndex = 65;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 272);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bLogIn);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Name = "signin";
            this.Text = "signin";
            this.Load += new System.EventHandler(this.signin_Load_1);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioseller;
        private System.Windows.Forms.Button bLogIn;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
    }
}

