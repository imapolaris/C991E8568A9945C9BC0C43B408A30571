﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Mayo.ArchiveManage.DB;
using Mayo.ArchiveManage.Utility;
using System.IO;

namespace Mayo.ArchiveManage
{
    public partial class MainForm : Form
    {
        //private DataTable dt = null; // 数据
        private Category _curCategory = Category.Bulletin;
       
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载窗体
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            BindingData(Category.Bulletin);
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
            //this.btnDownload.Enabled = bEnable;
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

        #region ========工具栏========
        /// <summary>
        /// 通知公告
        /// </summary>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.lblCategory.Text = "通知公告";
            this._curCategory = Category.Bulletin;
            BindingData(Category.Bulletin);
        }

        /// <summary>
        /// 学院快讯
        /// </summary>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.lblCategory.Text = "学院快讯";
            this._curCategory = Category.CollegeNews;
            BindingData(Category.CollegeNews);
        }

        /// <summary>
        /// 教务通知
        /// </summary>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.lblCategory.Text = "教务通知";
            this._curCategory = Category.JWCNotice;
            BindingData(Category.JWCNotice);
        }

        /// <summary>
        /// 留言板
        /// </summary>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.lblCategory.Text = "留言板";
            this._curCategory = Category.MessageBoard;
            BindingData(Category.MessageBoard);
        }
        #endregion


        #region ========查询========
        /// <summary>
        /// 查询
        /// </summary>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strFileName = this.txtFileName.Text.Trim();

            BindingData(strFileName);
        }
        #endregion

        #region ========操作========
        /// <summary>
        /// 上传
        /// </summary>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();

            ofg.Title = "上传文件";
            ofg.Filter = "所有文件(*.*)|*.*";

            if (DialogResult.OK == ofg.ShowDialog())
            {
                string strFileName = ofg.FileName;
                
                FileBLL bll = new FileBLL();
                bll.Upload(this._curCategory, strFileName);

                BindingData(this._curCategory);
            }
        }

        /// <summary>
        /// 下载
        /// </summary>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (this.dgvFiles.SelectedRows == null || this.dgvFiles.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择要下载的文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfg = new SaveFileDialog();

            sfg.Title = "下载文件";
            sfg.Filter = "所有文件(*.*)|*.*";

            if (DialogResult.OK == sfg.ShowDialog())
            {
                string fileName = sfg.FileName;

                // 在数据库中查询文件
                FileBLL bll = new FileBLL();
                bll.Download(this.dgvFiles.SelectedRows[0].Cells[3].Value.ToString(), fileName);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvFiles.SelectedRows == null || this.dgvFiles.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择要删除的文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string _id = this.dgvFiles.SelectedRows[0].Cells[3].Value.ToString();
            // 在数据库中把文件删除
            FileBLL bll = new FileBLL();
            bll.Delete(_id);

            BindingData(this._curCategory);
        }
        #endregion

        #region ========绑定数据========
        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindingData(Category category)
        {
            FileBLL bll = new FileBLL();

            DataTable dt = bll.Select(category);

            this.dgvFiles.DataSource = dt.DefaultView;
        }

        /// <summary>
        /// 根据文件名检索数据
        /// </summary>
        /// <param name="strFileName">文件名</param>
        private void BindingData(string strFileName)
        {
            FileBLL bll = new FileBLL();

            DataTable dt = bll.Select(_curCategory, strFileName);

            this.dgvFiles.DataSource = dt.DefaultView;
        }
        #endregion
    }
}
