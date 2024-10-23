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
using App_Thi_Trac_Nghiem_DAL.Model;
using App_Thi_Trac_Nghiem_BUS;
namespace App_Thi_Trac_Nghiem
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        private Model1 context = AccountServices.gI().context;

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
            if (isValidLogin())
            {
                Account acc = AccountServices.gI().getAccountLogin(txtUsername.Text);
                if (acc != null)
                {
                    if (txtPassword.Text.CompareTo(acc.Password) == 0)
                    {
                        MessageBox.Show("Đăng nhập thành công !", "Thông báo !", MessageBoxButtons.OK);
                        this.Hide();

                        if (acc.Role > 0)
                        {
                            frmMain frm = new frmMain();
                            frm.Show();
                        } else {
                        frmReadyTest frm = new frmReadyTest();
                            frm.Show();
                        }
                    } else
                    {
                        MessageBox.Show("Mật khẩu không chính xác !","Thông báo !"
                            ,MessageBoxButtons.OK);
                    }
                } else
                {
                    MessageBox.Show("Tài khoản không tồn tại !", "Thông báo !"
                            , MessageBoxButtons.OK);
                }
            } else
            {
                MessageBox.Show("Hãy điền tài khoản và mật khẩu để đăng nhập !"
                    ,"Thông báo",MessageBoxButtons.OK);
            }
        }

        bool isValidLogin()
        {
            return txtUsername.Text.Trim() != ""
                && txtPassword.Text.Trim() != "";
        }
    }
}
