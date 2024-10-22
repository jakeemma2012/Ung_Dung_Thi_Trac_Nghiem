using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_Thi_Trac_Nghiem
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            string imagepath = Path.Combine(Application.StartupPath, "Images", "anhTrangChu.png");
            imgTrangChu.Image = Image.FromFile(imagepath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void showOrHidePasswordChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = btHidePass.Checked ? '\0' : '*';
        }

        private void labelRegisterCLick(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister(this);
            frm.Show();
            this.Hide();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
