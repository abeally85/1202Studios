using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1202Studios
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public HtmlString Summary { get; set; }
        public HtmlString Text { get; set; }
    }
}