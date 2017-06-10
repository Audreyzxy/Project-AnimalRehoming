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
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            Donator objDonatorOutput = new Donator();

            Donator objDonatorInput = new Donator();
            objDonatorInput.Email = txtEmail.Value;
            objDonatorInput.Password = txtPwd.Value;

            BLL objBLL = new BLL();
            objDonatorOutput = objBLL.SignInBLL(objDonatorInput);

            // We are putting the entire output object objUserMasterOutput into the session variables so that all the user details
            // will be accessible throughout the application on all the pages.
            if (objDonatorOutput != null)
            {
                Session["UserDetailsSession"] = objDonatorOutput;
                Response.Redirect("UserDashboard.aspx");

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "UserNotFound", "alert('User not found.')", true);
            }


        }
    }
}