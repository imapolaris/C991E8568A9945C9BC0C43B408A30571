using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using Mayo.ArchiveManage.Utility;
using MongoDB.Driver;
using System.Data;

namespace Mayo.ArchiveManage.DB
{
    /// <summary>
    /// 文件 数据访问类
    /// </summary>
    class FileDAL
    {
        #region ========文件========

        //获取文件列表
        public MongoCursor<MongoGridFSFileInfo> Select(Category category, string strFileName)
        {
            var database = DBHelper.ConnectDB();
            MongoGridFSSettings fsSetting = new MongoGridFSSettings() { Root = "Files" };
            MongoGridFS fs = new MongoGridFS(database, fsSetting);

            var collection = database.GetCollection("Files.files");

            MongoCursor<MongoGridFSFileInfo> fileList = null;
            if (string.IsNullOrEmpty(strFileName))
            {
                fileList = fs.Find(Query.EQ("metadata.CategoryID", (int)category));
            }
            else
            {
                fileList = fs.Find(Query.And(Query.EQ("metadata.CategoryID", (int)category), Query.Matches("filename", strFileName)));
            }

            return fileList;
        }

        //上传文件
        public void Upload(Category category, string strFileName)
        {
            using (FileStream fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read))
            {
                long nFileLen = fs.Length;

                var database = DBHelper.ConnectDB();
                MongoGridFSSettings fsSetting = new MongoGridFSSettings() { Root = "Files" };
                MongoGridFS gfs = new MongoGridFS(database, fsSetting);

                //通过Metadata 添加附加信息
                MongoGridFSCreateOptions option = new MongoGridFSCreateOptions();
                option.UploadDate = DateTime.Now;

                BsonDocument doc = new BsonDocument();
                doc.Add("CategoryID", (int)category);
                doc.Add("ID", Guid.NewGuid().ToString());
                option.Metadata = doc;

                byte[] myData = new byte[nFileLen];
                fs.Read(myData, 0, (int)nFileLen);
                //创建文件，文件并存储数据
                using (MongoGridFSStream gffs = gfs.Create(strFileName, option))
                {
                    gffs.Write(myData, 0, (int)nFileLen);
                    gffs.Close();
                }
            }
        }

        //删除文件
        public void Delete(string _id)
        {
            var database = DBHelper.ConnectDB();
            MongoGridFSSettings fsSetting = new MongoGridFSSettings() { Root = "Files" };
            MongoGridFS fs = new MongoGridFS(database, fsSetting);

            fs.Delete(Query.EQ("metadata.ID", _id));
        }

        //下载文件
        public void Download(string _id, string strFileName)
        {
            var database = DBHelper.ConnectDB();
            MongoGridFSSettings fsSetting = new MongoGridFSSettings() { Root = "Files" };
            MongoGridFS fs = new MongoGridFS(database, fsSetting);

            MongoGridFSFileInfo gfsInfo = fs.FindOne(Query.EQ("metadata.ID", _id));

            MongoGridFSStream gfs = gfsInfo.OpenRead();
            byte[] bytes = new byte[gfs.Length];
            gfs.Read(bytes, 0, bytes.Length);

            FileStream fst = new FileStream(strFileName, FileMode.OpenOrCreate, FileAccess.Write);
            fst.Write(bytes, 0, bytes.Length);

            fst.Flush();
            fst.Close();
        }
        #endregion
    }
}
