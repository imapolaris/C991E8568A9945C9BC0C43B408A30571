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
    public partial class LoginForm : Form
    {
<<<<<<< HEAD
        // 委托定义
=======

        /// <summary>
        /// 委托定义
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
>>>>>>> 35f8baaad018fa8842f31a4b48ff4acfff2ab16b
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
<<<<<<< HEAD

=======
>>>>>>> 35f8baaad018fa8842f31a4b48ff4acfff2ab16b
        public LoginForm()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        /// <summary>
        /// 登录
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin"&& txtPwd.Text=="123")
            {
                // 触发事件， 传递自定义参数
                OnEnterBtnclick(this, new EnterBtnClick());

=======
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin"&& textBox2.Text=="password")
            {
                // 触发事件， 传递自定义参数
                OnEnterBtnclick(this, new EnterBtnClick());
>>>>>>> 35f8baaad018fa8842f31a4b48ff4acfff2ab16b
                this.Close();
            }
            else
            {
<<<<<<< HEAD
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
=======
                MessageBox.Show("密码或账号不正确");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

>>>>>>> 35f8baaad018fa8842f31a4b48ff4acfff2ab16b
    }
}

/// <summary>
/// 自定义事件参数类型，根据需要可设定多种参数便于传递
/// </summary>
public class EnterBtnClick : EventArgs
{
<<<<<<< HEAD
    public EnterBtnClick()
    {
        MessageBox.Show("登陆成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
=======

    public EnterBtnClick()
    {
        MessageBox.Show("登陆成功，时间出发");
>>>>>>> 35f8baaad018fa8842f31a4b48ff4acfff2ab16b
    }
}
