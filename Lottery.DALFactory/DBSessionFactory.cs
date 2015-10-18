using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Lottery.DALFactory
{
    public class DBSessionFactory
    {
        /// <summary>
        /// 保证DBSession线程内唯一
        /// </summary>
        /// <returns></returns>
        public static IDAL.IDBSession CreateDbSession()
        {
            IDAL.IDBSession DbSession = (IDAL.IDBSession)CallContext.GetData("dbSession");
            if (DbSession == null)
            {
                DbSession = new DALFactory.DBSession();
                CallContext.SetData("dbSession", DbSession);
            }
            return DbSession;
        }
    }
}
