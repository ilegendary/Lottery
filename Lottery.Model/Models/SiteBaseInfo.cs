using System;
using System.Collections.Generic;

namespace Lottery.Model
{
    public partial class SiteBaseInfo
    {
        public int SiteInfoId { get; set; }
        public string SiteName { get; set; }
        public string SEO { get; set; }
        public string Copyright { get; set; }
        public string SiteDesc { get; set; }
        public string SiteUrl { get; set; }
        public string Tel_1 { get; set; }
        public string Tel_2 { get; set; }
        public string QQ_1 { get; set; }
        public string QQ_2 { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
    }
}
