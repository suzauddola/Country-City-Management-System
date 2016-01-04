using System.Collections.Generic;
using CCIMS.Gateway;
using CCIMS.Models;
using CCIMS.ViewModels;

namespace CCIMS.BLL
{
    public class CityManager
    {
        CityGateway objCityGateway = new CityGateway();

        /// <summary>
        /// Receive City information from UI and pass to Gateway to insert.
        /// </summary>
        /// <param name="objCity"></param>
        /// <returns>string</returns>
        public string Save(City objCity)
        {

            if (objCity.Name != "")
            {
                if (objCity.CountryId != -1)
                {
                    if (!objCityGateway.IsCityExist(objCity))
                    {
                        int affectedRows = objCityGateway.Save(objCity);
                        if (affectedRows > 0)
                        {
                            return "Records inserted successfully";
                        }
                        else
                        {
                            return "Insert operation failed.";
                        }
                    }
                    else
                    {
                        return "Duplicate city name isn't allowed.";
                    }
                }
                else
                {
                    return "Please select valid country name.";
                }
            }
            else
            {
                return "City name can't be empty.";
            }
        }

        public List<CityView> LoadCities()
        {
            return objCityGateway.LoadCities();
        }

        public List<CityView> LoadCities(string searchType, string searchCriteria)
        {
            return objCityGateway.LoadCities(searchType, searchCriteria);
        }

        public List<Country> LoadCountries()
        {
            return objCityGateway.LoadCountries();
        }

    }
}