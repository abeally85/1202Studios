using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1202Studios
{
    public interface IPortfolio
    {
        int Id { get; set; }
        string Summary { get; set; }
        string Title { get; set; }
    }
    
    
    
    public class Project : IPortfolio 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string ImageUrl { get; set; }
        public string WebsiteUrl { get; set; }
    }

    public class Quote : IPortfolio
    {
        public int Id { get; set; }
        public string Summary{ get; set; }    
        public string Title{ get; set; }    
    }
}