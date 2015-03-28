using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Mayo.ArchiveManage.Utility
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class ConfigHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["connectionstring"];
            }
        }
    }
}
