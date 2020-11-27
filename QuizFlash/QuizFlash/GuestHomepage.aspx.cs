using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuizFlash
{
    public partial class GuestHomepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateAnAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

    }
}
