using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADNote
{
    public partial class skinSetting : Form
    {
        private adNoteFrom admain;
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键

        public skinSetting(adNoteFrom admain)
        {
            InitializeComponent();
            this.admain = admain;
        }
        
        private void picTomato_Click(object sender, EventArgs e)
        {
            admain.txtEdit.BackColor = Color.Tomato;
            admain.BackColor = Color.Tomato;
        }

        private void picDefult_Click(object sender, EventArgs e)
        {
            admain.txtEdit.BackColor = Color.PeachPuff;
            admain.BackColor = Color.PeachPuff;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picFontWith_Click(object sender, EventArgs e)
        {
            admain.txtEdit.ForeColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            admain.txtEdit.ForeColor = Color.Black;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            admain.txtEdit.BackColor = Color.Honeydew;
            admain.BackColor = Color.Honeydew;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            admain.txtEdit.BackColor = Color.PaleTurquoise;
            admain.BackColor = Color.PaleTurquoise;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            admain.txtEdit.BackColor = Color.LightCyan;
            admain.BackColor = Color.LightCyan;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            admain.txtEdit.BackColor = Color.AliceBlue;
            admain.BackColor = Color.AliceBlue;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            admain.txtEdit.BackColor = Color.LightBlue;
            admain.BackColor = Color.LightBlue;
        }

        private void skinSetting_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void skinSetting_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void skinSetting_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void skinSetting_Load(object sender, EventArgs e)
        {
            int xWidth = SystemInformation.PrimaryMonitorSize.Width;//获取显示器屏幕宽度
            int yHeight = SystemInformation.PrimaryMonitorSize.Height;//高度
            this.Location = new Point(xWidth/2-200, 200);
        }
    }
}
