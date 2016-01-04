using System.Collections.Generic;
using CCIMS.Gateway;
using CCIMS.Models;
using CCIMS.ViewModels;

namespace CCIMS.BLL
{
    public class CountryManager
    {
        CountryGateway objCountryGateway = new CountryGateway();

        /// <summary>
        /// Receive Country information from UI and pass to Gateway to insert.
        /// </summary>
        /// <param name="objCountry"></param>
        /// <returns>string</returns>
        public string SaveCountry(Country objCountry)
        {
            if (!objCountryGateway.IsCountryExist(objCountry.Name))
            {
                if (objCountry.Name != "")
                {
                    int affectedRows = objCountryGateway.SaveCountry(objCountry);
                    if (affectedRows > 0)
                    {
                        return "Records inserted successfully.";
                    }
                    else return "Insert operation failed..";

                }
                else
                {
                    return "Country name can't be empty.";
                }
            }
            else
            {
                return "Duplicate country name not allowed.";
            }
        }

        /// <summary>
        /// Return all Country name to load combobox control.
        /// </summary>
        /// <returns>List</returns>
        public List<Country> LoadCountries()
        {
            return objCountryGateway.LoadCountries();
        }

        /// <summary>
        /// Return all rows of countries through search criteria.
        /// </summary>
        /// <param name="searchCriteria"></param>
        /// <returns>List</returns>
        public List<CountryView> LoadCountryInformation(string searchCriteria)
        {
            return objCountryGateway.LoadCountryInformation(searchCriteria);
        }
    }
}