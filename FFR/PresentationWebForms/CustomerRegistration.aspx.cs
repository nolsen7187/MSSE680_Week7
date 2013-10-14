using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using BusinessLayer;
using DAL;
//using PresentationWebForms.Models;

namespace PresentationWebForms
{
    public partial class CustomerRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customer uICustomer = new Customer();

            uICustomer.FirstName = this.FirstNameTextBox.Text;
            uICustomer.LastName = this.LastNameTextBox.Text;
            uICustomer.City = this.CityTextBox.Text;
            uICustomer.State = this.StateTextBox.Text;
            uICustomer.Street = this.StreetTextBox.Text;
            uICustomer.Zip = this.ZipTextBox.Text;
            uICustomer.Address = this.AddressTextBox.Text;
            uICustomer.Phone = this.PhoneTextBox.Text;
            uICustomer.Email = this.EmailTextBox.Text;

            //object Class = uICustomer;
            int ActionType = 1;

            Facade newFacade = new Facade(uICustomer, ActionType);
            newFacade.ProcessRequest();

        }



    }
}