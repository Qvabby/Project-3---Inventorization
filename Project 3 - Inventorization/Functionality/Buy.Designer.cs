namespace Project_3___Inventorization.Functionality
{
    partial class Buy
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
            this.IdNUAD = new System.Windows.Forms.NumericUpDown();
            this.IdL = new System.Windows.Forms.Label();
            this.BuyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdNUAD)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(181, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(52, 25);
            this.Title.TabIndex = 1;
            this.Title.Text = "BUY";
            // 
            // IdNUAD
            // 
            this.IdNUAD.Location = new System.Drawing.Point(53, 66);
            this.IdNUAD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.IdNUAD.Name = "IdNUAD";
            this.IdNUAD.Size = new System.Drawing.Size(95, 20);
            this.IdNUAD.TabIndex = 2;
            // 
            // IdL
            // 
            this.IdL.AutoSize = true;
            this.IdL.Location = new System.Drawing.Point(12, 68);
            this.IdL.Name = "IdL";
            this.IdL.Size = new System.Drawing.Size(19, 13);
            this.IdL.TabIndex = 3;
            this.IdL.Text = "Id:";
            // 
            // BuyBtn
            // 
            this.BuyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(170)))), ((int)(((byte)(150)))));
            this.BuyBtn.FlatAppearance.BorderSize = 0;
            this.BuyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyBtn.Location = new System.Drawing.Point(15, 142);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(61, 23);
            this.BuyBtn.TabIndex = 12;
            this.BuyBtn.Text = "Buy";
            this.BuyBtn.UseVisualStyleBackColor = false;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 177);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.IdL);
            this.Controls.Add(this.IdNUAD);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buy";
            this.Text = "Buy";
            ((System.ComponentModel.ISupportInitialize)(this.IdNUAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.NumericUpDown IdNUAD;
        private System.Windows.Forms.Label IdL;
        private System.Windows.Forms.Button BuyBtn;
    }
}