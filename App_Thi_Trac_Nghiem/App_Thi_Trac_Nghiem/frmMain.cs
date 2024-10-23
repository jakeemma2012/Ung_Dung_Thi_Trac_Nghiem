using DevExpress.XtraEditors;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Thi_Trac_Nghiem
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {

        private IconButton curentButton;
        private Panel leftBorderAdd;


        public frmMain()
        {
            InitializeComponent();
            leftBorderAdd = new Panel();
            leftBorderAdd.Size = new Size(7,50);
            this.Controls.Add(leftBorderAdd);
        }


        private void ActiveButton(object senderBtn , Color color)
        {
            if (senderBtn != null)
            {
                DisactiveButton();
                curentButton = (IconButton)senderBtn;
                curentButton.BackColor = Color.FromArgb(37,36,81);
                curentButton.ForeColor = color;
                curentButton.TextAlign = ContentAlignment.MiddleCenter;
                curentButton.IconColor = color;
                curentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                curentButton.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderAdd.BackColor = color;
                leftBorderAdd.Location = new Point(0,curentButton.Location.Y);
                leftBorderAdd.Visible = true;
                leftBorderAdd.BringToFront();
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void DisactiveButton()
        {
            if (curentButton != null)
            {
                curentButton.BackColor = Color.FromArgb(31,30,68);
                curentButton.ForeColor = Color.Gainsboro;
                curentButton.TextAlign = ContentAlignment.MiddleLeft;
                curentButton.IconColor = Color.Gainsboro;
                curentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                curentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btQuanly_Click(object sender, EventArgs e)
        {
            ActiveButton(sender,RGBColors.color1);
            frmThiSinh frm = new frmThiSinh();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;    
            frm.Show();
        }

        private void btThiSinh_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
        }

    }
}