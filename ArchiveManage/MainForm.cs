using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mayo.ArchiveManage
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }
       

        private void 登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.OperationChange += new LoginForm.ButtonClickHandler(ChangeToDownload);
            loginForm.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangPassword changePasswordForm = new ChangPassword();
            changePasswordForm.Show(); 
        }
        private void ChangeToDownload(object sender, EnterBtnClick args)
        {
            btnDownload.Visible = true;
            btnDownload.Show();
            MessageBox.Show("change download right");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
