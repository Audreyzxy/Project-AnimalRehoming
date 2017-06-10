using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using System.Data;



namespace RehomingAnimalManagement
{
    public partial class AnimalManagement : System.Web.UI.Page
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
                DataSet dsAnimalsData = new DataSet();

                dsAnimalsData = objBLL.GetAnimalsDataBLL();

                gvManageAnimals.DataSource = dsAnimalsData;
                gvManageAnimals.DataBind();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void gvManageAnimals_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvManageAnimals.EditIndex = e.NewEditIndex;
            BindGrid();

        }

        protected void gvManageAnimals_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int output = 0;
            BLL objBLL = new BLL();
            GridViewRow row = gvManageAnimals.Rows[e.RowIndex];
           
            Label lblAnimalId = row.FindControl("lblAnimalId") as Label;
            //Label lblAnimalType = row.FindControl("lblAnimalType") as Label;
            DropDownList ddlStatus = row.FindControl("ddlStatus") as DropDownList;
            DropDownList ddlAdopter = row.FindControl("ddlAdopter") as DropDownList;
            
            string[] strAnimalUpdate = new string[4];

            strAnimalUpdate[0] = ddlStatus.SelectedValue;
            strAnimalUpdate[1] = lblAnimalId.Text.Trim();
            strAnimalUpdate[2] = ddlAdopter.SelectedValue;
            strAnimalUpdate[3] = ddlAdopter.SelectedItem.Text;
            //strAnimalUpdate[4] = lblAnimalType.Text.Trim();

            
            output = objBLL.UpdateAnimalBLL(strAnimalUpdate);
            if (output > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "Update Animal", "alert('Animal Updated Successfully')", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "Update Animal", "alert('Error occurred')", true);

            gvManageAnimals.EditIndex = -1;
            BindGrid();
        }






        protected void gvManageAnimals_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int output = 0;
            GridViewRow row = gvManageAnimals.Rows[e.RowIndex];
            Label lblAnimalId = (Label)row.FindControl("lblAnimalId");

            string AnimalId = (lblAnimalId != null && lblAnimalId.Text != null && !string.IsNullOrEmpty(lblAnimalId.Text)) ? lblAnimalId.Text.Trim() : string.Empty;

            BLL objBLL = new BLL();
            output = objBLL.DeleteAnimalBLL(AnimalId);

            if (output > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "deleteAnimals", "alert('Animal Deleted Successfully')", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "deleteAnimals", "alert('Error occurred')", true);

            BindGrid();


        }

        protected void gvManageAnimals_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvManageAnimals.EditIndex = -1;
            BindGrid();

        }
    }
}