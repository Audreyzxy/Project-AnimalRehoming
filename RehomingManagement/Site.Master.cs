using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObjects;
using BusinessLogicLayer;
using System.Web.Security;

namespace RehomingManagement
{
    public partial class SiteMaster : MasterPage
    {
        public const string RoleAdmin = "Admin";
        public const string RoleUser = "User";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserDetailsSession"] != null)
                {
                    Donator objDonator = Session["UserDetailsSession"] as Donator; // Retrieving the UserDetaisSession into objUserMaster object

                    lnkSignUp.Visible = false; // Hide Sign Up and Sign In tabs
                    lnkSignIn.Visible = false;

                    if (objDonator.Role != RoleAdmin) //Check UserRole from the retrieved object
                    {
                        lnkManagement.Visible = false;
                        lnkAnimalManagement.Visible = false; // if user role is other than admin then hide it else make it visible.
                        lnkUserManagement.Visible = false;                
                        lnkAnalyticalDashboard.Visible = false;
                        lnkUserManagement.Visible = false;
                    }
                    else
                    {
                        lnkManagement.Visible = true;
                        lnkAnimalManagement.Visible = true;
                        lnkUserManagement.Visible = true;
                        lnkAnalyticalDashboard.Visible = true;
                        lnkUserManagement.Visible = true;
                    }

                    if (!string.IsNullOrEmpty(objDonator.FullName)) //Check for the Full name from the retrieved object for empty string
                        lblLoggedInUser.Text = objDonator.FullName; // Assign the retrieved Full name variable to the Logged in user label on the header if string is not empty.              
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "NoUser", "alert('Please Log In.')", true); // If user session is null give alert message and prompt user to sign in.
                }


            }
        }

        protected void lnkSignOut_ServerClick(object sender, EventArgs e)
        {
            if (Session["UserDetailsSession"] != null)
            {
                FormsAuthentication.SignOut();// Removes the forms-authentication ticket from the browser.
                Session.Remove("UserDetailsSession");// removes session UserDetailsSession
                Session.Abandon();
                Session.RemoveAll();
                Session.Clear();
                Response.Redirect("SignIn.aspx");//redirect again to the sign in page
            }
            else
            {
                Response.Redirect("SignIn.aspx");//redirect again to the sign in page
            }

        }
    }
}