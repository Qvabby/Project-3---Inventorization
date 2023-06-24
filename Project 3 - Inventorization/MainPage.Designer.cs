namespace Project_3___Inventorization
{
    partial class MainPage
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
            this.ProductsDGV = new System.Windows.Forms.DataGridView();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.ShowProductsBtn = new System.Windows.Forms.Button();
            this.ShowLimitedBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.FunctionsPanel = new System.Windows.Forms.Panel();
            this.InvDGV = new System.Windows.Forms.DataGridView();
            this.InvL = new System.Windows.Forms.Label();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UploadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDGV
            // 
            this.ProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Price,
            this.Description,
            this.SellerId,
            this.UploadDate,
            this.ExpiredDate});
            this.ProductsDGV.Location = new System.Drawing.Point(12, 46);
            this.ProductsDGV.Name = "ProductsDGV";
            this.ProductsDGV.Size = new System.Drawing.Size(484, 150);
            this.ProductsDGV.TabIndex = 0;
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Location = new System.Drawing.Point(12, 30);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(52, 13);
            this.ProductsLabel.TabIndex = 1;
            this.ProductsLabel.Text = "Products:";
            // 
            // ShowProductsBtn
            // 
            this.ShowProductsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.ShowProductsBtn.FlatAppearance.BorderSize = 0;
            this.ShowProductsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowProductsBtn.Location = new System.Drawing.Point(70, 17);
            this.ShowProductsBtn.Name = "ShowProductsBtn";
            this.ShowProductsBtn.Size = new System.Drawing.Size(91, 23);
            this.ShowProductsBtn.TabIndex = 2;
            this.ShowProductsBtn.Text = "Show Products";
            this.ShowProductsBtn.UseVisualStyleBackColor = false;
            this.ShowProductsBtn.Click += new System.EventHandler(this.ShowProductsBtn_Click);
            // 
            // ShowLimitedBtn
            // 
            this.ShowLimitedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.ShowLimitedBtn.FlatAppearance.BorderSize = 0;
            this.ShowLimitedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLimitedBtn.Location = new System.Drawing.Point(167, 17);
            this.ShowLimitedBtn.Name = "ShowLimitedBtn";
            this.ShowLimitedBtn.Size = new System.Drawing.Size(91, 23);
            this.ShowLimitedBtn.TabIndex = 3;
            this.ShowLimitedBtn.Text = "Show Limited";
            this.ShowLimitedBtn.UseVisualStyleBackColor = false;
            this.ShowLimitedBtn.Click += new System.EventHandler(this.ShowLimitedBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(12, 202);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(61, 23);
            this.AddBtn.TabIndex = 4;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Visible = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.RemoveBtn.FlatAppearance.BorderSize = 0;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Location = new System.Drawing.Point(12, 231);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(61, 23);
            this.RemoveBtn.TabIndex = 5;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Visible = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Location = new System.Drawing.Point(12, 260);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(61, 23);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // FunctionsPanel
            // 
            this.FunctionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(200)))));
            this.FunctionsPanel.Location = new System.Drawing.Point(79, 202);
            this.FunctionsPanel.Name = "FunctionsPanel";
            this.FunctionsPanel.Size = new System.Drawing.Size(417, 177);
            this.FunctionsPanel.TabIndex = 7;
            this.FunctionsPanel.Visible = false;
            // 
            // InvDGV
            // 
            this.InvDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvDGV.Location = new System.Drawing.Point(505, 71);
            this.InvDGV.Name = "InvDGV";
            this.InvDGV.Size = new System.Drawing.Size(338, 308);
            this.InvDGV.TabIndex = 9;
            this.InvDGV.Visible = false;
            // 
            // InvL
            // 
            this.InvL.AutoSize = true;
            this.InvL.Location = new System.Drawing.Point(502, 55);
            this.InvL.Name = "InvL";
            this.InvL.Size = new System.Drawing.Size(54, 13);
            this.InvL.TabIndex = 10;
            this.InvL.Text = "Inventory:";
            this.InvL.Visible = false;
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.BuyBtn.FlatAppearance.BorderSize = 0;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Location = new System.Drawing.Point(12, 289);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(61, 23);
            this.BuyBtn.TabIndex = 11;
            this.BuyBtn.Text = "Buy";
            this.BuyBtn.UseVisualStyleBackColor = false;
            this.BuyBtn.Visible = false;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // SellerId
            // 
            this.SellerId.HeaderText = "SellerId";
            this.SellerId.Name = "SellerId";
            // 
            // UploadDate
            // 
            this.UploadDate.HeaderText = "UploadDate";
            this.UploadDate.Name = "UploadDate";
            // 
            // ExpiredDate
            // 
            this.ExpiredDate.HeaderText = "ExpiredDate";
            this.ExpiredDate.Name = "ExpiredDate";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 391);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.InvL);
            this.Controls.Add(this.InvDGV);
            this.Controls.Add(this.FunctionsPanel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ShowLimitedBtn);
            this.Controls.Add(this.ShowProductsBtn);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.ProductsDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDGV;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button ShowProductsBtn;
        private System.Windows.Forms.Button ShowLimitedBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Panel FunctionsPanel;
        private System.Windows.Forms.DataGridView InvDGV;
        private System.Windows.Forms.Label InvL;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UploadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
    }
}