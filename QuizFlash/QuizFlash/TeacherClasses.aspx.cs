﻿using System;
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

        protected Boolean btnDelete_Click(object sender, EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;


            DBConnect objDB = new DBConnect();

            String name1 = "";
            String dbStr = "DELETE" +
                            "FROM TP_Classes WHERE Name='" + gvr.Cells[1].Text +
                            "'";

            int retVal = objDB.DoUpdate(dbStr);

            if (retVal > 0)
                return true;
            else
                return false;
        
        }
    }
}
