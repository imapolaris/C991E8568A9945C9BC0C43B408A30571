using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

using Mayo.ArchiveManage.Utility;

namespace Mayo.ArchiveManage.DB
{
    /// <summary>
    /// 数据库操作 帮助类
    /// </summary>
    public class DBHelper
    {
        public DBHelper()
        {

        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        public static MongoDatabase ConnectDB()
        {
            var client = new MongoClient(ConfigHelper.ConnectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("AMDB");

            return database;
        }

    }
}
