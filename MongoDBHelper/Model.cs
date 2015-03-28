using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Mayo.ArchiveManage.DB
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    class User
    {
        string _userName = null;
        string _password = null;
        bool _isAdmin = false;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        /// <summary>
        /// 是否是管理员
        /// </summary>
        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }
    }

    /// <summary>
    /// 文件实体类
    /// </summary>
    class ArchiveFile
    {
        string _fileName = null;
        long _size = 0;
        DateTime _createDate;

        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        /// <summary>
        /// 大小
        /// </summary>
        public long Size
        {
            get { return _size; }
            set { _size = value; }
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        //public FileStream 
    }
}
