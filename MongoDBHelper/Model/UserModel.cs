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
}
