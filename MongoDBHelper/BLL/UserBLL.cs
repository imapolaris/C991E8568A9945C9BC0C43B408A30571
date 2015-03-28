using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mayo.ArchiveManage.DB
{
    /// <summary>
    /// 逻辑处理类
    /// </summary>
    class UserBLL
    {
        UserDAL _dal = new UserDAL();

        #region ========用户========
        /// <summary>
        /// 增加一个用户
        /// </summary>
        /// <param name="user">用户</param>
        public void Insert(User user)
        {
            _dal.Insert(user);
        }

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="strName">用户名</param>
        public void Delete(string strName)
        {
            _dal.Delete(strName);
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="strName">用户名</param>
        public User Select(string strName)
        {
            return _dal.Select(strName);
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user">用户</param>
        public void Update(User user)
        {
            _dal.Update(user);
        }
        #endregion

        #region ========文件========

        #endregion
    }
}
