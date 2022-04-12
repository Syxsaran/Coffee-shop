namespace Coffee_shop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string str, str1;
            double C1, C2, C3, C4, D1, D2, D3, D4;
            str = "";
            if (radioButtonBoy.Checked == true)
            {
                str = "นาย " + textBoxName.Text;
            }
            if (radioButtonGirl.Checked == true)
            {
                str = "นาง/นางสาว" + textBoxName.Text;
            }
            str += "\r\n\nวัน/เดือน/ปี : " + comboBoxDay.Text + comboBoxMonth.Text + comboBoxYears.Text;
            str += "\r\n\nที่อยู่ : " + textBoxLocation.Text;
            str += "\r\n\nอีเมล : " + textBoxMail.Text;
            str += "\r\n\nเบอร์ติดต่อ : " + textBoxPhoneNumber.Text;
            textBoxData.Text = str;
            str1 = "";

            if (radioButtonAmericano.Checked == true)
            {
                str1 += "Americano     ราคา 50 บาท \r\n\n";
                C1 = 50;
            }
            else
            {
                C1 = 0;
            }
            if (radioButtonCappuccino.Checked == true)
            {
                str1 += "Cappuccino    ราคา 70 บาท \r\n\n";
                C2 = 70;
            }
            else
            {
                C2 = 0;
            }
            if (radioButtonEspresso.Checked == true)
            {
                str1 += "Espresso    ราคา 80 บาท \r\n\n";
                C3 = 80;
            }
            else
            {
                C3 = 0;
            }
            if (radioButtonLatte.Checked == true)
            {
                str1 += "Latte   ราคา 60 บาท \r\n\n";
                C4 = 60;
            }
            else
            {
                C4 = 0;
            }
            if (radioButtonBread.Checked == true)
            {
                str1 += "Bread   ราคา 40 บาท \r\n\n";
                D1 = 40;
            }
            else
            {
                D1 = 0;
            }
            if (radioButtonBrownie.Checked == true)
            {
                str1 += "Brownie   ราคา 30 บาท \r\n\n";
                D2 = 30;
            }
            else
            {
                D2 = 0;
            }
            if (radioButtonCookie.Checked == true)
            {
                str1 += "Cookie  ราคา 60 บาท \r\n\n";
                D3 = 60;
            }
            else
            {
                D3 = 0;
            }
            if (radioButtonSandwich.Checked == true)
            {
                str1 += "Sandwich   ราคา 20 บาท \r\n\n";
                D4 = 20;
            }
            else
            {
                D4 = 0;
            }

            double Sum = C1 + C2 + C3 + C4 + D1 + D2 + D3 + D4;
            str1 += ("ทั้งหมด" + Sum + "บาท");
            textBoxBill.Text = str1;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxBill.Text = "";
            textBoxData.Text = "";
        }


    }
}
