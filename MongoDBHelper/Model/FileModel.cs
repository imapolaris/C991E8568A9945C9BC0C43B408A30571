using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson;

namespace Mayo.ArchiveManage.DB
{
    /// <summary>
    /// 文件实体类
    /// </summary>
    public class FileModel
    {
        int _categoryId = 0;
        string _fileName = null;
        long _size = 0;
        DateTime _createDate;

        /// <summary>
        /// ObjectId
        /// </summary>
        public ObjectId _id
        {
            get;
            set;
        }

        /// <summary>
        /// 分类ID
        /// </summary>
        public int CategoryID
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }

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
