namespace Coffee_shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonIntoShop = new System.Windows.Forms.Button();
            this.buttonOutShop = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(776, 426);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonIntoShop
            // 
            this.buttonIntoShop.Location = new System.Drawing.Point(363, 352);
            this.buttonIntoShop.Name = "buttonIntoShop";
            this.buttonIntoShop.Size = new System.Drawing.Size(75, 23);
            this.buttonIntoShop.TabIndex = 1;
            this.buttonIntoShop.Text = "สั่งซื้อสินค้า";
            this.buttonIntoShop.UseVisualStyleBackColor = true;
            this.buttonIntoShop.Click += new System.EventHandler(this.buttonIntoShop_Click);
            // 
            // buttonOutShop
            // 
            this.buttonOutShop.Location = new System.Drawing.Point(363, 396);
            this.buttonOutShop.Name = "buttonOutShop";
            this.buttonOutShop.Size = new System.Drawing.Size(75, 23);
            this.buttonOutShop.TabIndex = 2;
            this.buttonOutShop.Text = "ออกจากร้าน";
            this.buttonOutShop.UseVisualStyleBackColor = true;
            this.buttonOutShop.Click += new System.EventHandler(this.buttonOutShop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOutShop);
            this.Controls.Add(this.buttonIntoShop);
            this.Controls.Add(pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonIntoShop;
        private Button buttonOutShop;
    }
}