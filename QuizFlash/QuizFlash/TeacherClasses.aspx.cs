using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using QuizFlashLibrary;
using ClassSOAPWS;

namespace QuizFlash
{
    public partial class TeacherClasses : System.Web.UI.Page
    {
        //Proxy Object
        ClassService1.Classes pxy = new ClassService1.Classes();

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

        protected void btnCreateClass_Click1(object sender, EventArgs e)
        {
            if (txtClassName.Text == "" || txtClassSubject.Text == "")
            {
                lblClassError.Text = "Class could not be created: One or more fields were left blank.";
            }
            else
            {
                //create proxy object
                ClassService1.TeacherClass tempClass = new ClassService1.TeacherClass();

                //add values
                tempClass.Name = txtClassName.Text;
                tempClass.Subject = txtClassSubject.Text;
                tempClass.Username = Session["username"].ToString();
                tempClass.User_Type = "Teacher";

                //use ws method to add object to the class

                if (pxy.AddClass(tempClass))
                {
                    lblClassError.Text = "The class was added!";
                }
                else
                {
                    lblClassError.Text = "The class was not successfully added :(";
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
                
                TeacherClass temp = new TeacherClass();
            temp.Name = txtClassName.Text;
                pxy.DeleteClass(temp.Name);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;

            TeacherClass temp = new TeacherClass(gvr.Cells[1].Text, gvr.Cells[2].Text, Session["username"].ToString(), "Teacher");
                Session["Temp"] = temp;
                Response.Redirect("ClassPage.aspx");

        }

        protected void gvClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
