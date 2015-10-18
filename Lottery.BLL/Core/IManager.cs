 using Lottery.IBLL;
using Lottery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.BLL
{
	
	public partial class ActivityStatesService :BaseService<ActivityState>,IActivityStatesService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.ActivityStatesDAL;
        }
    }   
	
	public partial class AdInfoService :BaseService<AdInfo>,IAdInfoService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.AdInfoDAL;
        }
    }   
	
	public partial class AdminInfoService :BaseService<AdminInfo>,IAdminInfoService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.AdminInfoDAL;
        }
    }   
	
	public partial class AdminUserRightsService :BaseService<AdminUserRight>,IAdminUserRightsService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.AdminUserRightsDAL;
        }
    }   
	
	public partial class AdTypeService :BaseService<AdType>,IAdTypeService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.AdTypeDAL;
        }
    }   
	
	public partial class AreaService :BaseService<Area>,IAreaService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.AreaDAL;
        }
    }   
	
	public partial class BaseSetService :BaseService<BaseSet>,IBaseSetService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.BaseSetDAL;
        }
    }   
	
	public partial class InvitedRecordService :BaseService<InvitedRecord>,IInvitedRecordService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.InvitedRecordDAL;
        }
    }   
	
	public partial class LotteryActivityService :BaseService<LotteryActivity>,ILotteryActivityService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.LotteryActivityDAL;
        }
    }   
	
	public partial class LotteryOpenRecordService :BaseService<LotteryOpenRecord>,ILotteryOpenRecordService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.LotteryOpenRecordDAL;
        }
    }   
	
	public partial class MessageInfoService :BaseService<MessageInfo>,IMessageInfoService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.MessageInfoDAL;
        }
    }   
	
	public partial class MoneyChangeRecordService :BaseService<MoneyChangeRecord>,IMoneyChangeRecordService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.MoneyChangeRecordDAL;
        }
    }   
	
	public partial class NavInfoService :BaseService<NavInfo>,INavInfoService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.NavInfoDAL;
        }
    }   
	
	public partial class NewsInfoService :BaseService<NewsInfo>,INewsInfoService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.NewsInfoDAL;
        }
    }   
	
	public partial class NewsTypeService :BaseService<NewsType>,INewsTypeService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.NewsTypeDAL;
        }
    }   
	
	public partial class OpeateLogService :BaseService<OpeateLog>,IOpeateLogService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.OpeateLogDAL;
        }
    }   
	
	public partial class OrderDetailService :BaseService<OrderDetail>,IOrderDetailService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.OrderDetailDAL;
        }
    }   
	
	public partial class OrderMainService :BaseService<OrderMain>,IOrderMainService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.OrderMainDAL;
        }
    }   
	
	public partial class ParticipateRecordService :BaseService<ParticipateRecord>,IParticipateRecordService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.ParticipateRecordDAL;
        }
    }   
	
	public partial class PayHistoryService :BaseService<PayHistory>,IPayHistoryService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.PayHistoryDAL;
        }
    }   
	
	public partial class ProductService :BaseService<Product>,IProductService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.ProductDAL;
        }
    }   
	
	public partial class ProductCategroyService :BaseService<ProductCategroy>,IProductCategroyService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.ProductCategroyDAL;
        }
    }   
	
	public partial class ProductImageService :BaseService<ProductImage>,IProductImageService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.ProductImageDAL;
        }
    }   
	
	public partial class ReceiveAddressService :BaseService<ReceiveAddress>,IReceiveAddressService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.ReceiveAddressDAL;
        }
    }   
	
	public partial class RightsInfoService :BaseService<RightsInfo>,IRightsInfoService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.RightsInfoDAL;
        }
    }   
	
	public partial class RoleInfoService :BaseService<RoleInfo>,IRoleInfoService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.RoleInfoDAL;
        }
    }   
	
	public partial class RoleRightsService :BaseService<RoleRight>,IRoleRightsService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.RoleRightsDAL;
        }
    }   
	
	public partial class ShareInfoService :BaseService<ShareInfo>,IShareInfoService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.ShareInfoDAL;
        }
    }   
	
	public partial class ShoppingCartService :BaseService<ShoppingCart>,IShoppingCartService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.ShoppingCartDAL;
        }
    }   
	
	public partial class SiteBaseInfoService :BaseService<SiteBaseInfo>,ISiteBaseInfoService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.SiteBaseInfoDAL;
        }
    }   
	
	public partial class UserChargeRecordService :BaseService<UserChargeRecord>,IUserChargeRecordService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.UserChargeRecordDAL;
        }
    }   
	
	public partial class UserInfoService :BaseService<UserInfo>,IUserInfoService
    {
        public override void SetCurretnDAL()
        {
            CurrentDAL = this.GetCurrentDbSession.UserInfoDAL;
        }
    }   
	
}