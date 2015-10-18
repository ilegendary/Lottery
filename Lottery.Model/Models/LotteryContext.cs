using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Lottery.Model.Mapping;

namespace Lottery.Model
{
    public partial class LotteryContext : DbContext
    {
        static LotteryContext()
        {
            Database.SetInitializer<LotteryContext>(null);
        }

        public LotteryContext()
            : base("Name=LotteryContext")
        {
        }

        public DbSet<ActivityState> ActivityStates { get; set; }
        public DbSet<AdInfo> AdInfoes { get; set; }
        public DbSet<AdminInfo> AdminInfoes { get; set; }
        public DbSet<AdminUserRight> AdminUserRights { get; set; }
        public DbSet<AdType> AdTypes { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<BaseSet> BaseSets { get; set; }
        public DbSet<InvitedRecord> InvitedRecords { get; set; }
        public DbSet<LotteryActivity> LotteryActivities { get; set; }
        public DbSet<LotteryOpenRecord> LotteryOpenRecords { get; set; }
        public DbSet<MessageInfo> MessageInfoes { get; set; }
        public DbSet<MoneyChangeRecord> MoneyChangeRecords { get; set; }
        public DbSet<NavInfo> NavInfoes { get; set; }
        public DbSet<NewsInfo> NewsInfoes { get; set; }
        public DbSet<NewsType> NewsTypes { get; set; }
        public DbSet<OpeateLog> OpeateLogs { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderMain> OrderMains { get; set; }
        public DbSet<ParticipateRecord> ParticipateRecords { get; set; }
        public DbSet<PayHistory> PayHistories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategroy> ProductCategroys { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ReceiveAddress> ReceiveAddresses { get; set; }
        public DbSet<RightsInfo> RightsInfoes { get; set; }
        public DbSet<RoleInfo> RoleInfoes { get; set; }
        public DbSet<RoleRight> RoleRights { get; set; }
        public DbSet<ShareInfo> ShareInfoes { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<SiteBaseInfo> SiteBaseInfoes { get; set; }
        public DbSet<UserChargeRecord> UserChargeRecords { get; set; }
        public DbSet<UserInfo> UserInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ActivityStateMap());
            modelBuilder.Configurations.Add(new AdInfoMap());
            modelBuilder.Configurations.Add(new AdminInfoMap());
            modelBuilder.Configurations.Add(new AdminUserRightMap());
            modelBuilder.Configurations.Add(new AdTypeMap());
            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new BaseSetMap());
            modelBuilder.Configurations.Add(new InvitedRecordMap());
            modelBuilder.Configurations.Add(new LotteryActivityMap());
            modelBuilder.Configurations.Add(new LotteryOpenRecordMap());
            modelBuilder.Configurations.Add(new MessageInfoMap());
            modelBuilder.Configurations.Add(new MoneyChangeRecordMap());
            modelBuilder.Configurations.Add(new NavInfoMap());
            modelBuilder.Configurations.Add(new NewsInfoMap());
            modelBuilder.Configurations.Add(new NewsTypeMap());
            modelBuilder.Configurations.Add(new OpeateLogMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderMainMap());
            modelBuilder.Configurations.Add(new ParticipateRecordMap());
            modelBuilder.Configurations.Add(new PayHistoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductCategroyMap());
            modelBuilder.Configurations.Add(new ProductImageMap());
            modelBuilder.Configurations.Add(new ReceiveAddressMap());
            modelBuilder.Configurations.Add(new RightsInfoMap());
            modelBuilder.Configurations.Add(new RoleInfoMap());
            modelBuilder.Configurations.Add(new RoleRightMap());
            modelBuilder.Configurations.Add(new ShareInfoMap());
            modelBuilder.Configurations.Add(new ShoppingCartMap());
            modelBuilder.Configurations.Add(new SiteBaseInfoMap());
            modelBuilder.Configurations.Add(new UserChargeRecordMap());
            modelBuilder.Configurations.Add(new UserInfoMap());
        }
    }
}
