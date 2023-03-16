using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Ban co muon dong Form lai k ?", "FormClosing", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình ? ", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
                Close();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2(); 
            f1.MdiParent = this;
            f1.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  
            form3.MdiParent = this;
            form3.Show();
        }
    }
}

