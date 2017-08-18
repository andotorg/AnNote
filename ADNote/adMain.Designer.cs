namespace ADNote
{
    partial class adNoteFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adNoteFrom));
            this.btnClose = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.btnSamll = new System.Windows.Forms.Button();
            this.ntfMsg = new System.Windows.Forms.NotifyIcon(this.components);
            this.rightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.皮肤设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.rightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(265, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(34, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // txtEdit
            // 
            this.txtEdit.BackColor = System.Drawing.Color.PeachPuff;
            this.txtEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEdit.Location = new System.Drawing.Point(12, 35);
            this.txtEdit.MaxLength = 102767;
            this.txtEdit.Multiline = true;
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(282, 308);
            this.txtEdit.TabIndex = 0;
            this.txtEdit.TextChanged += new System.EventHandler(this.txtEdit_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "蚁点便签 beta 0.2";
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.Color.Transparent;
            this.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop.ForeColor = System.Drawing.Color.White;
            this.btnTop.Location = new System.Drawing.Point(232, -2);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(34, 23);
            this.btnTop.TabIndex = 3;
            this.btnTop.Text = "T";
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            this.btnTop.MouseLeave += new System.EventHandler(this.btnTop_MouseLeave);
            this.btnTop.MouseHover += new System.EventHandler(this.btnTop_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ADNote.Properties.Resources.andot;
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoStart.Location = new System.Drawing.Point(12, 349);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(72, 16);
            this.chkAutoStart.TabIndex = 5;
            this.chkAutoStart.Text = "开机启动";
            this.chkAutoStart.UseVisualStyleBackColor = false;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // btnSamll
            // 
            this.btnSamll.BackColor = System.Drawing.Color.Transparent;
            this.btnSamll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSamll.ForeColor = System.Drawing.Color.White;
            this.btnSamll.Location = new System.Drawing.Point(199, -2);
            this.btnSamll.Name = "btnSamll";
            this.btnSamll.Size = new System.Drawing.Size(34, 23);
            this.btnSamll.TabIndex = 3;
            this.btnSamll.Text = "-";
            this.btnSamll.UseVisualStyleBackColor = false;
            this.btnSamll.Click += new System.EventHandler(this.btnSamll_Click);
            this.btnSamll.MouseLeave += new System.EventHandler(this.btnSamll_MouseLeave);
            this.btnSamll.MouseHover += new System.EventHandler(this.btnSamll_MouseHover);
            // 
            // ntfMsg
            // 
            this.ntfMsg.BalloonTipText = "蚁点便签";
            this.ntfMsg.BalloonTipTitle = "andot.org";
            this.ntfMsg.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfMsg.Icon")));
            this.ntfMsg.Text = "蚁点便签";
            this.ntfMsg.Visible = true;
            this.ntfMsg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ntfMsg_MouseClick);
            this.ntfMsg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ntfMsg_MouseUp);
            // 
            // rightMenu
            // 
            this.rightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.皮肤设置ToolStripMenuItem});
            this.rightMenu.Name = "rightMenu";
            this.rightMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.rightMenu.Size = new System.Drawing.Size(125, 48);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 皮肤设置ToolStripMenuItem
            // 
            this.皮肤设置ToolStripMenuItem.Name = "皮肤设置ToolStripMenuItem";
            this.皮肤设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.皮肤设置ToolStripMenuItem.Text = "皮肤设置";
            this.皮肤设置ToolStripMenuItem.Click += new System.EventHandler(this.皮肤设置ToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(169, -2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // adNoteFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(306, 367);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSamll);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 0);
            this.Name = "adNoteFrom";
            this.Text = "蚁点便签 bate 0.2";
            this.Load += new System.EventHandler(this.adNoteFrom_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adNoteFrom_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.adNoteFrom_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.adNoteFrom_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.rightMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.Button btnSamll;
        private System.Windows.Forms.NotifyIcon ntfMsg;
        private System.Windows.Forms.ContextMenuStrip rightMenu;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 皮肤设置ToolStripMenuItem;
        public System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}

