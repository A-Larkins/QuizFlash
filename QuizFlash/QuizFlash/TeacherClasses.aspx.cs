using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using QuizFlashLibrary;

namespace QuizFlash
{
    public partial class TeacherClasses : System.Web.UI.Page
    {
        //Proxy Object
        ClassService.Classes pxy = new ClassService.Classes();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Session["username"].ToString();

            gvClasses.DataSource = pxy.GetClass(Session["username"].ToString());
            gvClasses.DataBind();

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnCreateClass_Click(object sender, EventArgs e)
        {

            if (txtClassName.Text == "" || txtClassSubject.Text == "")
            {
                lblClassError.Text = "Class could not be created: One or more fields were left blank.";
            }
            else
            {
                //create proxy object
                ClassService.TeacherClass tempClass = new ClassService.TeacherClass();

                //add values
                tempClass.Name = txtClassName.Text;
                tempClass.Subject = txtClassSubject.Text;
                tempClass.Username = Session["username"].ToString();
                tempClass.User_Type = "Teacher";

                //use ws method to add object to the class

                if (pxy.CreateClass(tempClass))
                {
                    lblClassError.Text = "The class was added!";
                }
                else
                {
                    lblClassError.Text = "The class was not successfully added :(";
                }
            }
        }
    }
}
