using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;

namespace MvcApplication1.Models
{
    public class NewsViewModel
    {
        public IEnumerable<Newse> NewsList { get; set; }
    }
}