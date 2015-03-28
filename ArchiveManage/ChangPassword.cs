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
        {
            this.Close();
        }
    }
}
