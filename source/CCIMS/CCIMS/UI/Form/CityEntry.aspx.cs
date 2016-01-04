using System;
using System.Collections.Generic;
using CCIMS.BLL;
using CCIMS.Models;
using CCIMS.ViewModels;
using System.Text.RegularExpressions;

namespace CCIMS.UI.Form
{
    public partial class CityEntry : System.Web.UI.Page
    {
        CityManager objCityManager = new CityManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCityInformation();
            if (!IsPostBack)
            {
                LoadCountryIntoComboBox();
            }
        }

        private void LoadCountryIntoComboBox()
        {
            List<Country> countryList = objCityManager.LoadCountries();
            Country defaultCountry = new Country();
            defaultCountry.Id = -1;
            defaultCountry.Name = "Select..";
            countryList.Insert(0, defaultCountry);

            countryDropDownList.DataSource = countryList;
            countryDropDownList.DataTextField = "Name";
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataBind();
        }

        private void LoadCityInformation()
        {
            //List<CityView> cityViewList = objCityManager.LoadCities();
            cityEntryGridView.DataSource = objCityManager.LoadCities();
            cityEntryGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            City objCity = new City();
            objCity.Name = cityNameTextBox.Text.Trim();
            objCity.About = cityEntryEditor.Text.Trim();
            objCity.Location = locationTextBox.Text.Trim();
            objCity.Weather = weatherTextBox.Text.Trim();
            var IsValidNumber = Regex.IsMatch(noOfDwellersTextBox.Text, @"^[0-9]+(\.[0-9]+)?$");
            if (IsValidNumber)
            {
                objCity.Dwellers = Convert.ToInt32(noOfDwellersTextBox.Text);
            }
            else
            {
                objCity.Dwellers = 0;
            }
            objCity.CountryId = Convert.ToInt32(countryDropDownList.SelectedValue);

            messageLabel.Text = objCityManager.Save(objCity);
            LoadCityInformation();
            GetTextBoxEmpty();
            LoadCountryIntoComboBox();
        }

        private void GetTextBoxEmpty()
        {
            cityNameTextBox.Text = String.Empty;
            cityEntryEditor.Text = String.Empty;
            noOfDwellersTextBox.Text = String.Empty;
            locationTextBox.Text = String.Empty;
            weatherTextBox.Text = String.Empty;
        }

    }
}