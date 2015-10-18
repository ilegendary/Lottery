using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery.IDAL
{
    public partial interface IDBSession
    {
        /// <summary>
        /// 保存数据的更改
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();
    }
}
