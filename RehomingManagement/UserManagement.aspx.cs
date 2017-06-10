using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using System.Data;

namespace RehomingManagement
{
    public partial class UserManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();

            }
        }
        protected void BindGrid()
        {
            try
            {
                BLL objBLL = new BLL();
                DataSet dsUsersData = new DataSet();

                dsUsersData = objBLL.GetUsersDataBLL();

                gvManageUsers.DataSource = dsUsersData;
                gvManageUsers.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        protected void gvManageUsers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvManageUsers.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void gvManageUsers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int output = 0;
            BLL objBLL = new BLL();
            GridViewRow row = gvManageUsers.Rows[e.RowIndex];
            Label lblDonatorId = row.FindControl("lblDonatorId") as Label;
            TextBox FullNameTextBox = row.FindControl("FullNameTextBox") as TextBox;
            TextBox EmailTextBox = row.FindControl("EmailTextBox") as TextBox;
            DropDownList ddlRole = row.FindControl("ddlRole") as DropDownList;
            string[] strUserUpdate = new string[4];

            strUserUpdate[0] = FullNameTextBox.Text.Trim();
            strUserUpdate[1] = EmailTextBox.Text.Trim();
            strUserUpdate[2] = lblDonatorId.Text.Trim();
            strUserUpdate[3] = ddlRole.SelectedValue;

            output = objBLL.UpdateUserBLL(strUserUpdate);
            if (output > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "Update User", "alert('User Updated Successfully')", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "Update User", "alert('Error occurred')", true);

            gvManageUsers.EditIndex = -1;
            BindGrid();
        }

        protected void gvManageUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int output = 0;
            GridViewRow row = gvManageUsers.Rows[e.RowIndex];
            Label lblDonatorId = (Label)row.FindControl("lblDonatorId");
            string DonatorId = (lblDonatorId != null && lblDonatorId.Text != null && !string.IsNullOrEmpty(lblDonatorId.Text)) ? lblDonatorId.Text.Trim() : string.Empty;

            BLL objBLL = new BLL();
            output = objBLL.DeleteUserBLL(DonatorId);

            if (output > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "deleteUsers", "alert('User Deleted Successfully')", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "deleteUsers", "alert('Error occurred')", true);

            BindGrid();
        }

        protected void gvManageUsers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvManageUsers.EditIndex = -1;
            BindGrid();
        }
    }
}