using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCIMS.ViewModels
{
    public class CountryView
    {
        public string Name { get; set; }
        public string About { get; set; }
        public int NoCities { get; set; }
        public int NoCityDwellers { get; set; }
    }
}