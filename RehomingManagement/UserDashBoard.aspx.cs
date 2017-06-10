﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObjects;

namespace RehomingManagement
{
    public partial class UserDashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)// Condition to check if the page is rendering for the first time or by postback event on the page.
            {
                if (Session["UserDetailsSession"] != null)// checking the session variable for null condition and proceed if it's not null.
                {
                    // Very important to cast the session object into the same object as it was assigned. In this case its UserMaster
                    Donator objDonator = Session["UserDetailsSession"] as Donator; // as operator is the safe way of type casting.

                    lblUserFullName1.InnerText = objDonator.FullName;//Assigning the retrieved Full name to the display label.
                    lblUserFullName2.InnerText = objDonator.FullName;
                    lblEmail.InnerText = objDonator.Email;
                    lblRole.InnerText = objDonator.Role;
                    //lblCreatedDate.InnerHtml = objDonator.CreatedDate.ToShortDateString();
                }
            }

        }
    }
}