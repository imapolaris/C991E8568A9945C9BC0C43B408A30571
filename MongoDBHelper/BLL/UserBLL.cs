using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mayo.ArchiveManage.DB
{
    /// <summary>
    /// 用户 逻辑处理类
    /// </summary>
    public class UserBLL
    {
        UserDAL _dal = new UserDAL();

        #region ========用户========
        /// <summary>
        /// 增加一个用户
        /// </summary>
        /// <param name="user">用户</param>
        public void Insert(UserModel user)
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
        public UserModel Select(string strName)
        {
            return _dal.Select(strName);
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user">用户</param>
        public void Update(UserModel user)
        {
            _dal.Update(user);
        }

        /// <summary>
        /// 用户名和密码是否正确
        /// </summary>
        /// <param name="strUserName">用户名</param>
        /// <param name="strPwd">密码</param>
        /// <returns></returns>
        public bool IsValid(string strUserName, string strPwd)
        {
            return _dal.IsValid(strUserName, strPwd);
        }
        #endregion
    }
}
