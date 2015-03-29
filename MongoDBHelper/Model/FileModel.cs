using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mayo.ArchiveManage.DB
{
    /// <summary>
    /// 文件实体类
    /// </summary>
    public class FileModel
    {
        string _fileName = null;
        long _size = 0;
        DateTime _createDate;

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
