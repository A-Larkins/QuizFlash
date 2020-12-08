using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using QuizFlashLibrary;
using ClassSOAPWS;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace QuizFlash
{
    public partial class ClassPage : System.Web.UI.Page
    {
        //proxy class to access soap web service
        ClassService1.Classes pxy = new ClassService1.Classes();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserName.Text = Session["username"].ToString();
            TeacherClass temp = (TeacherClass)Session["Temp"];

            gvStudents.DataSource = pxy.getStudents(temp.Name);
            gvStudents.DataBind();

            
        }

    }
}