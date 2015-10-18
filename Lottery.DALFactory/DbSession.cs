using Lottery.DAL;
using Lottery.IDAL;
using Lottery.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.DALFactory
{
	public partial class DBSession : IDBSession
    {
	
		private IActivityStatesDAL _ActivityStatesDAL;
        public IActivityStatesDAL ActivityStatesDAL
        {
            get
            {
                if(_ActivityStatesDAL == null)
                {
				    _ActivityStatesDAL =AbstractFactory.CreateActivityStatesDAL();
                }
                return _ActivityStatesDAL;
            }
            set { _ActivityStatesDAL = value; }
        }
	
		private IAdInfoDAL _AdInfoDAL;
        public IAdInfoDAL AdInfoDAL
        {
            get
            {
                if(_AdInfoDAL == null)
                {
				    _AdInfoDAL =AbstractFactory.CreateAdInfoDAL();
                }
                return _AdInfoDAL;
            }
            set { _AdInfoDAL = value; }
        }
	
		private IAdminInfoDAL _AdminInfoDAL;
        public IAdminInfoDAL AdminInfoDAL
        {
            get
            {
                if(_AdminInfoDAL == null)
                {
				    _AdminInfoDAL =AbstractFactory.CreateAdminInfoDAL();
                }
                return _AdminInfoDAL;
            }
            set { _AdminInfoDAL = value; }
        }
	
		private IAdminUserRightsDAL _AdminUserRightsDAL;
        public IAdminUserRightsDAL AdminUserRightsDAL
        {
            get
            {
                if(_AdminUserRightsDAL == null)
                {
				    _AdminUserRightsDAL =AbstractFactory.CreateAdminUserRightsDAL();
                }
                return _AdminUserRightsDAL;
            }
            set { _AdminUserRightsDAL = value; }
        }
	
		private IAdTypeDAL _AdTypeDAL;
        public IAdTypeDAL AdTypeDAL
        {
            get
            {
                if(_AdTypeDAL == null)
                {
				    _AdTypeDAL =AbstractFactory.CreateAdTypeDAL();
                }
                return _AdTypeDAL;
            }
            set { _AdTypeDAL = value; }
        }
	
		private IAreaDAL _AreaDAL;
        public IAreaDAL AreaDAL
        {
            get
            {
                if(_AreaDAL == null)
                {
				    _AreaDAL =AbstractFactory.CreateAreaDAL();
                }
                return _AreaDAL;
            }
            set { _AreaDAL = value; }
        }
	
		private IBaseSetDAL _BaseSetDAL;
        public IBaseSetDAL BaseSetDAL
        {
            get
            {
                if(_BaseSetDAL == null)
                {
				    _BaseSetDAL =AbstractFactory.CreateBaseSetDAL();
                }
                return _BaseSetDAL;
            }
            set { _BaseSetDAL = value; }
        }
	
		private IInvitedRecordDAL _InvitedRecordDAL;
        public IInvitedRecordDAL InvitedRecordDAL
        {
            get
            {
                if(_InvitedRecordDAL == null)
                {
				    _InvitedRecordDAL =AbstractFactory.CreateInvitedRecordDAL();
                }
                return _InvitedRecordDAL;
            }
            set { _InvitedRecordDAL = value; }
        }
	
		private ILotteryActivityDAL _LotteryActivityDAL;
        public ILotteryActivityDAL LotteryActivityDAL
        {
            get
            {
                if(_LotteryActivityDAL == null)
                {
				    _LotteryActivityDAL =AbstractFactory.CreateLotteryActivityDAL();
                }
                return _LotteryActivityDAL;
            }
            set { _LotteryActivityDAL = value; }
        }
	
		private ILotteryOpenRecordDAL _LotteryOpenRecordDAL;
        public ILotteryOpenRecordDAL LotteryOpenRecordDAL
        {
            get
            {
                if(_LotteryOpenRecordDAL == null)
                {
				    _LotteryOpenRecordDAL =AbstractFactory.CreateLotteryOpenRecordDAL();
                }
                return _LotteryOpenRecordDAL;
            }
            set { _LotteryOpenRecordDAL = value; }
        }
	
		private IMessageInfoDAL _MessageInfoDAL;
        public IMessageInfoDAL MessageInfoDAL
        {
            get
            {
                if(_MessageInfoDAL == null)
                {
				    _MessageInfoDAL =AbstractFactory.CreateMessageInfoDAL();
                }
                return _MessageInfoDAL;
            }
            set { _MessageInfoDAL = value; }
        }
	
		private IMoneyChangeRecordDAL _MoneyChangeRecordDAL;
        public IMoneyChangeRecordDAL MoneyChangeRecordDAL
        {
            get
            {
                if(_MoneyChangeRecordDAL == null)
                {
				    _MoneyChangeRecordDAL =AbstractFactory.CreateMoneyChangeRecordDAL();
                }
                return _MoneyChangeRecordDAL;
            }
            set { _MoneyChangeRecordDAL = value; }
        }
	
		private INavInfoDAL _NavInfoDAL;
        public INavInfoDAL NavInfoDAL
        {
            get
            {
                if(_NavInfoDAL == null)
                {
				    _NavInfoDAL =AbstractFactory.CreateNavInfoDAL();
                }
                return _NavInfoDAL;
            }
            set { _NavInfoDAL = value; }
        }
	
		private INewsInfoDAL _NewsInfoDAL;
        public INewsInfoDAL NewsInfoDAL
        {
            get
            {
                if(_NewsInfoDAL == null)
                {
				    _NewsInfoDAL =AbstractFactory.CreateNewsInfoDAL();
                }
                return _NewsInfoDAL;
            }
            set { _NewsInfoDAL = value; }
        }
	
		private INewsTypeDAL _NewsTypeDAL;
        public INewsTypeDAL NewsTypeDAL
        {
            get
            {
                if(_NewsTypeDAL == null)
                {
				    _NewsTypeDAL =AbstractFactory.CreateNewsTypeDAL();
                }
                return _NewsTypeDAL;
            }
            set { _NewsTypeDAL = value; }
        }
	
		private IOpeateLogDAL _OpeateLogDAL;
        public IOpeateLogDAL OpeateLogDAL
        {
            get
            {
                if(_OpeateLogDAL == null)
                {
				    _OpeateLogDAL =AbstractFactory.CreateOpeateLogDAL();
                }
                return _OpeateLogDAL;
            }
            set { _OpeateLogDAL = value; }
        }
	
		private IOrderDetailDAL _OrderDetailDAL;
        public IOrderDetailDAL OrderDetailDAL
        {
            get
            {
                if(_OrderDetailDAL == null)
                {
				    _OrderDetailDAL =AbstractFactory.CreateOrderDetailDAL();
                }
                return _OrderDetailDAL;
            }
            set { _OrderDetailDAL = value; }
        }
	
		private IOrderMainDAL _OrderMainDAL;
        public IOrderMainDAL OrderMainDAL
        {
            get
            {
                if(_OrderMainDAL == null)
                {
				    _OrderMainDAL =AbstractFactory.CreateOrderMainDAL();
                }
                return _OrderMainDAL;
            }
            set { _OrderMainDAL = value; }
        }
	
		private IParticipateRecordDAL _ParticipateRecordDAL;
        public IParticipateRecordDAL ParticipateRecordDAL
        {
            get
            {
                if(_ParticipateRecordDAL == null)
                {
				    _ParticipateRecordDAL =AbstractFactory.CreateParticipateRecordDAL();
                }
                return _ParticipateRecordDAL;
            }
            set { _ParticipateRecordDAL = value; }
        }
	
		private IPayHistoryDAL _PayHistoryDAL;
        public IPayHistoryDAL PayHistoryDAL
        {
            get
            {
                if(_PayHistoryDAL == null)
                {
				    _PayHistoryDAL =AbstractFactory.CreatePayHistoryDAL();
                }
                return _PayHistoryDAL;
            }
            set { _PayHistoryDAL = value; }
        }
	
		private IProductDAL _ProductDAL;
        public IProductDAL ProductDAL
        {
            get
            {
                if(_ProductDAL == null)
                {
				    _ProductDAL =AbstractFactory.CreateProductDAL();
                }
                return _ProductDAL;
            }
            set { _ProductDAL = value; }
        }
	
		private IProductCategroyDAL _ProductCategroyDAL;
        public IProductCategroyDAL ProductCategroyDAL
        {
            get
            {
                if(_ProductCategroyDAL == null)
                {
				    _ProductCategroyDAL =AbstractFactory.CreateProductCategroyDAL();
                }
                return _ProductCategroyDAL;
            }
            set { _ProductCategroyDAL = value; }
        }
	
		private IProductImageDAL _ProductImageDAL;
        public IProductImageDAL ProductImageDAL
        {
            get
            {
                if(_ProductImageDAL == null)
                {
				    _ProductImageDAL =AbstractFactory.CreateProductImageDAL();
                }
                return _ProductImageDAL;
            }
            set { _ProductImageDAL = value; }
        }
	
		private IReceiveAddressDAL _ReceiveAddressDAL;
        public IReceiveAddressDAL ReceiveAddressDAL
        {
            get
            {
                if(_ReceiveAddressDAL == null)
                {
				    _ReceiveAddressDAL =AbstractFactory.CreateReceiveAddressDAL();
                }
                return _ReceiveAddressDAL;
            }
            set { _ReceiveAddressDAL = value; }
        }
	
		private IRightsInfoDAL _RightsInfoDAL;
        public IRightsInfoDAL RightsInfoDAL
        {
            get
            {
                if(_RightsInfoDAL == null)
                {
				    _RightsInfoDAL =AbstractFactory.CreateRightsInfoDAL();
                }
                return _RightsInfoDAL;
            }
            set { _RightsInfoDAL = value; }
        }
	
		private IRoleInfoDAL _RoleInfoDAL;
        public IRoleInfoDAL RoleInfoDAL
        {
            get
            {
                if(_RoleInfoDAL == null)
                {
				    _RoleInfoDAL =AbstractFactory.CreateRoleInfoDAL();
                }
                return _RoleInfoDAL;
            }
            set { _RoleInfoDAL = value; }
        }
	
		private IRoleRightsDAL _RoleRightsDAL;
        public IRoleRightsDAL RoleRightsDAL
        {
            get
            {
                if(_RoleRightsDAL == null)
                {
				    _RoleRightsDAL =AbstractFactory.CreateRoleRightsDAL();
                }
                return _RoleRightsDAL;
            }
            set { _RoleRightsDAL = value; }
        }
	
		private IShareInfoDAL _ShareInfoDAL;
        public IShareInfoDAL ShareInfoDAL
        {
            get
            {
                if(_ShareInfoDAL == null)
                {
				    _ShareInfoDAL =AbstractFactory.CreateShareInfoDAL();
                }
                return _ShareInfoDAL;
            }
            set { _ShareInfoDAL = value; }
        }
	
		private IShoppingCartDAL _ShoppingCartDAL;
        public IShoppingCartDAL ShoppingCartDAL
        {
            get
            {
                if(_ShoppingCartDAL == null)
                {
				    _ShoppingCartDAL =AbstractFactory.CreateShoppingCartDAL();
                }
                return _ShoppingCartDAL;
            }
            set { _ShoppingCartDAL = value; }
        }
	
		private ISiteBaseInfoDAL _SiteBaseInfoDAL;
        public ISiteBaseInfoDAL SiteBaseInfoDAL
        {
            get
            {
                if(_SiteBaseInfoDAL == null)
                {
				    _SiteBaseInfoDAL =AbstractFactory.CreateSiteBaseInfoDAL();
                }
                return _SiteBaseInfoDAL;
            }
            set { _SiteBaseInfoDAL = value; }
        }
	
		private IUserChargeRecordDAL _UserChargeRecordDAL;
        public IUserChargeRecordDAL UserChargeRecordDAL
        {
            get
            {
                if(_UserChargeRecordDAL == null)
                {
				    _UserChargeRecordDAL =AbstractFactory.CreateUserChargeRecordDAL();
                }
                return _UserChargeRecordDAL;
            }
            set { _UserChargeRecordDAL = value; }
        }
	
		private IUserInfoDAL _UserInfoDAL;
        public IUserInfoDAL UserInfoDAL
        {
            get
            {
                if(_UserInfoDAL == null)
                {
				    _UserInfoDAL =AbstractFactory.CreateUserInfoDAL();
                }
                return _UserInfoDAL;
            }
            set { _UserInfoDAL = value; }
        }
	}	
}