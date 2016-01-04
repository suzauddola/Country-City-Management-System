using System;
using System.Collections.Generic;
using CCIMS.BLL;
using CCIMS.Models;

namespace CCIMS.UI.Form
{
    public partial class ViewCities : System.Web.UI.Page
    {
        CityManager objCityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountryIntoComboBox();
            }
            LoadCityInformation();
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
            // List<CityView> cityViewList = objCityManager.LoadCities();
            viewCityGridView.DataSource = objCityManager.LoadCities();
            viewCityGridView.DataBind();
        }

        private void LoadCityInformation(string searchType, string searchCriteria)
        {
           // List<CityView> cityViewList = objCityManager.LoadCities(searchType, searchCriteria);
            viewCityGridView.DataSource = objCityManager.LoadCities(searchType, searchCriteria);
            viewCityGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string searchType = null;
            string searchCriteria = null;

            if (cityNameRadioButton.Checked)
            {
                searchType = "Name";
                searchCriteria = cityNameSearchTextBox.Text.Trim();
                LoadCityInformation(searchType, searchCriteria);
            }
            else if (countryRadioButton.Checked)
            {
                if (Convert.ToInt16(countryDropDownList.SelectedValue) != -1)
                {
                    searchType = "CountryName";
                    searchCriteria = countryDropDownList.SelectedItem.Text;
                }
                else
                {
                    searchType = "";
                    searchCriteria = "%";
                }
                LoadCityInformation(searchType, searchCriteria);
            }
        }

        protected void viewCityGridView_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            viewCityGridView.PageIndex = e.NewPageIndex;
            LoadCityInformation();
        }
    }
}