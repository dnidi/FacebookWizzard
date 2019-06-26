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
        public List<actionResponse_PostDetail> actions { get; set; }

    }
    public class actionResponse_PostDetail
    {
        public string name { get; set; }
        public string link { get; set; }
    }
    public class commentResponse_PostDetail
    {
        public string count { get; set; }
        public List<dataCommentResponse_PostDetail> data { get; set; }
    }

    public class dataCommentResponse_PostDetail
    {
        public string id { get; set; }
        public string message { get; set; }
        public List<message_tagsdataCommentResponse_PostDetail> message_tags { get; set; }
        public string created_time { get; set; }
        public string likes { get; set; }
        public List<fromDataCommentResponse_PostDetail> from { get; set; }

    }
    public class message_tagsdataCommentResponse_PostDetail
    {

    }
    public class fromDataCommentResponse_PostDetail
    {
        public string id { get; set; }
        public string name { get; set; }
    }
}