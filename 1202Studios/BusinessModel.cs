using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1202Studios
{
    public class BusinessModel
    {
        public List<IPortfolio> GetPortfolio()
        {
            var portfolio = new List<IPortfolio>();

            portfolio.Add(new Project
            {
                Id = 1, 
                ImageUrl = "demo.gif",
                Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean nibh erat, sagittis sit amet congue at, aliquam eu libero. Integer molestie, turpis vel ultrices facilisis.",
                Title = "Website1",
                WebsiteUrl = "http://www.google.co.uk"
            });

            portfolio.Add(new Quote 
            {
                Id = 2, 
                Summary = "That’s not what we think design is. It’s not just what it looks like and feels like. Design is how it works",
                Title = "Steve Jobs"
            });

            portfolio.Add(new Project
            {
                Id = 3, 
                ImageUrl = "demo.gif",
                Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean nibh erat, sagittis sit amet congue at, aliquam eu libero. Integer molestie, turpis vel ultrices facilisis.",
                Title = "Website2",
                WebsiteUrl = "http://www.google.co.uk"
            });

            portfolio.Add(new Quote
            {
                Id = 4, 
                Summary = "Design is the fundamental as it ends up express itself in the outer layers of the product or service",
                Title = "Steve Jobs"
            });

            portfolio.Add(new Project
            {
                Id = 5, 
                ImageUrl = "demo.gif",
                Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean nibh erat, sagittis sit amet congue at, aliquam eu libero. Integer molestie, turpis vel ultrices facilisis.",
                Title = "Website3",
                WebsiteUrl = "http://www.google.co.uk"
            });

            portfolio.Add(new Quote
            {
                Id = 6, 
                Summary = "Design is the fundamental as it ends up express itself in the outer layers of the product or service",
                Title = "Steve Jobs"
            });

            return portfolio;
        }

        public List<Blog> GetBlog()
        {
            var blog = new List<Blog>();


            blog.Add(new Blog
            {
                Id = 1,
                Title = "The future of internet",
                Summary = new HtmlString("Phasellus fringilla vehicula egestas. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam gravida porta tellus sit amet commodo. Vivamus eget ligula lacus. In mi tellus, elementum quis vulputate in, varius et est. Praesent nec erat nec dui elementum laoreet sed sit amet nibh. Nunc sit amet dignissim nibh.<br/><br/>Quisque eget mauris at elit tincidunt tincidunt ut ut sapien. Nam aliquet elementum neque id egestas. Nunc dui risus, pretium nec iaculis ac, auctor eu arcu. Morbi venenatis bibendum lectus, id consequat purus tincidunt eu."),
                Text = new HtmlString("Phasellus fringilla vehicula egestas. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam gravida porta tellus sit amet commodo. Vivamus eget ligula lacus. In mi tellus, elementum quis vulputate in, varius et est. Praesent nec erat nec dui elementum laoreet sed sit amet nibh. Nunc sit amet dignissim nibh.<br/><br/>Quisque eget mauris at elit tincidunt tincidunt ut ut sapien. Nam aliquet elementum neque id egestas. Nunc dui risus, pretium nec iaculis ac, auctor eu arcu. Morbi venenatis bibendum lectus, id consequat purus tincidunt eu.Phasellus fringilla vehicula egestas. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.<br/><br/> Nam gravida porta tellus sit amet commodo. Vivamus eget ligula lacus. In mi tellus, elementum quis vulputate in, varius et est. Praesent nec erat nec dui elementum laoreet sed sit amet nibh. Nunc sit amet dignissim nibh.\n\nQuisque eget mauris at elit tincidunt tincidunt ut ut sapien. Nam aliquet elementum neque id egestas. Nunc dui risus, pretium nec iaculis ac, auctor eu arcu. Morbi venenatis bibendum lectus, id consequat purus tincidunt eu.")
            });

            blog.Add(new Blog
            {
                Id = 2,
                Title = "The future of internet",
                Summary = new HtmlString("Phasellus fringilla vehicula egestas. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam gravida porta tellus sit amet commodo. Vivamus eget ligula lacus. In mi tellus, elementum quis vulputate in, varius et est. Praesent nec erat nec dui elementum laoreet sed sit amet nibh. Nunc sit amet dignissim nibh.<br/><br/>Quisque eget mauris at elit tincidunt tincidunt ut ut sapien. Nam aliquet elementum neque id egestas. Nunc dui risus, pretium nec iaculis ac, auctor eu arcu. Morbi venenatis bibendum lectus, id consequat purus tincidunt eu."),
                Text = new HtmlString("Phasellus fringilla vehicula egestas. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam gravida porta tellus sit amet commodo. Vivamus eget ligula lacus. In mi tellus, elementum quis vulputate in, varius et est. Praesent nec erat nec dui elementum laoreet sed sit amet nibh. Nunc sit amet dignissim nibh.<br/><br/>Quisque eget mauris at elit tincidunt tincidunt ut ut sapien. Nam aliquet elementum neque id egestas. Nunc dui risus, pretium nec iaculis ac, auctor eu arcu. Morbi venenatis bibendum lectus, id consequat purus tincidunt eu.Phasellus fringilla vehicula egestas. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.<br/><br/> Nam gravida porta tellus sit amet commodo. Vivamus eget ligula lacus. In mi tellus, elementum quis vulputate in, varius et est. Praesent nec erat nec dui elementum laoreet sed sit amet nibh. Nunc sit amet dignissim nibh.\n\nQuisque eget mauris at elit tincidunt tincidunt ut ut sapien. Nam aliquet elementum neque id egestas. Nunc dui risus, pretium nec iaculis ac, auctor eu arcu. Morbi venenatis bibendum lectus, id consequat purus tincidunt eu.")
            });

            blog.Add(new Blog
            {
                Id = 3,
                Title = "The future of internet",
                Summary = new HtmlString("Phasellus fringilla vehicula egestas. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam gravida porta tellus sit amet commodo. Vivamus eget ligula lacus. In mi tellus, elementum quis vulputate in, varius et est. Praesent nec erat nec dui elementum laoreet sed sit amet nibh. Nunc sit amet dignissim nibh.<br/><br/>Quisque eget mauris at elit tincidunt tincidunt ut ut sapien. Nam aliquet elementum neque id egestas. Nunc dui risus, pretium nec iaculis ac, auctor eu arcu. Morbi venenatis bibendum lectus, id consequat purus tincidunt eu."),
                Text = new HtmlString("Phasellus fringilla vehicula egestas. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nam gravida porta tellus sit amet commodo. Vivamus eget ligula lacus. In mi tellus, elementum quis vulputate in, varius et est. Praesent nec erat nec dui elementum laoreet sed sit amet nibh. Nunc sit amet dignissim nibh.<br/><br/>Quisque eget mauris at elit tincidunt tincidunt ut ut sapien. Nam aliquet elementum neque id egestas. Nunc dui risus, pretium nec iaculis ac, auctor eu arcu. Morbi venenatis bibendum lectus, id consequat purus tincidunt eu.Phasellus fringilla vehicula egestas. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.<br/><br/> Nam gravida porta tellus sit amet commodo. Vivamus eget ligula lacus. In mi tellus, elementum quis vulputate in, varius et est. Praesent nec erat nec dui elementum laoreet sed sit amet nibh. Nunc sit amet dignissim nibh.\n\nQuisque eget mauris at elit tincidunt tincidunt ut ut sapien. Nam aliquet elementum neque id egestas. Nunc dui risus, pretium nec iaculis ac, auctor eu arcu. Morbi venenatis bibendum lectus, id consequat purus tincidunt eu.")
            });

            return blog;
        }

        public Blog GetSingleBlog(int id)
        {
            return GetBlog().Single(b=>b.Id == id);
        }
    }
}