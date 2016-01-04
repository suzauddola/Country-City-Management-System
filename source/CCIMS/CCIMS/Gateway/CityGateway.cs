using CCIMS.Models;
using CCIMS.ViewModels;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace CCIMS.Gateway
{
    public class CityGateway
    {
        SqlConnection sqlConn = new SqlConnection();
        string connectionString = WebConfigurationManager.ConnectionStrings["CCIMS"].ConnectionString;

        /// <summary>
        /// Execute SQL statement to insert data into cities table and returns number of row(s) affected.
        /// </summary>
        /// <param name="objCity"></param>
        /// <returns>int</returns>
        public int Save(City objCity)
        {
            sqlConn.ConnectionString = connectionString;
            string insertQuery = "INSERT INTO Cities(Name,About,Dwellers,Location,Weather,CountryId) VALUES(@name,@about,@dwellers,@location,@weather,@countryId)";

            SqlCommand sqlCommand = new SqlCommand(insertQuery, sqlConn);

            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add("name", SqlDbType.NVarChar);
            sqlCommand.Parameters["name"].Value = objCity.Name;
            sqlCommand.Parameters.Add("about", SqlDbType.NVarChar);
            sqlCommand.Parameters["about"].Value = objCity.About;
            sqlCommand.Parameters.Add("dwellers", SqlDbType.Int);
            sqlCommand.Parameters["dwellers"].Value = objCity.Dwellers;
            sqlCommand.Parameters.Add("location", SqlDbType.NVarChar);
            sqlCommand.Parameters["location"].Value = objCity.Location;
            sqlCommand.Parameters.Add("weather", SqlDbType.NVarChar);
            sqlCommand.Parameters["weather"].Value = objCity.Weather;
            sqlCommand.Parameters.Add("countryId", SqlDbType.Int);
            sqlCommand.Parameters["countryId"].Value = objCity.CountryId;

            sqlConn.Open();
            int affectedRows = sqlCommand.ExecuteNonQuery();
            sqlConn.Close();
            return affectedRows;
        }

        /// <summary>
        /// Execute SQL statement to get all rows from viewGetCityInfo and returns selected row(s).
        /// </summary>
        /// <returns>List</returns>
        public List<CityView> LoadCities()
        {
            sqlConn.ConnectionString = connectionString;
            string loadQuery = "SELECT * FROM viewGetCityInfo ORDER BY CityName";

            SqlCommand sqlCommand = new SqlCommand(loadQuery, sqlConn);
            sqlConn.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<CityView> cityViewList = new List<CityView>();

            while (sqlDataReader.Read())
            {
                CityView objCityView = new CityView();
                objCityView.Id = (int)(sqlDataReader["CityId"]);
                objCityView.Name = sqlDataReader["CityName"].ToString();
                objCityView.About = sqlDataReader["About"].ToString();
                objCityView.Dwellers = (int)sqlDataReader["Dwellers"];
                objCityView.Location = sqlDataReader["Location"].ToString();
                objCityView.Weather = sqlDataReader["Weather"].ToString();
                objCityView.CountryName = sqlDataReader["CountryName"].ToString();
                objCityView.AboutCountry = sqlDataReader["AboutCountry"].ToString();
                cityViewList.Add(objCityView);
            }
            sqlDataReader.Close();
            sqlConn.Close();
            return cityViewList;
        }

        /// <summary>
        /// Execute SQL statement to get all rows from viewGetCityInfo according to the radio button selected and search criteria,returns selected row(s).
        /// </summary>
        /// <returns>List</returns>
        public List<CityView> LoadCities(string searchType, string searchCriteria)
        {
            string loadQuery = null;
            sqlConn.ConnectionString = connectionString;

            if (searchType == "Name")
            {
                loadQuery = "SELECT * FROM viewGetCityInfo WHERE CityName LIKE '%" + searchCriteria + "%' ORDER BY CityName";
            }
            else if (searchType == "CountryName")
            {
                loadQuery = "SELECT * FROM viewGetCityInfo WHERE CountryName = '" + searchCriteria + "' ORDER BY CityName";
            }
            else
            {
                loadQuery = "SELECT * FROM viewGetCityInfo ORDER BY CityName";
            }
            SqlCommand sqlCommand = new SqlCommand(loadQuery, sqlConn);
            sqlConn.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<CityView> cityViewList = new List<CityView>();

            while (sqlDataReader.Read())
            {
                CityView objCityView = new CityView();
                objCityView.Id = (int)(sqlDataReader["CityId"]);
                objCityView.Name = sqlDataReader["CityName"].ToString();
                objCityView.About = sqlDataReader["About"].ToString();
                objCityView.Dwellers = (int)sqlDataReader["Dwellers"];
                objCityView.Location = sqlDataReader["Location"].ToString();
                objCityView.Weather = sqlDataReader["Weather"].ToString();
                objCityView.CountryName = sqlDataReader["CountryName"].ToString();
                objCityView.AboutCountry = sqlDataReader["AboutCountry"].ToString();
                cityViewList.Add(objCityView);
            }
            sqlDataReader.Close();
            sqlConn.Close();
            return cityViewList;
        }

        /// <summary>
        /// Execute SQL statement to get all rows from countries table and returns selected row(s).
        /// </summary>
        /// <returns>List</returns>
        public List<Country> LoadCountries()
        {
            sqlConn.ConnectionString = connectionString;
            string loadQuery = "SELECT * FROM Countries ORDER BY Name";

            SqlCommand sqlCommand = new SqlCommand(loadQuery, sqlConn);
            sqlConn.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Country> countryList = new List<Country>();

            while (sqlDataReader.Read())
            {
                Country objCountry = new Country();
                objCountry.Id = (int)(sqlDataReader["Id"]);
                objCountry.Name = sqlDataReader["Name"].ToString();
                countryList.Add(objCountry);
            }
            sqlDataReader.Close();
            sqlConn.Close();
            return countryList;
        }

        /// <summary>
        /// Check whether inputted city already exist or not and return the status.
        /// </summary>
        /// <param name="objCity"></param>
        /// <returns>bool</returns>
        public bool IsCityExist(City objCity)
        {
            sqlConn.ConnectionString = connectionString;
            string checkQuery = "SELECT * FROM Cities WHERE Name = '" + objCity.Name + "' AND CountryId = " + objCity.CountryId + "";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = checkQuery;
            sqlCommand.Connection = sqlConn;
            sqlConn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            bool hasRows = false;
            if (sqlDataReader.HasRows)
            {
                hasRows = true;
            }
            sqlDataReader.Close();
            sqlConn.Close();
            return hasRows;
        }
    }
}