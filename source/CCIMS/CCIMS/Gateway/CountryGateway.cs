using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using CCIMS.Models;
using CCIMS.ViewModels;

namespace CCIMS.Gateway
{
    public class CountryGateway
    {
        SqlConnection sqlconn = new SqlConnection();
        string connectionString = WebConfigurationManager.ConnectionStrings["CCIMS"].ConnectionString;

        /// <summary>
        /// Execute SQL statement to insert data into countries table and returns number of row(s) affected.
        /// </summary>
        /// <param name="objCountry"></param>
        /// <returns>int</returns>
        public int SaveCountry(Country objCountry)
        {
            sqlconn.ConnectionString = connectionString;
            string insertQuery = "INSERT INTO Countries(Name,About) VALUES(@name,@about)";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = insertQuery;
            sqlCommand.Connection = sqlconn;

            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.Add("name", SqlDbType.NVarChar);
            sqlCommand.Parameters["name"].Value = objCountry.Name;
            sqlCommand.Parameters.Add("about", SqlDbType.NVarChar);
            sqlCommand.Parameters["about"].Value = objCountry.About;

            sqlconn.Open();
            int affectedRows = sqlCommand.ExecuteNonQuery();
            sqlconn.Close();

            return affectedRows;
        }

        /// <summary>
        /// Execute SQL statement to get all country name from database and returns selected row(s).
        /// </summary>
        /// <returns>List</returns>
        public List<Country> LoadCountries()
        {
            sqlconn.ConnectionString = connectionString;
            string loadQuery = "SELECT * FROM Countries ORDER BY Name";

            SqlCommand sqlCommand = new SqlCommand(loadQuery, sqlconn);
            sqlconn.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Country> countriesList = new List<Country>();
            while (sqlDataReader.Read())
            {
                Country objCountry = new Country();
                objCountry.Id = (int)sqlDataReader["Id"];
                objCountry.Name = sqlDataReader["Name"].ToString();
                objCountry.About = sqlDataReader["About"].ToString();
                countriesList.Add(objCountry);
            }
            sqlDataReader.Close();
            sqlconn.Close();
            return countriesList;
        }

        /// <summary>
        /// Execute SQL statement to get all rows of country information from database and returns selected row(s).
        /// </summary>
        /// <param name="name"></param>
        /// <returns>bool</returns>
        public bool IsCountryExist(string name)
        {
            sqlconn.ConnectionString = connectionString;

            string checkQuery = "SELECT * FROM Countries WHERE Name = '" + name + "'";

            SqlCommand sqlCommand = new SqlCommand(checkQuery, sqlconn);
            sqlconn.Open();

            bool hasRows = false;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                hasRows = true;
            }
            sqlDataReader.Close();
            sqlconn.Close();
            return hasRows;
        }

        /// <summary>
        /// Search country information through the search criteria sent by the user and returns selected row(s); 
        /// </summary>
        /// <param name="searchCriteria"></param>
        /// <returns>List</returns>
        public List<CountryView> LoadCountryInformation(string searchCriteria)
        {
            sqlconn.ConnectionString = connectionString;

            string loadQuery = null;
            if (searchCriteria == "")
            {
                loadQuery = "SELECT * FROM viewCountryInfo ORDER BY CountryName";
            }
            else
            {
                loadQuery = "SELECT * FROM viewCountryInfo WHERE CountryName LIKE '%" + searchCriteria + "%' ORDER BY CountryName";
            }

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = loadQuery;
            sqlCommand.Connection = sqlconn;
            sqlconn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<CountryView> countriesListView = new List<CountryView>();

            while (sqlDataReader.Read())
            {
                CountryView countryView = new CountryView();
                countryView.Name = sqlDataReader["CountryName"].ToString();
                countryView.About = sqlDataReader["About"].ToString();
                countryView.NoCities = (int)sqlDataReader["NoCities"];
                countryView.NoCityDwellers = (int)sqlDataReader["NoCityDwellers"];
                countriesListView.Add(countryView);
            }
            sqlDataReader.Close();
            sqlconn.Close();
            return countriesListView;
        }
    }
}