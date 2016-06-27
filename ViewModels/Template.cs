using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ebay.ViewModels
{
    public class Template
    {
        public string NameKey { get; set; }
        public string Title { get; set; }
        public string Part1 { get; set; }
        public string DividerText1 { get; set; }
        public string Part2 { get; set; }

        public IList<string> Images { get; set; }

    }
}