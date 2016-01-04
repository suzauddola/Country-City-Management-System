﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCIMS.ViewModels
{
    public class CityView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int Dwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public string CountryName { get; set; }
        public string AboutCountry { get; set; }
    }
}