using Lottery.IDAL;
using Lottery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery.DAL
{
    public partial class UserInfoDAL : BaseDAL<UserInfo>, IUserInfoDAL
    {
        public bool Login()
        {
            return false;
        }
    }
}
