using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObjects;
using BusinessLogicLayer;
using System.IO;
using System.Collections.Generic;

namespace RehomingManagement
{
    public partial class Donate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserDetailsSession"] == null)
            {
                Response.Redirect("SignIn.aspx");
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "NoUser", "alert('Please Log In.')", true);
            }
            //if (!IsPostBack)
            //{
            //    string[] filePaths = Directory.GetFiles(Server.MapPath("~/AnimalImages/"));
            //    List<ListItem> files = new List<ListItem>();
            //    foreach (string filePath in filePaths)
            //    {
            //        string fileName = Path.GetFileName(filePath);
            //        files.Add(new ListItem(fileName, "~/AnimalImages/" + fileName));
            //    }
            //    GridView1.DataSource = files;
            //    GridView1.DataBind();
            //}
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int output = 0;
            BLL objBll = new BLL();
            Animal objAnimal = new Animal();
            objAnimal.AnimalName = txtName.Value;
            objAnimal.Location = txtAdd.Value;
            objAnimal.Active = 1;

            // pipe separation if both checkboxes checked
            //if (chkReusable.Checked && chkNonReusable.Checked && chkNewClothes.Checked)
            //    objDonation.DonationType = chkReusable.Value + "|" + chkNonReusable.Value + "|" + chkNewClothes.Value;
            //else if (chkReusable.Checked && chkNonReusable.Checked)
            //    objDonation.DonationType = chkReusable.Value + "|" + chkNonReusable.Value;
            //else if (chkReusable.Checked && chkNewClothes.Checked)
            //    objDonation.DonationType = chkReusable.Value + "|" + chkNewClothes.Value;
            //else if (chkNonReusable.Checked && chkNewClothes.Checked)
            //    objDonation.DonationType = chkNonReusable.Value + "|" + chkNewClothes.Value;
            if (chkCat.Checked)
                objAnimal.Type = chkCat.Value;
            else if (chkDog.Checked)
                objAnimal.Type = chkDog.Value;
            else if (chkSAnimal.Checked)
                objAnimal.Type = chkSAnimal.Value;
            else if (chkFAnimal.Checked)
                objAnimal.Type = chkFAnimal.Value;


            objAnimal.Status = "New Request";
            objAnimal.PickUpDate = txtDate.Value;
            output = objBll.DonateAnimalBLL(objAnimal);

            //If a row is affected then ie. Success condition will open a alert box for success else alert for error will be opened.
            if (output > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alertwindow", "alert('Donation Submitted Successfully');window.location.href = 'Donate.aspx';", true);
            }
            else
                ClientScript.RegisterStartupScript(this.GetType(), "alertwindow", "alert('Error occurred');window.location.href = 'Donate.aspx';", true);


        }

        //protected void UploadButton_Click(object sender, EventArgs e)
        //{
        //    if (FileUploadControl.HasFile)
        //    {
        //        try
        //        {
        //            if (FileUploadControl.PostedFile.ContentType == "image/jpeg" || FileUploadControl.PostedFile.ContentType == "image/png")
        //            {
        //                if (FileUploadControl.PostedFile.ContentLength < 102400)
        //                {
        //                    string filename = Path.GetFileName(FileUploadControl.FileName);
        //                    string filePath = Server.MapPath("~/AnimalImages");
        //                    filePath += @"\" + filename;
        //                    FileUploadControl.SaveAs(filePath);
        //                    StatusLabel.Text = "Upload status: File uploaded!";
        //                }
        //                else
        //                    StatusLabel.Text = "Upload status: The file has to be less than 100 kb!";
        //            }
        //            else
        //                StatusLabel.Text = "Upload status: Only JPEG or PNG files are accepted!";
        //        }
        //        catch (Exception ex)
        //        {
        //            StatusLabel.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
        //        }
        //    }
        //}
    }
}