using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int diemToan = Convert.ToInt32(maskedTextBox2.Text);
            int diemVan = Convert.ToInt32(maskedTextBox3.Text);
            int diemAnh = Convert.ToInt32(maskedTextBox4.Text);
            int tong = diemToan + diemVan + diemAnh;
            txttongdiem.Text = tong.ToString();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Bạn phải nhập họ tên !");
            else errorProvider1.SetError(textBox1, "");
        }

        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBox2.Text == "")
                errorProvider1.SetError(maskedTextBox2, "Bạn phải nhập điểm!");
            else
                try
                {
                    int diem = int.Parse(maskedTextBox2.Text);
                    if (0 < diem && diem > 10)
                        errorProvider1.SetError(maskedTextBox2, "Điểm không hợp lệ");
                    else
                        errorProvider1.SetError(maskedTextBox2, "");
                }
                catch
                {
                    errorProvider1.SetError(maskedTextBox2, "điểm phải là số");
                }
        }
        
    }
}
