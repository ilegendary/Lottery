using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.IDAL
{
	public partial interface IDBSession
    {
	
		IActivityStatesDAL ActivityStatesDAL{get;set;}
	
		IAdInfoDAL AdInfoDAL{get;set;}
	
		IAdminInfoDAL AdminInfoDAL{get;set;}
	
		IAdminUserRightsDAL AdminUserRightsDAL{get;set;}
	
		IAdTypeDAL AdTypeDAL{get;set;}
	
		IAreaDAL AreaDAL{get;set;}
	
		IBaseSetDAL BaseSetDAL{get;set;}
	
		IInvitedRecordDAL InvitedRecordDAL{get;set;}
	
		ILotteryActivityDAL LotteryActivityDAL{get;set;}
	
		ILotteryOpenRecordDAL LotteryOpenRecordDAL{get;set;}
	
		IMessageInfoDAL MessageInfoDAL{get;set;}
	
		IMoneyChangeRecordDAL MoneyChangeRecordDAL{get;set;}
	
		INavInfoDAL NavInfoDAL{get;set;}
	
		INewsInfoDAL NewsInfoDAL{get;set;}
	
		INewsTypeDAL NewsTypeDAL{get;set;}
	
		IOpeateLogDAL OpeateLogDAL{get;set;}
	
		IOrderDetailDAL OrderDetailDAL{get;set;}
	
		IOrderMainDAL OrderMainDAL{get;set;}
	
		IParticipateRecordDAL ParticipateRecordDAL{get;set;}
	
		IPayHistoryDAL PayHistoryDAL{get;set;}
	
		IProductDAL ProductDAL{get;set;}
	
		IProductCategroyDAL ProductCategroyDAL{get;set;}
	
		IProductImageDAL ProductImageDAL{get;set;}
	
		IReceiveAddressDAL ReceiveAddressDAL{get;set;}
	
		IRightsInfoDAL RightsInfoDAL{get;set;}
	
		IRoleInfoDAL RoleInfoDAL{get;set;}
	
		IRoleRightsDAL RoleRightsDAL{get;set;}
	
		IShareInfoDAL ShareInfoDAL{get;set;}
	
		IShoppingCartDAL ShoppingCartDAL{get;set;}
	
		ISiteBaseInfoDAL SiteBaseInfoDAL{get;set;}
	
		IUserChargeRecordDAL UserChargeRecordDAL{get;set;}
	
		IUserInfoDAL UserInfoDAL{get;set;}
	}	
}