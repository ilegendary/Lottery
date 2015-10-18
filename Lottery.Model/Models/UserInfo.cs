using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            this.InvitedRecords = new List<InvitedRecord>();
            this.MoneyChangeRecords = new List<MoneyChangeRecord>();
            this.OrderMains = new List<OrderMain>();
            this.ParticipateRecords = new List<ParticipateRecord>();
            this.ReceiveAddresses = new List<ReceiveAddress>();
            this.ShareInfoes = new List<ShareInfo>();
            this.ShoppingCarts = new List<ShoppingCart>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string LoginPwd { get; set; }
        public decimal VirtualMoney { get; set; }
        public string NickName { get; set; }
        public decimal PresentMoney { get; set; }
        public string LinkUrl { get; set; }
        public decimal LotteryScore { get; set; }
        public string UserHeadImgUrl { get; set; }
        public string PhoneNo { get; set; }
        public int AdressCount { get; set; }
        public bool IsLocked { get; set; }
        public string CardNo { get; set; }
        public string PayPwd { get; set; }
        public int InvitiedCount { get; set; }
        public string WxOpenId { get; set; }
        public string WxUserHeadImg { get; set; }
        public int DeleteMark { get; set; }
        public virtual ICollection<InvitedRecord> InvitedRecords { get; set; }
        public virtual ICollection<MoneyChangeRecord> MoneyChangeRecords { get; set; }
        public virtual ICollection<OrderMain> OrderMains { get; set; }
        public virtual ICollection<ParticipateRecord> ParticipateRecords { get; set; }
        public virtual ICollection<ReceiveAddress> ReceiveAddresses { get; set; }
        public virtual ICollection<ShareInfo> ShareInfoes { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
