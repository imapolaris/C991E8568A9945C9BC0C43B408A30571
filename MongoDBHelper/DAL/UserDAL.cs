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
    /// 数据访问类
    /// </summary>
    class UserDAL
    {
        #region ========用户========
        /// <summary>
        /// 增加一个用户
        /// </summary>
        /// <param name="user">用户</param>
        public void Insert(User user)
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
        public User Select(string strName)
        {
            return null;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="user">用户</param>
        public void Update(User user)
        {
        }

        #endregion

        #region ========文件========
        public void WriteFile(string fileName)
        {
            var database = DBHelper.ConnectDB();

            var newFileName = "D:\\new_Untitled.png";
            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                var gridFsInfo = database.GridFS.Upload(fs, fileName);
                var fileId = gridFsInfo.Id;

                ObjectId oid = new ObjectId(fileId.ToString());
                var file = database.GridFS.FindOne(Query.EQ("_id", oid));

                using (var stream = file.OpenRead())
                {
                    var bytes = new byte[stream.Length];
                    stream.Read(bytes, 0, (int)stream.Length);
                    using (var newFs = new FileStream(newFileName, FileMode.Create))
                    {
                        newFs.Write(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        #endregion
    }
}
