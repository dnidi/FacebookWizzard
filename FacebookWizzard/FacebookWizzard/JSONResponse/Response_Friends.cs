using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWizzard.JSONResponse
{
    public class Response_Friends
    {
        public cursorsResponse_Frineds paging { get; set; }
        public List<dataResponse_Frineds> data { get; set; }
    }
    public class dataResponse_Frineds
    {
        public string name { get; set; }
        public string id { get; set; }
    }
    public class cursorsResponse_Frineds
    {
        public string before { get; set; }
        public string after { get; set; }
    }
}
