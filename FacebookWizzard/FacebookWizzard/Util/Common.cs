using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWizzard.JSONResponse;
using Newtonsoft.Json;

namespace FacebookWizzard.Util
{
    public class Common
    {
        public static string Error { get; set; }
        public static string Token { get; set; }
        public object Search(string keysearch, int limit, string token)
        {
            try
            {
                if (string.IsNullOrEmpty(Token))
                {
                    FacebookClient fb = new FacebookClient();
                    string search = @"https://graph.facebook.com/search?type=user&amp;q=" + keysearch + "&amp;limit=" + limit + "&amp;fields=id,name&amp;access_token=" + Token + ";";
                    var Result = fb.Get("dota2Vn/members");
                }
                else
                {
                    Error = "Token = null";
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
            return true;
        }
        public static Response_PostDetail getPostDetailbyID(string PostID)
        {
            Response_PostDetail obj = new Response_PostDetail();
            //https://graph.facebook.com/1235717999927120_683642118468047?access_token=EAAAAUaZA8jlABAJT8xsqXYJa8FuqbEb1naUc9RneevF4UdBO3M78Ufe4845rbYMJ2FIwoVMFAyj7LP1hl6ooDNrOOpOYetX90IrsYDeSCbJrpSKNKT5vpPj22jxQ2QVWZA8zR3xmNooEZAuzWD01i5RQKbwWypXKxRLrFUqrgZDZD
            try
            {

                FacebookClient fc = new FacebookClient(Token);
                var request = "https://graph.facebook.com/" + PostID + "?access_token=" + Token;
                var Result = fc.Get(request).ToString();
                obj = JsonConvert.DeserializeObject<Response_PostDetail>(Result.ToString());
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return obj;
        }
    }
}
