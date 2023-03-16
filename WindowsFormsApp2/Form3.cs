using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lstNuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNuoc.Text = lstNuoc.Items[lstNuoc.SelectedIndex].ToString();
        }
        
            // lay du lieu tu bang sql
        private DataTable layForm3()
        {
            string str = ConfigurationManager.ConnectionStrings["ql_Sinhvien"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from  dbo.Sinhvien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb= new DataTable("SV");
                        ad.Fill(tb);
                        return tb;
               
                    }


                }
            }
        }
        // hien du lieu
        private void hiendsSV()
        {
            DataTable t = layForm3();
            DataView v = new DataView(t);
            v.Sort = "sHoten";
            comboBox1.DataSource = v;
            comboBox1.DisplayMember = "sHoten";
            comboBox1.ValueMember = "Masv";



        }
        private void loaddsSV()
        {
            string str = ConfigurationManager.ConnectionStrings["ql_Sinhvien"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("Select Masv as[MÃ sinh viên], sHoten as[Họ tên],dNgaysinh as [Ngày sinh], sGioitinh as [Giới tính]  from  dbo.Sinhvien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open(); 

                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        dataGridView_SV.DataSource = tb;    

                    }


                }
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            lstNuoc.Items.Add("Nga");
            lstNuoc.Items.Add("Pháp");
            lstNuoc.Items.Add("Anh");
            lstNuoc.Items.Add("Việt Nam");
            hiendsSV();
            loaddsSV();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Ban da chon sinh vien : {0} co ma sinh vien la {1}", comboBox1.Text, comboBox1.SelectedValue), "Thong bao", MessageBoxButtons.OK);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
