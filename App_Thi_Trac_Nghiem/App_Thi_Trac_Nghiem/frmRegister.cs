using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Thi_Trac_Nghiem
{
    public partial class frmRegister : Form
    {
        private Form parent;
        public frmRegister(Form p)
        {
            InitializeComponent();
            string imagepath = Path.Combine(Application.StartupPath, "Images", "anhTrangChu.png");
            imgTrangChu.Image = Image.FromFile(imagepath);
            this.parent = p;
        }

        private void labelSignin_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void labelClose_CLick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btHidePass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = btHidePass.Checked ? '\0' : '*';
        }
    }
}
