using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularMVC.Models
{
    public class City
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}