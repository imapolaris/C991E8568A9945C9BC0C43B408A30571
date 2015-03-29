using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        /// <param name="user">文件</param>
        public void Insert(FileModel file)
        {
            _dal.Insert(file);
        }

        /// <summary>
        /// 删除一个文件
        /// </summary>
        /// <param name="strName">文件名</param>
        public void Delete(string strName)
        {
            _dal.Delete(strName);
        }

        /// <summary>
        /// 查询文件信息
        /// </summary>
        /// <param name="strName">文件名</param>
        public FileModel Select(string strName)
        {
            return _dal.Select(strName);
        }

        /// <summary>
        /// 修改文件信息
        /// </summary>
        /// <param name="user">文件</param>
        public void Update(FileModel file)
        {
            _dal.Update(file);
        }
        #endregion
    }
}
