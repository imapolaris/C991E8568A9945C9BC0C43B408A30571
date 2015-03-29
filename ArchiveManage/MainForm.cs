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

        /// <summary>
        /// 登录
        /// </summary>
        private void 登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.OperationChange += new LoginForm.ButtonClickHandler(AdminLoginSucceed);
            loginForm.ShowDialog();
        }

        /// <summary>
        /// 关于
        /// </summary>
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangPassword changePasswordForm = new ChangPassword();
            changePasswordForm.ShowDialog(); 
        }

        /// <summary>
        /// 管理员登录成功
        /// </summary>
        private void AdminLoginSucceed(object sender, EnterBtnClick args)
        {
            SetButtonEnable(true);
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetButtonEnable(false);
        }

        /// <summary>
        /// 设置操作是否可用
        /// </summary>
        /// <param name="bEnable"></param>
        private void SetButtonEnable(bool bEnable)
        {
            this.btnDelete.Enabled = bEnable;
            this.btnUpload.Enabled = bEnable;

            if (bEnable == true)
            {
                this.Text = "档案管理系统" + "(管理员)";
            }
            else
            {
                this.Text = "档案管理系统" + "(普通用户)";
            }
        }
    }
}
