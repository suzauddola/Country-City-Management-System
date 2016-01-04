using System;
using System.Collections.Generic;
using CCIMS.BLL;
using CCIMS.Models;

namespace CCIMS.UI.Form
{
    public partial class CountryEntry : System.Web.UI.Page
    {
        CountryManager objCountryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCountryInformation();

        }

        private void LoadCountryInformation()
        {
            List<Country> countryList = objCountryManager.LoadCountries();
            countryEntryGridView.DataSource = countryList;
            countryEntryGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

            Country objCountry = new Country();
            string name = countryNameTextBox.Text.Trim();
            string about = countryEntryEditor.Text.Trim();

            objCountry.Name = name.Replace("'", "''");
            objCountry.About = about.Replace("'", "''");

            messageLabel.Text = objCountryManager.SaveCountry(objCountry);
            LoadCountryInformation();
            GetTextBoxEmpty();
        }

        private void GetTextBoxEmpty()
        {
            countryNameTextBox.Text = String.Empty;
            countryEntryEditor.Text = String.Empty;
        }
    }
}