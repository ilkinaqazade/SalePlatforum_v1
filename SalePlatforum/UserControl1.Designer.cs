namespace SalePlatforum
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productNameLb = new System.Windows.Forms.Label();
            this.desciriptionProductLb = new System.Windows.Forms.Label();
            this.productPriceLb = new System.Windows.Forms.Label();
            this.productImageBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.productImageBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLb
            // 
            this.productNameLb.AutoSize = true;
            this.productNameLb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLb.Location = new System.Drawing.Point(159, 37);
            this.productNameLb.Name = "productNameLb";
            this.productNameLb.Size = new System.Drawing.Size(65, 22);
            this.productNameLb.TabIndex = 1;
            this.productNameLb.Text = "label1";
            // 
            // desciriptionProductLb
            // 
            this.desciriptionProductLb.AutoSize = true;
            this.desciriptionProductLb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desciriptionProductLb.Location = new System.Drawing.Point(319, 37);
            this.desciriptionProductLb.Name = "desciriptionProductLb";
            this.desciriptionProductLb.Size = new System.Drawing.Size(65, 22);
            this.desciriptionProductLb.TabIndex = 2;
            this.desciriptionProductLb.Text = "label2";
            // 
            // productPriceLb
            // 
            this.productPriceLb.AutoSize = true;
            this.productPriceLb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLb.Location = new System.Drawing.Point(498, 39);
            this.productPriceLb.Name = "productPriceLb";
            this.productPriceLb.Size = new System.Drawing.Size(65, 22);
            this.productPriceLb.TabIndex = 3;
            this.productPriceLb.Text = "label2";
            // 
            // productImageBox2
            // 
            this.productImageBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productImageBox2.FillColor = System.Drawing.Color.Black;
            this.productImageBox2.ImageRotate = 0F;
            this.productImageBox2.Location = new System.Drawing.Point(13, 13);
            this.productImageBox2.Name = "productImageBox2";
            this.productImageBox2.Size = new System.Drawing.Size(87, 75);
            this.productImageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImageBox2.TabIndex = 4;
            this.productImageBox2.TabStop = false;
            // 
            // productImageBox
            // 
            this.productImageBox.BackColor = System.Drawing.SystemColors.Control;
            this.productImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productImageBox.ImageRotate = 0F;
            this.productImageBox.Location = new System.Drawing.Point(0, 0);
            this.productImageBox.Name = "productImageBox";
            this.productImageBox.Size = new System.Drawing.Size(632, 100);
            this.productImageBox.TabIndex = 0;
            this.productImageBox.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productImageBox2);
            this.Controls.Add(this.productPriceLb);
            this.Controls.Add(this.desciriptionProductLb);
            this.Controls.Add(this.productNameLb);
            this.Controls.Add(this.productImageBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(632, 100);
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox productImageBox;
        private System.Windows.Forms.Label productNameLb;
        private System.Windows.Forms.Label desciriptionProductLb;
        private System.Windows.Forms.Label productPriceLb;
        private Guna.UI2.WinForms.Guna2PictureBox productImageBox2;
    }
}
