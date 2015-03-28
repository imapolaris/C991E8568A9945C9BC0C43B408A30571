using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mayo.ArchiveManage.Utility
{
    /// <summary>
    /// 档案文件分类
    /// </summary>
    enum Category : int
    {
        // 通知公告
        Bulletin = 0,

        // 学院快讯
        CollegeNews,

        // 教务通知
        JWCNotice,

        // 留言板
        MessageBoard,
    }
}
