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
    public partial class Adopt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            int output = 0;
            BLL objBLL = new BLL();

            Adopter objAdopter = new Adopter();
            objAdopter.FullName = txtName.Value;
            objAdopter.Email = txtEmail.Value;
            objAdopter.PhoneNumber = txtPhone.Value;
            //if (txtContactNo.Value != null && !string.IsNullOrEmpty(txtContactNo.Value))
            //{
            //    objRecipient.PhoneNo = txtContactNo.Value.Trim();
            //}
            //objRecipient.Address = txtAddress.Value;
            objAdopter.Active = 1;
            if (chkCat.Checked)
                objAdopter.AnimalType = chkCat.Value;
            else if (chkDog.Checked)
                objAdopter.AnimalType = chkDog.Value;
            else if (chkSAnimal.Checked)
                objAdopter.AnimalType = chkSAnimal.Value;
            else if (chkFAnimal.Checked)
                objAdopter.AnimalType = chkFAnimal.Value;
            
            output = objBLL.AdoptAnimalBLL(objAdopter);
            if (output > 0)
                ClientScript.RegisterStartupScript(this.GetType(), "ApplySuccess", "alert('Apply animal Successfully');window.location.href = 'Adopt.aspx';", true);
            else
                ClientScript.RegisterStartupScript(this.GetType(), "ApplyError", "alert('Error occurred');window.location.href = 'Adopt.aspx';", true);
        }
    }
}