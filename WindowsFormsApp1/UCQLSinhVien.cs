using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UCQLSinhVien : UserControl
    {
        QuanLySinhVienDataContext db = new QuanLySinhVienDataContext();
        public UCQLSinhVien()
        {
            InitializeComponent();
        }

        private void UCQLSinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDSLH4CBX();
        }

        public void LoadData()
        {
            List<SinhVien> dSSV = db.SinhViens.ToList();
            dgvSinhVien.DataSource = dSSV;
        }

        public void LoadDSLH4CBX()
        {
            List<LopHoc> dSLH = db.LopHocs.ToList();
            cboMaLop.DataSource = dSLH;
            cboMaLop.DisplayMember = "TenLop";
            cboMaLop.ValueMember = "MaLop";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.MSSV = txtMSSV.Text;
            sinhVien.HoTen = txtHoTen.Text;
            sinhVien.GioiTinh = cboGioiTinh.Text;
            sinhVien.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            sinhVien.MaLop = cboMaLop.SelectedValue.ToString();
            try
            {
                db.SinhViens.InsertOnSubmit(sinhVien);
                db.SubmitChanges();
                MessageBox.Show("Thêm mới sinh viên thành công");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
