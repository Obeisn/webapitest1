using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapitest1.Models
{
    public class SubpartDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string icon { get; set; }
        public string link { get; set; }
        public IQueryable<object> submenu { get; set; }
    }
}