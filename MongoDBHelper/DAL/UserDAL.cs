﻿using System;
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
            var database = DBHelper.ConnectDB();
            var collection = database.GetCollection<UserModel>("Users");
            var result = collection.Insert<UserModel>(user);
        }

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="strName">用户名</param>
        public void Delete(string strName)
        {
            var database = DBHelper.ConnectDB();
            var collection = database.GetCollection<UserModel>("Users");
            var result = collection.Remove(Query.EQ("UserName", strName));
        }

        /// <summary>
        /// 查询用户信息
        /// </summary>
        /// <param name="strName">用户名</param>
        public UserModel Select(string strName)
        {
            var database = DBHelper.ConnectDB();
            var collection = database.GetCollection<UserModel>("Users");
            var user = collection.FindOne(Query.EQ("UserName", strName));
            return user;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user">用户</param>
        public void Update(UserModel user)
        {
            var database = DBHelper.ConnectDB();
            var collection = database.GetCollection<UserModel>("Users");
            var update = Update<UserModel>.Replace(user);
            var result = collection.Update(Query.EQ("UserName", user.UserName), update);
        }

        /// <summary>
        /// 用户名和密码是否正确
        /// </summary>
        /// <param name="strUserName">用户名</param>
        /// <param name="strPwd">密码</param>
        /// <returns></returns>
        public bool IsValid(string strUserName, string strPwd)
        {
            var database = DBHelper.ConnectDB();
            var collection = database.GetCollection<UserModel>("Users");
            var user = collection.Find(Query.And(Query.EQ("UserName", strUserName), Query.EQ("Password", strPwd)));
            if (user == null || user.Count() <= 0)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
