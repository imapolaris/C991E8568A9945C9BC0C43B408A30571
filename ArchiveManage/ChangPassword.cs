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
    public partial class ChangPassword : Form
    {
        public ChangPassword()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        /// <summary>
        /// 确定
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtOldPwd.Text == "123")
            {
                if (!string.IsNullOrEmpty(this.txtNewPwd.Text)
                    && !string.IsNullOrEmpty(this.txtNewPwd2.Text))
                {
                    if (this.txtNewPwd.Text == this.txtNewPwd2.Text)
                    {
                        MessageBox.Show("密码修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("两次输入新密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("新密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("旧密码不正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
=======
        private void enter_Click(object sender, EventArgs e)
        {
            if (current_password_label.Text=="password"&&new_password_label.Text==second_password_label.Text)
            {
                MessageBox.Show("密码修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("密码不一致");
            }

              
        }

        private void cancel_Click(object sender, EventArgs e)
>>>>>>> 35f8baaad018fa8842f31a4b48ff4acfff2ab16b
        {
            this.Close();
        }
    }
}
