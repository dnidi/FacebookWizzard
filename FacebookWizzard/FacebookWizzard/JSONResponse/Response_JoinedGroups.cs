using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWizzard.JSONResponse
{
   public class Response_JoinedGroups
    {
        public pagingClass paging { get; set; }
        public List<dataClass> data { get; set; }
       
    }
    public class dataClass
    {
        public string name { get; set; }
        public string id { get; set; }
        public string privacy { get; set; }
    }
    public class pagingClass
    {
        public cursorsClass cursors { get; set; }
        public string next { get; set; }
    }
    public class cursorsClass
    {
        public string before { get; set; }
        public string after { get; set; }
    }
}
