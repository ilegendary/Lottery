using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class ReceiveAddress
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PhoneNo { get; set; }
        public Nullable<int> ProvinceId { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> CountyId { get; set; }
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
        public string CountyName { get; set; }
        public string DetailAddress { get; set; }
        public string ReceiveRealName { get; set; }
        public string PostCode { get; set; }
        public string CardNo { get; set; }
        public bool IsDefault { get; set; }
        public int DeleteMark { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
