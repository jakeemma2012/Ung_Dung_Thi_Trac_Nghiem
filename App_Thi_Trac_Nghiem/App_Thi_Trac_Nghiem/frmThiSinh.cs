using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Thi_Trac_Nghiem_DAL.Model;
using App_Thi_Trac_Nghiem_BUS;

namespace App_Thi_Trac_Nghiem
{
    public partial class frmThiSinh : DevExpress.XtraEditors.XtraForm
    {
        public Model1 context = Services.getInstance().context;
        public frmThiSinh()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void frmThiSinh_Load(object sender, EventArgs e)
        {
            List<Student> studens = StudentServices.gI().getAllStudent();
            dgvThiSinh.Rows.Clear();

            foreach (var item in studens)
            {
                int rowsindex = dgvThiSinh.Rows.Add();
                dgvThiSinh.Rows[rowsindex].Cells[0].Value = item.StudentID;
                dgvThiSinh.Rows[rowsindex].Cells[1].Value = item.StudentName;
                dgvThiSinh.Rows[rowsindex].Cells[2].Value = item.Address;
                dgvThiSinh.Rows[rowsindex].Cells[3].Value = item.Birt.ToString("dd/MM/yyyy");
                dgvThiSinh.Rows[rowsindex].Cells[4].Value = item.School;
                dgvThiSinh.Rows[rowsindex].Cells[5].Value = item.Class;
            }

        }

    }
}