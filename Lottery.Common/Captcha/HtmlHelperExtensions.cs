using System.Web;
using System.Web.Mvc;

namespace Lottery.Common
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString Captcha(this HtmlHelper helper)
        {
            var str = "<span class='pass-verifyCode' id='captcha'><img src='/Captcha/Refresh' title='验证码图片' alt=\"验证码图片\" width='93px' heigh='31px' /></span><a href='javascript:void(0);' onclick=\"$('#captcha').find('img').attr('src','/Captcha/Refresh?timestamp='+new Date().getTime())\" class='pass-change-verifyCode'>换一张</a>";
            return helper.Raw(str);
        }
    }
}
