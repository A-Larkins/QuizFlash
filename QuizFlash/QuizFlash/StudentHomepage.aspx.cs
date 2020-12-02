using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Script.Serialization;  // needed for JSON serializers
using System.IO;                        // needed for Stream and Stream Reader
using System.Net;                       // needed for the Web Request
using QuizFlashLibrary;

namespace QuizFlash
{
    public partial class StudentHomepage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                StudyControl.Visible = false;
                lblUserName.Text = Session["username"].ToString();
                String username = lblUserName.Text;

                BindGVMySets(username);
                BindGVAllSets();
            }
        }

        private void BindGVMySets(String username)
        {
            // Bind to gridview for showing sets of flashcards made by the user
            // user can study, edit, delete the flashcards in these sets
            //WebRequest request = WebRequest.Create("https://cis-iis2.temple.edu/fall2020/CIS3342_tuh34847/webapitest/api/flashcards/getallsetsofflashcardsbyusername/" + username);
            WebRequest request1 = WebRequest.Create("https://localhost:44355/api/flashcards/getallsetsofflashcardsbyusername/" + username);
            WebResponse response1 = request1.GetResponse();

            // Read the data from the Web Response, which requires working with streams.
            Stream theDataStream1 = response1.GetResponseStream();
            StreamReader reader1 = new StreamReader(theDataStream1);
            String data1 = reader1.ReadToEnd();

            reader1.Close();
            response1.Close();

            // Deserialize a JSON string that contains an array of JSON objects into an Array of flashcardset objects.
            JavaScriptSerializer js1 = new JavaScriptSerializer();
            FlashcardSetClass[] sets1 = js1.Deserialize<FlashcardSetClass[]>(data1);

            gvMyFlashcardSets.DataSource = sets1;
            gvMyFlashcardSets.DataBind();
        }

        private void BindGVAllSets()
        {
            // Bind to gridview for showing all sets of flashcards
            // user can only study these flashcard sets
            // with data from flashcards web api
            // Create an HTTP Web Request and get the HTTP Web Response from the server.
            //WebRequest request = WebRequest.Create("https://cis-iis2.temple.edu/fall2020/CIS3342_tuh34847/webapitest/api/flashcards/getallsetsofflashcards");
            WebRequest request = WebRequest.Create("https://localhost:44355/api/flashcards/getallsetsofflashcards");
            WebResponse response = request.GetResponse();

            // Read the data from the Web Response, which requires working with streams.
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();

            reader.Close();
            response.Close();

            // Deserialize a JSON string that contains an array of JSON objects into an Array of flashcardset objects.
            JavaScriptSerializer js = new JavaScriptSerializer();
            FlashcardSetClass[] sets = js.Deserialize<FlashcardSetClass[]>(data);

            gvAllFlashcardSets.DataSource = sets;
            gvAllFlashcardSets.DataBind();
        }
        
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Response.Redirect("LoginPage.aspx");
        }

        // when study button event is fired from gridview
        protected void Study(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = gvAllFlashcardSets.Rows[rowIndex];
            String setName = row.Cells[0].Text;
            HttpCookie setNameCookie = new HttpCookie("SetNameCookie");
            setNameCookie.Values["SetName"] = setName;
            Response.Cookies.Add(setNameCookie);

            HideEverythingElse();
            ShowStudyControl();
        }

        private void ShowStudyControl()
        {
            // use a custom control for studying flashcards
            StudyControl.Visible = true;
            
        }

        private void HideEverythingElse()
        {
            lblAllFlashcardSets.Visible = false;
            lblMyFlashcardSets.Visible = false;
            gvAllFlashcardSets.Visible = false;
            gvMyFlashcardSets.Visible = false;
        }





    } // end class
} // end ns
