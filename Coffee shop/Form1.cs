﻿namespace Coffee_shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonOutShop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบคุณที่ใช้บริการครับ");
            Close();
        }

        private void buttonIntoShop_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }
    }
}