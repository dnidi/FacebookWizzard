using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWizzard.JSONResponse
{
    public class Response_Posts
    {
        public pagingResponse_Posts paging { get; set; }
        public List<dataResponse_Posts> data { get; set; }
    }
    public class dataResponse_Posts
    {
        public string message { get; set; }
        public string story { get; set; }

        public string created_time { get; set; }
        //public DateTime CreateTime
        //{
        //    get
        //    {
        //        System.Globalization.DateTimeFormatInfo df = new System.Globalization.DateTimeFormatInfo
        //        {
        //            ShortDatePattern = "yyyy-MM-dd HH:mm:ss"
        //        };
        //        if (!string.IsNullOrEmpty(created_time))
        //            return Convert.ToDateTime(created_time, df);
        //        else
        //            return DateTime.MinValue;
        //    }
        //}
        public string id { get; set; }
    }
    public class pagingResponse_Posts
    {
        public string previous { get; set; }
        public string next { get; set; }
    }
}
