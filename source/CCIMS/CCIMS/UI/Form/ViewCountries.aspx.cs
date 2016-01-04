using System;
using System.Collections.Generic;
using CCIMS.BLL;
using CCIMS.ViewModels;

namespace CCIMS.UI.Form
{
    public partial class ViewCountries : System.Web.UI.Page
    {
        CountryManager objCountryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCountryInformation();
        }

        private void LoadCountryInformation()
        {
            //string searchCriteria = searchCountryByNameTextBox.Text.Trim();
            //List<CountryView> countryViewList = objCountryManager.LoadCountryInformation(searchCriteria);
            viewCountryGridView.DataSource = objCountryManager.LoadCountryInformation(searchCountryByNameTextBox.Text.Trim());
            viewCountryGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            LoadCountryInformation();
        }

        protected void viewCountryGridView_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            viewCountryGridView.PageIndex = e.NewPageIndex;
            LoadCountryInformation();
        }
    }
}