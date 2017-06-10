using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObjects;
using BusinessLogicLayer;

namespace RehomingManagement
{
    public partial class SignUpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            int output;  //Step 2.1
            BLL objBLL = new BLL(); // Step 2.2

            //Step 1: Instantiate UserMaster from the BusinessObjects class and assign user inputs from the form to the object objUserMaster properties.
            Donator objDonator = new Donator();

            objDonator.FullName = txtFullName.Value;
            objDonator.Email = txtEmail.Value;
            objDonator.Password = txtPwd.Value;
            objDonator.Active = 1;
            objDonator.Role = "User";

            //Step 2: Call the signup method of BLL(SignUpBLL)
            output = objBLL.SignUpBLL(objDonator);

            //Step 3: Display an alert box based on the output
            //If a row is affected (Success condition), alert box will be displayed for success else error message will be displayed.
            if (output > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "alertwindow", "alert('Registered successfully');window.location.href = 'SignIn.aspx';", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "alertwindow", "alert('Error occurred');window.location.href = 'SignUpPage.aspx';", true);


        }
    }
}