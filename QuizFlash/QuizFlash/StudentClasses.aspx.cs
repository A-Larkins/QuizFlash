using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using QuizFlashLibrary;

namespace QuizFlash
{
    public partial class StudentClasses : System.Web.UI.Page
    {
        private static Quiz quiz;
        private QuizFlash_Class studentClass;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                quiz = new Quiz();
                studentClass = new QuizFlash_Class();
                lblUserName.Text = Session["username"].ToString();
                BindClassesGV();
            }

        }

        private void BindClassesGV()
        {
            String username = Session["username"].ToString();
            ClassService classServiceObj = new ClassService();
            List<QuizFlash_Class> listOfClasses = new List<QuizFlash_Class>();
            listOfClasses = classServiceObj.GetClassesByUsername(username);
            gvClasses.DataSource = listOfClasses;
            gvClasses.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Response.Redirect("LoginPage.aspx");
        }

        protected void gvClasses_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gvClasses.Rows[rowIndex];
            String className = row.Cells[0].Text;
            quiz.QuizClass = className;
            QuizService quizService = new QuizService();

            List<Quiz> listOfQuizzes = new List<Quiz>();

            listOfQuizzes = quizService.GetQuizzesByClass(className);

            gvQuizzes.DataSource = listOfQuizzes;
            gvQuizzes.DataBind();
            
            lblQuizzes.Visible = true;
            gvClasses.Visible = false;
            gvQuizzes.Visible = true;
            lblMyClasses.Visible = false;
        }

        protected void gvQuizzes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gvQuizzes.Rows[rowIndex];
            String quizName = row.Cells[0].Text;
            Session["quizName"] = quizName;
            Response.Redirect("TakeQuizPage.aspx");
        }







    } // end class
} // end ns