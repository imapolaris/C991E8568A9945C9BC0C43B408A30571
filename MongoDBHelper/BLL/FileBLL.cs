using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mayo.ArchiveManage.Utility;
using System.Data;
using MongoDB.Bson;

namespace Mayo.ArchiveManage.DB
{
    /// <summary>
    /// 文件 逻辑处理类
    /// </summary>
    public class FileBLL
    {
        FileDAL _dal = new FileDAL();

        #region ========文件========
        /// <summary>
        /// 增加一个文件
        /// </summary>
        /// <param name="strFileName">文件名</param>
        public void Upload(Category category, string strFileName)
        {
            _dal.Upload(category, strFileName);
        }

        /// <summary>
        /// 删除一个文件
        /// </summary>
        /// <param name="_id">_id</param>
        public void Delete(string _id)
        {
            _dal.Delete(_id);
        }

        /// <summary>
        /// 查询文件信息
        /// </summary>
        /// <param name="strName">文件名</param>
        public DataTable Select(Category category, string strFileName="")
        {
            var fileList = _dal.Select(category, strFileName);

            DataTable dt = new DataTable();

            DataColumn column = new DataColumn("FileName", typeof(string));
            dt.Columns.Add(column);
            column = new DataColumn("Size", typeof(string));
            dt.Columns.Add(column);
            column = new DataColumn("CreateDate", typeof(DateTime));
            dt.Columns.Add(column);
            column = new DataColumn("ID", typeof(string));
            dt.Columns.Add(column);

            foreach (var item in fileList)
            {
                DataRow row = dt.Rows.Add();
                string strFileName2 = item.Name.ToString();
                strFileName2 = System.IO.Path.GetFileName(strFileName2);
                row["FileName"] = strFileName2;
                row["Size"] = item.Length + "B";
                row["CreateDate"] = item.UploadDate.ToString("yyyy-MM-dd hh:mm:ss");
                row["ID"] = item.Metadata["ID"];
            }

            return dt;
        }

        //下载文件
        public void Download(string _id, string strFileName)
        {
            _dal.Download(_id, strFileName);
        }
        #endregion
    }
}
