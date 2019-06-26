using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWizzard.JSONResponse
{
    public class Response_PostDetail
    {
        public string created_time { get; set; }
        public string message { get; set; }
        public string story { get; set; }
        public List<actionsClass> actions { get; set; }
        public commentsClass comments { get; set; }
        public fromClass from { get; set; }
        public string icon { get; set; }
        public string is_hidden { get; set; }
        public string is_expired { get; set; }
        public likesClass likes { get; set; }
        public string link { get; set; }
        public object message_tags { get; set; }//
        public string name { get; set; }
        public string object_id { get; set; }
        public string picture { get; set; }
        public privacyClass privacy { get; set; }
        public string status_type { get; set; }
        public object story_tags { get; set; }//
        public string subscribed { get; set; }
        public toClass to { get; set; }
        public string type { get; set; }
        public string updated_time { get; set; }
        public with_tagsClass with_tags { get; set; }
        public string id { get; set; }

    }
    public class actionsClass
    {
        public string name { get; set; }
        public string link { get; set; }
    }
    public class commentsClass
    {
        public string count { get; set; }
        public List<dataCommentsClass> data { get; set; }
    }
    public class dataCommentsClass
    {
        public string id { get; set; }
        public string message { get; set; }
        public object message_tags { get; set; }
        public string created_time { get; set; }
        public string likes { get; set; }
        public datawith_tagsClass from { get; set; }
    }
    public class fromClass
    {
        public string name { get; set; }
        public string id { get; set; }
    }
    public class likesClass
    {
        public string count { get; set; }
    }
    public class privacyClass
    {
        public string allow { get; set; }
        public string deny { get; set; }
        public string description { get; set; }
        public string friends { get; set; }
        public string value { get; set; }
    }
    public class toClass
    {
        public List<datawith_tagsClass> data { get; set; }
    }
    public class with_tagsClass
    {
        public List<with_tagsClass> data { get; set; }
    }
    public class datawith_tagsClass
    {
        public string id { get; set; }
        public string name { get; set; }
    }
}
