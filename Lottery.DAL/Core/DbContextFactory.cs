using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;
using Lottery.Model;

namespace Lottery.DAL
{
    public class DbContextFactory
    {
        public static DbContext CreateDbContext()
        {
            DbContext    dbcontext = (DbContext)CallContext.GetData("dbcontext");
            if (dbcontext == null)
            {
                //在这里实例化数据库上下文
                dbcontext = new LotteryContext();
                CallContext.SetData("dbcontext",dbcontext);
            }
            return dbcontext;
        }
    }
}
