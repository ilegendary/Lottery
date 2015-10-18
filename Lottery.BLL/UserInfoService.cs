using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lottery.IBLL;
using Lottery.Model;

namespace Lottery.BLL
{
    public partial class UserInfoService : BaseService<UserInfo>, IUserInfoService
    {
        public bool Login()
        {
            return this.GetCurrentDbSession.UserInfoDAL.Login();
        }
    }
}
