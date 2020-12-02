using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizFlash
{
    public partial class StudyControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["SetNameCookie"] != null)
            {
                // get the set name that was stored
                HttpCookie theSetNameCookie = Request.Cookies["SetNameCookie"];
                String setName = theSetNameCookie.Values["SetName"].ToString();
                lblSetName.Text = setName;

            }
           

        }

        // quit studying button
        protected void btnRelax_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHomepage.aspx");
        }

        protected void btnShowAnswer_Click(object sender, EventArgs e)
        {

        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {

        }




    } // end class
} // end ns