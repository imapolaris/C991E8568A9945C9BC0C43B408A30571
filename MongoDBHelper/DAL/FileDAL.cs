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
    /// 文件 数据访问类
    /// </summary>
    class FileDAL
    {
        #region ========文件========
        /// <summary>
        /// 增加一个文件
        /// </summary>
        /// <param name="user">文件</param>
        public void Insert(FileModel file)
        {
        }

        /// <summary>
        /// 删除一个文件
        /// </summary>
        /// <param name="strName">文件名</param>
        public void Delete(string strName)
        {
        }

        /// <summary>
        /// 查询文件信息
        /// </summary>
        /// <param name="strName">文件名</param>
        public FileModel Select(string strName)
        {
            return null;
        }

        /// <summary>
        /// 修改文件信息
        /// </summary>
        /// <param name="user">文件</param>
        public void Update(FileModel file)
        {
        }

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
