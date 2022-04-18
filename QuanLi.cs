using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace KiemTra15p
{
    public partial class QuanLi : Form
    {
        SqlConnection scon = new SqlConnection("Data Source=DESKTOP-55T6STF\\VANDUNG;" +
            "Initial Catalog=KiemTra45;Integrated Security=True");
        public QuanLi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_Tl()
        {
            scon.Open();

            SqlCommand cmd = new SqlCommand("select *from TheLoai", scon);
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = cmd;
            cmd.Dispose();
            scon.Close();

            DataTable dt = new DataTable();
            dap.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["MaTL"] = "--Chọn Thể Loại--";
            dr["TenTL"] = "";
            dt.Rows.InsertAt(dr, 0);

            cbbTL.DataSource = dt;
            cbbTL.DisplayMember = "MaTL";
            cbbTL.ValueMember = "TenTL";

        }

        private void load_SP()
        {
            scon.Open();

            SqlCommand cmd = new SqlCommand("Select *from SanPham", scon);
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = cmd;
            cmd.Dispose();
            scon.Close();

            DataTable dt = new DataTable();
            dap.Fill(dt);

            dgrQl.DataSource = dt;
            dgrQl.Refresh();

            /* Data Binding là cách mapping các thành phần của một data source vào một
             thành phần GUI và tự động làm việc với dữ liệu*/

            /*Ví dụ có thể bind một cột(col) vào một TextBox qua thuộc tính Text hoặc có thể bind cả một
            table vào DataGrid như DataGridView*/


            txtMS.DataBindings.Clear();
            txtTD.DataBindings.Clear();
            txtG.DataBindings.Clear();
            txtSL.DataBindings.Clear();
            

            txtMS.DataBindings.Add("Text", dgrQl.DataSource, "MaSach");
            txtTD.DataBindings.Add("Text", dgrQl.DataSource, "TieuDe");
            txtG.DataBindings.Add("Text", dgrQl.DataSource, "Gia");
            txtSL.DataBindings.Add("Text", dgrQl.DataSource, "SoLuong");

            cbbTL.Enabled = false;
        }

        private void QuanLi_Load(object sender, EventArgs e)
        {
            load_SP();
            load_Tl();
            
            txtMS.Enabled = false;
            txtSL.Enabled = false;
            txtG.Enabled = false;
            txtTD.Enabled = false;

            btlLuu.Enabled = false;
            btlXoa.Enabled = false;
            btlThoat.Enabled = false;
        }

        private void btlThem_Click(object sender, EventArgs e)
        {
            txtMS.Enabled = true;
            txtSL.Enabled = true;
            txtG.Enabled = true;
            txtTD.Enabled = true;

            txtMS.Text = "";
            txtSL.Text = "";
            txtG.Text = "";
            txtTD.Text = "";

            txtMS.Focus();

            btlThem.Enabled = false;
            btlXoa.Enabled = false;
            btlLuu.Enabled = true;
            btlThoat.Enabled = true;
            cbbTL.Enabled = true;
             
        }

        private void txtMS_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgrQl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgrQl_CellClick(sender, e);
        }

        private void dgrQl_Click(object sender, EventArgs e)
        {

        }

        private void dgrQl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btlXoa.Enabled = true;
            btlThoat.Enabled = true;
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            string p_MaSach = txtMS.Text.Trim();
            string p_TieuDe = txtTD.Text.Trim();
            int p_Gia = int.Parse(txtG.Text.Trim());
            int p_SoLuong = int.Parse(txtSL.Text.Trim());
            string p_TheLoai = cbbTL.ValueMember.ToString();

            scon.Open();

            SqlCommand cmd = new SqlCommand("ThemMoiSanPham", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.NVarChar, 50).Value = p_MaSach;
            cmd.Parameters.Add("@TieuDe", SqlDbType.NVarChar, 50).Value = p_TieuDe;
            cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = p_Gia;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = p_SoLuong;
            cmd.Parameters.Add("@MaTL", SqlDbType.NVarChar, 50).Value = p_TheLoai;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            scon.Close();
            load_SP();

            MessageBox.Show("Thêm mới thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btlThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(dl == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void btlXoa_Click(object sender, EventArgs e)
        {
            string p_MaSach = txtMS.Text.Trim();

            scon.Open();

            SqlCommand cmd = new SqlCommand("XoaSanPham", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaSach", SqlDbType.NVarChar, 50).Value = p_MaSach;

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            scon.Close();
            load_SP();

            MessageBox.Show("Xóa thành công", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
