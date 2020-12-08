using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

using QuizFlashLibrary;

namespace QuizFlash
{
    public partial class TakeQuizPage : System.Web.UI.Page
    {
        static List<FlashcardClass> set;

        QuizService quizService = new QuizService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                set = new List<FlashcardClass>();
                lblUserName.Text = Session["username"].ToString();
                String username = lblUserName.Text;

                String quizName = Session["quizName"].ToString();
                lblQuizName.Visible = true;
                lblQuizName.Text = quizName;
                String quizFlashcardSet = quizService.GetFlashcardSetName(quizName);
                Session["quizFlashcardSetName"] = quizFlashcardSet;
                

                BindGVWithQuestions(quizFlashcardSet);
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Response.Redirect("LoginPage.aspx");
        }

        private void BindGVWithQuestions(String flashcardSet)
        {
            WebRequest request = WebRequest.Create("https://localhost:44355/api/flashcards/getflashcardset/" + flashcardSet);
            WebResponse response = request.GetResponse();

            // Read the data from the Web Response, which requires working with streams.
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();

            reader.Close();
            response.Close();

            // Deserialize a JSON string that contains an array of JSON objects into an Array of flashcardset objects.
            JavaScriptSerializer js = new JavaScriptSerializer();
            FlashcardClass[] sets = js.Deserialize<FlashcardClass[]>(data);

            

            foreach (FlashcardClass flashcard in sets)
            {
                set.Add(flashcard);

            }
            gvQuizForm.DataSource = set;
            gvQuizForm.DataBind();
        }

        protected void btnSubmitQuiz_Click(object sender, EventArgs e)
        {
            double correctAnswers = 0;
            double incorrectAnswers = 0;
            int index = 0;

            foreach (GridViewRow row in gvQuizForm.Rows)
            {
                TextBox inputAnswer = (TextBox)row.FindControl("txtUserAnswer");
                String inAnswer = inputAnswer.Text;
                if(inAnswer == set[index].FlashcardAnswer.ToString())
                {
                    correctAnswers++;
                }
                else
                {
                    incorrectAnswers++;
                }
                index++;
            }

            String results1 = "Total Questions: " + index + " Total Correct: " + correctAnswers;
            lblCorrectAnswerTotal.Visible = true;
            lblCorrectAnswerTotal.Text = results1;

            double score = Math.Truncate(correctAnswers / index * 100);
            if(score == 1)
            {
                score = 100;
            }
            String results2 = "Your score: " + score + "%";
            lblQuizGrade.Visible = true;
            lblQuizGrade.Text = results2;

            btnSubmitQuiz.Visible = false;
            gvQuizForm.Visible = false;
            lblQuizName.Visible = false;

        }


    } // end class
} // end ns