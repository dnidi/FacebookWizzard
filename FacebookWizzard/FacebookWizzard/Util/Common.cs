using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;

namespace FacebookWizzard.Util
{
    class Common
    {
        public string Error { get; set; }
        public string Token { get;  set; }
        public object Search(string keysearch,int limit)
        {
            try
            {
                if (string.IsNullOrEmpty(Token))
                {
                    FacebookClient fb = new FacebookClient();
                    string search = @"https://graph.facebook.com/search?type=user&amp;q="+ keysearch + "&amp;limit="+ limit + "&amp;fields=id,name&amp;access_token="+Token+";";
                    var Result = fb.Get("dota2Vn/members");
                }
                else
                {
                    Error = "Token = null";
                }
            } catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
            return true;
        }
    }
}
