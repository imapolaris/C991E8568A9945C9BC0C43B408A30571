﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mayo.ArchiveManage
{
    public partial class LoginForm : Form
    {
        // 委托定义
        public delegate void ButtonClickHandler(object sender, EnterBtnClick args);
        // 声明事件
        public event ButtonClickHandler OperationChange;
        // 调用事件函数
        public void OnEnterBtnclick(object sender, EnterBtnClick args)
        {
            if (OperationChange != null)
            {
                OperationChange(this, args);
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin"&& txtPwd.Text=="123")
            {
                // 触发事件， 传递自定义参数
                OnEnterBtnclick(this, new EnterBtnClick());

                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码不正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {          
            this.Close();
        }
    }
}

/// <summary>
/// 自定义事件参数类型，根据需要可设定多种参数便于传递
/// </summary>
public class EnterBtnClick : EventArgs
{
    public EnterBtnClick()
    {
        MessageBox.Show("登陆成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}