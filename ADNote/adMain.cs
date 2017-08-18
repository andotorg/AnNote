using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADNote
{

    public partial class adNoteFrom : Form
    {
        Point mouseOff;//鼠标移动位置变量
        bool leftFlag;//标签是否为左键
        private bool noteTop = false;  //窗体置顶
        bool isMouseDown = false; //表示鼠标当前是否处于按下状态，初始值为否 
        bool show = false; //右键菜单显示
        public adNoteFrom()
        {
            InitializeComponent();
        }

        private void adNoteFrom_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }

        private void adNoteFrom_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

        private void adNoteFrom_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            this.btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.BackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTop_MouseHover(object sender, EventArgs e)
        {
            this.btnTop.BackColor = Color.Green;
        }

        private void btnTop_MouseLeave(object sender, EventArgs e)
        {
            this.btnTop.BackColor = Color.Transparent;
        }

        /// <summary>
        /// 设置窗口置顶显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTop_Click(object sender, EventArgs e)
        {
            if (noteTop)
            {
                this.TopMost = false;
                noteTop = false;
                this.btnTop.Text = "T";
            }
            else
            {
                this.TopMost = true;
                noteTop = true;
                this.btnTop.Text = "/";
            }

        }

        /// <summary>
        /// 设置开机启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkAutoStart.Checked) //设置开机自启动  
                {
                    MessageBox.Show("设置开机自启动", "蚁点便签提示");
                    string path = Application.ExecutablePath;
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                    rk2.SetValue("JcShutdown", path);
                    rk2.Close();
                    rk.Close();
                }
                else //取消开机自启动  
                {
                    MessageBox.Show("取消开机自启动", "蚁点便签提示");
                    string path = Application.ExecutablePath;
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                    rk2.DeleteValue("JcShutdown", false);
                    rk2.Close();
                    rk.Close();
                }
            }
            catch { }
            
        }

        /// <summary>
        /// 当程序启动的时候加载上次保存的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adNoteFrom_Load(object sender, EventArgs e)
        {
            this.ntfMsg.Visible = true;//在通知区显示Form的Icon
            this.ShowInTaskbar = false;//使Form不在任务栏上显示
            try
            {
                string fileName = @"c:\adNote\adnote.txt";
                StreamReader sr = File.OpenText(fileName);
                string str = "";
                string text = "";
                while ((str = sr.ReadLine()) != null)
                {
                    str += "\r\n";
                    text += str;
                }
                sr.Close();
                this.txtEdit.Text = text;
                this.txtEdit.SelectionStart = text.Length;
                this.txtEdit.SelectionLength = 0;
            }
            catch {

            }
            int xWidth = SystemInformation.PrimaryMonitorSize.Width;//获取显示器屏幕宽度
            int yHeight = SystemInformation.PrimaryMonitorSize.Height;//高度
            this.Location = new Point(xWidth-450, 50);

        }

        /// <summary>
        /// 文本发生改变时保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEdit_TextChanged(object sender, EventArgs e)
        {
            if (this.txtEdit.Lines.Count() > 15)
            {
                this.txtEdit.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                this.txtEdit.ScrollBars = ScrollBars.None;
            }
            string activeDir = @"C:\";
            string newPath = System.IO.Path.Combine(activeDir, "adNote");
            System.IO.Directory.CreateDirectory(newPath);
            // 文件名
            string fileName = @"c:\adNote\adnote.txt";
            // 创建文件，准备写入
            FileStream fs = File.Open(fileName,
                    FileMode.Create,
                    FileAccess.Write);
            StreamWriter wr = new StreamWriter(fs);

            // 逐行将txtEdit的内容写入到文件中
            foreach (string line in txtEdit.Lines)
            {
                line.Replace("\n", "\r\n");
                wr.WriteLine(line);

            }

            // 关闭文件
            wr.Flush();
            wr.Close();
            fs.Close();
        }

        private void btnSamll_MouseHover(object sender, EventArgs e)
        {
            this.btnSamll.BackColor = Color.Gray;
        }

        private void btnSamll_MouseLeave(object sender, EventArgs e)
        {
            this.btnSamll.BackColor = Color.Transparent;
        }

        private void btnSamll_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;  //显示在系统任务栏
            this.WindowState = FormWindowState.Minimized;
        }

        private void ntfMsg_MouseClick(object sender, MouseEventArgs e)
        {
            if (show)
            {
                show = false;
                this.rightMenu.Hide();
            } 
            else
            {
                show = true;
                this.rightMenu.Show();
                this.rightMenu.Location = new Point(Screen.PrimaryScreen.Bounds.Width-400, Screen.PrimaryScreen.Bounds.Height-50);
            }
            
        }

        private void ntfMsg_MouseUp(object sender, MouseEventArgs e)
        {
            if (show)
            {
                show = false;
                this.rightMenu.Hide();
            }
        }

        private void 皮肤设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinSetting skin = new skinSetting(this);
            skin.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            adNoteFrom admain = new adNoteFrom();
            admain.Show();
        }
        
    }
}
