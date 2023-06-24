namespace Project_3___Inventorization.Functionality
{
    partial class Update
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
            this.Title = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DateL = new System.Windows.Forms.Label();
            this.ExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.DescriptionL = new System.Windows.Forms.Label();
            this.PriceL = new System.Windows.Forms.Label();
            this.PriceNUAD = new System.Windows.Forms.NumericUpDown();
            this.TitleTb = new System.Windows.Forms.TextBox();
            this.TitleL = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IdNUAD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNUAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNUAD)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(158, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(75, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "Update";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Location = new System.Drawing.Point(12, 142);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(61, 23);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DateL
            // 
            this.DateL.AutoSize = true;
            this.DateL.Location = new System.Drawing.Point(12, 99);
            this.DateL.Name = "DateL";
            this.DateL.Size = new System.Drawing.Size(83, 13);
            this.DateL.TabIndex = 17;
            this.DateL.Text = "Exparation Date";
            // 
            // ExpiredDate
            // 
            this.ExpiredDate.Location = new System.Drawing.Point(15, 115);
            this.ExpiredDate.Name = "ExpiredDate";
            this.ExpiredDate.Size = new System.Drawing.Size(200, 20);
            this.ExpiredDate.TabIndex = 16;
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Location = new System.Drawing.Point(225, 41);
            this.DescriptionTb.MaxLength = 50;
            this.DescriptionTb.Multiline = true;
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(180, 124);
            this.DescriptionTb.TabIndex = 15;
            // 
            // DescriptionL
            // 
            this.DescriptionL.AutoSize = true;
            this.DescriptionL.Location = new System.Drawing.Point(162, 44);
            this.DescriptionL.Name = "DescriptionL";
            this.DescriptionL.Size = new System.Drawing.Size(63, 13);
            this.DescriptionL.TabIndex = 14;
            this.DescriptionL.Text = "Description:";
            // 
            // PriceL
            // 
            this.PriceL.AutoSize = true;
            this.PriceL.Location = new System.Drawing.Point(12, 73);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(34, 13);
            this.PriceL.TabIndex = 13;
            this.PriceL.Text = "Price:";
            // 
            // PriceNUAD
            // 
            this.PriceNUAD.Location = new System.Drawing.Point(53, 71);
            this.PriceNUAD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PriceNUAD.Name = "PriceNUAD";
            this.PriceNUAD.Size = new System.Drawing.Size(100, 20);
            this.PriceNUAD.TabIndex = 12;
            // 
            // TitleTb
            // 
            this.TitleTb.Location = new System.Drawing.Point(53, 41);
            this.TitleTb.MaxLength = 50;
            this.TitleTb.Name = "TitleTb";
            this.TitleTb.Size = new System.Drawing.Size(100, 20);
            this.TitleTb.TabIndex = 11;
            // 
            // TitleL
            // 
            this.TitleL.AutoSize = true;
            this.TitleL.Location = new System.Drawing.Point(12, 44);
            this.TitleL.Name = "TitleL";
            this.TitleL.Size = new System.Drawing.Size(30, 13);
            this.TitleL.TabIndex = 10;
            this.TitleL.Text = "Title:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(84, 147);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(19, 13);
            this.IDLabel.TabIndex = 19;
            this.IDLabel.Text = "Id:";
            // 
            // IdNUAD
            // 
            this.IdNUAD.Location = new System.Drawing.Point(125, 145);
            this.IdNUAD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.IdNUAD.Name = "IdNUAD";
            this.IdNUAD.Size = new System.Drawing.Size(90, 20);
            this.IdNUAD.TabIndex = 18;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 177);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.IdNUAD);
            this.Controls.Add(this.DateL);
            this.Controls.Add(this.ExpiredDate);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.DescriptionL);
            this.Controls.Add(this.PriceL);
            this.Controls.Add(this.PriceNUAD);
            this.Controls.Add(this.TitleTb);
            this.Controls.Add(this.TitleL);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceNUAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNUAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label DateL;
        private System.Windows.Forms.DateTimePicker ExpiredDate;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.Label DescriptionL;
        private System.Windows.Forms.Label PriceL;
        private System.Windows.Forms.NumericUpDown PriceNUAD;
        private System.Windows.Forms.TextBox TitleTb;
        private System.Windows.Forms.Label TitleL;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.NumericUpDown IdNUAD;
    }
}