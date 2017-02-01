using AngularMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularMVC.BBL
{
    public class CityManager
    {
        public ResponseModel LoadCities()
        {

            var cityList = new List<City>();

            var a = new City
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Dhaka",
                CountryId = 1
            };
            cityList.Add(a);

            a = new City
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Chitagong",
                CountryId = 1
            };
            cityList.Add(a);

            a = new City
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Rajshahi",
                CountryId = 1
            };
            cityList.Add(a);

            a = new City
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Khulna",
                CountryId = 1
            };
            cityList.Add(a);

            a = new City
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Rangpur",
                CountryId = 1
            };
            cityList.Add(a);

            a = new City
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Delhi",
                CountryId = 2
            };
            cityList.Add(a);

            a = new City
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Hydrabad",
                CountryId = 2
            };
            cityList.Add(a);

            a = new City
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Colombo",
                CountryId = 3
            };
            cityList.Add(a);

            return new ResponseModel()
            {
                Data = cityList
            };

        }
    }
}