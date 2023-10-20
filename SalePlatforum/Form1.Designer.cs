namespace SalePlatforum
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.updateBtr1 = new Guna.UI2.WinForms.Guna2Button();
            this.addBtr = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-3, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 403);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // updateBtr1
            // 
            this.updateBtr1.Animated = true;
            this.updateBtr1.BorderRadius = 6;
            this.updateBtr1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtr1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtr1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtr1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtr1.FillColor = System.Drawing.Color.White;
            this.updateBtr1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.updateBtr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(10)))));
            this.updateBtr1.Location = new System.Drawing.Point(22, 94);
            this.updateBtr1.Name = "updateBtr1";
            this.updateBtr1.Size = new System.Drawing.Size(104, 45);
            this.updateBtr1.TabIndex = 3;
            this.updateBtr1.Text = "Update ";
            // 
            // addBtr
            // 
            this.addBtr.Animated = true;
            this.addBtr.BorderRadius = 6;
            this.addBtr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtr.FillColor = System.Drawing.Color.White;
            this.addBtr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.addBtr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(10)))));
            this.addBtr.Location = new System.Drawing.Point(22, 183);
            this.addBtr.Name = "addBtr";
            this.addBtr.Size = new System.Drawing.Size(104, 45);
            this.addBtr.TabIndex = 4;
            this.addBtr.Text = "Add";
            this.addBtr.Click += new System.EventHandler(this.addBtr_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(151, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 403);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addBtr);
            this.Controls.Add(this.updateBtr1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button updateBtr1;
        private Guna.UI2.WinForms.Guna2Button addBtr;
        private System.Windows.Forms.Panel panel1;
    }
}

