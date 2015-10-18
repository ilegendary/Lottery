 using Lottery.IDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lottery.DALFactory
{
    public partial class AbstractFactory
    {		
	    public static IActivityStatesDAL CreateActivityStatesDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".ActivityStatesDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IActivityStatesDAL;
        }
		
	    public static IAdInfoDAL CreateAdInfoDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".AdInfoDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IAdInfoDAL;
        }
		
	    public static IAdminInfoDAL CreateAdminInfoDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".AdminInfoDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IAdminInfoDAL;
        }
		
	    public static IAdminUserRightsDAL CreateAdminUserRightsDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".AdminUserRightsDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IAdminUserRightsDAL;
        }
		
	    public static IAdTypeDAL CreateAdTypeDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".AdTypeDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IAdTypeDAL;
        }
		
	    public static IAreaDAL CreateAreaDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".AreaDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IAreaDAL;
        }
		
	    public static IBaseSetDAL CreateBaseSetDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".BaseSetDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IBaseSetDAL;
        }
		
	    public static IInvitedRecordDAL CreateInvitedRecordDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".InvitedRecordDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IInvitedRecordDAL;
        }
		
	    public static ILotteryActivityDAL CreateLotteryActivityDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".LotteryActivityDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as ILotteryActivityDAL;
        }
		
	    public static ILotteryOpenRecordDAL CreateLotteryOpenRecordDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".LotteryOpenRecordDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as ILotteryOpenRecordDAL;
        }
		
	    public static IMessageInfoDAL CreateMessageInfoDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".MessageInfoDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IMessageInfoDAL;
        }
		
	    public static IMoneyChangeRecordDAL CreateMoneyChangeRecordDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".MoneyChangeRecordDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IMoneyChangeRecordDAL;
        }
		
	    public static INavInfoDAL CreateNavInfoDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".NavInfoDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as INavInfoDAL;
        }
		
	    public static INewsInfoDAL CreateNewsInfoDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".NewsInfoDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as INewsInfoDAL;
        }
		
	    public static INewsTypeDAL CreateNewsTypeDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".NewsTypeDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as INewsTypeDAL;
        }
		
	    public static IOpeateLogDAL CreateOpeateLogDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".OpeateLogDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IOpeateLogDAL;
        }
		
	    public static IOrderDetailDAL CreateOrderDetailDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".OrderDetailDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IOrderDetailDAL;
        }
		
	    public static IOrderMainDAL CreateOrderMainDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".OrderMainDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IOrderMainDAL;
        }
		
	    public static IParticipateRecordDAL CreateParticipateRecordDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".ParticipateRecordDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IParticipateRecordDAL;
        }
		
	    public static IPayHistoryDAL CreatePayHistoryDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".PayHistoryDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IPayHistoryDAL;
        }
		
	    public static IProductDAL CreateProductDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".ProductDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IProductDAL;
        }
		
	    public static IProductCategroyDAL CreateProductCategroyDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".ProductCategroyDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IProductCategroyDAL;
        }
		
	    public static IProductImageDAL CreateProductImageDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".ProductImageDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IProductImageDAL;
        }
		
	    public static IReceiveAddressDAL CreateReceiveAddressDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".ReceiveAddressDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IReceiveAddressDAL;
        }
		
	    public static IRightsInfoDAL CreateRightsInfoDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".RightsInfoDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IRightsInfoDAL;
        }
		
	    public static IRoleInfoDAL CreateRoleInfoDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".RoleInfoDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IRoleInfoDAL;
        }
		
	    public static IRoleRightsDAL CreateRoleRightsDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".RoleRightsDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IRoleRightsDAL;
        }
		
	    public static IShareInfoDAL CreateShareInfoDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".ShareInfoDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IShareInfoDAL;
        }
		
	    public static IShoppingCartDAL CreateShoppingCartDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".ShoppingCartDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IShoppingCartDAL;
        }
		
	    public static ISiteBaseInfoDAL CreateSiteBaseInfoDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".SiteBaseInfoDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as ISiteBaseInfoDAL;
        }
		
	    public static IUserChargeRecordDAL CreateUserChargeRecordDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".UserChargeRecordDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IUserChargeRecordDAL;
        }
		
	    public static IUserInfoDAL CreateUserInfoDAL()
        {
            string classFulleName = ConfigurationManager.AppSettings["NameSpace"] + ".UserInfoDAL";
            //object obj = Assembly.Load(ConfigurationManager.AppSettings["DALAssembly"]).CreateInstance(classFulleName, true);
            var obj  = CreateInstance(ConfigurationManager.AppSettings["DALAssemblyPath"], classFulleName);
            return obj as IUserInfoDAL;
        }
	}
	
}