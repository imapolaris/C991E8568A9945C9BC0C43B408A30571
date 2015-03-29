using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MongoDB.Bson;
using MongoDB.Driver.Builders;

namespace Mayo.ArchiveManage.DB
{
    /// <summary>
    /// 用户 数据访问类
    /// </summary>
    class UserDAL
    {
        #region ========用户========
        /// <summary>
        /// 增加一个用户
        /// </summary>
        /// <param name="user">用户</param>
        public void Insert(UserModel user)
        {
        }

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="strName">用户名</param>
        public void Delete(string strName)
        {
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="strName">用户名</param>
        public UserModel Select(string strName)
        {
            return null;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user">用户</param>
        public void Update(UserModel user)
        {
        }
        #endregion
    }
}
