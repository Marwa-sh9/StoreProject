
namespace StoreProject
{
    partial class SUDItem
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
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "id";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(481, 201);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 75;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(400, 201);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 74;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(319, 201);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 73;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(286, 63);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(155, 20);
            this.id.TabIndex = 72;
            // 
            // grdsearch
            // 
            this.grdsearch.AllowUserToAddRows = false;
            this.grdsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdsearch.Location = new System.Drawing.Point(13, 50);
            this.grdsearch.Name = "grdsearch";
            this.grdsearch.Size = new System.Drawing.Size(245, 217);
            this.grdsearch.TabIndex = 71;
            this.grdsearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdsearch_CellContentClick);
            this.grdsearch.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdsearch_RowHeaderMouseClick);
            // 
            // nameItem
            // 
            this.nameItem.Location = new System.Drawing.Point(286, 133);
            this.nameItem.Name = "nameItem";
            this.nameItem.Size = new System.Drawing.Size(155, 20);
            this.nameItem.TabIndex = 70;
            this.nameItem.TextChanged += new System.EventHandler(this.nameItem_TextChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 78;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SUDItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.id);
            this.Controls.Add(this.grdsearch);
            this.Controls.Add(this.nameItem);
            this.Name = "SUDItem";
            this.Text = "SUDItem";
            this.Load += new System.EventHandler(this.SUDItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdsearch)).EndInit();
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
        private System.Windows.Forms.TextBox nameItem;
       // private StoreDataSet1TableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iditemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Back;
    }
}