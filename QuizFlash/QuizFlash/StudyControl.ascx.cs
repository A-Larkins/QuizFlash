using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Script.Serialization;  // needed for JSON serializers
using System.IO;                        // needed for Stream and Stream Reader
using System.Net;                       // needed for the Web Request
using QuizFlashLibrary;

namespace QuizFlash
{
    public partial class StudyControl : System.Web.UI.UserControl
    {
        public List<FlashcardClass> flashcardList = new List<FlashcardClass>();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            
           

        }

        // Override the OnPreRender method to bind data to the control
        // before the page load of the aspx page that uses the control.
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            // get the set name that was stored
            HttpCookie theSetNameCookie = Request.Cookies["SetNameCookie"];
            String setName = theSetNameCookie.Values["SetName"].ToString();
            lblSetName.Text = setName;

            GetFlashcardsForSet(setName);
        }

        // quit studying button
        protected void btnRelax_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentHomepage.aspx");
        }

        protected void btnShowAnswer_Click(object sender, EventArgs e)
        {
            lblAnswer.Visible = true;
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void GetFlashcardsForSet(String setName)
        {
            //WebRequest request = WebRequest.Create("https://cis-iis2.temple.edu/fall2020/CIS3342_tuh34847/webapitest/api/flashcards/getflashcardset/" + setName);
            WebRequest request = WebRequest.Create("https://localhost:44355/api/flashcards/getflashcardset/" + setName);
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

            foreach(FlashcardClass flashcard in sets)
            {
                flashcardList.Add(flashcard);
            }

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            lblQuestion.Text = flashcardList[0].FlashcardQuestion.ToString();
            lblAnswer.Text = flashcardList[0].FlashcardAnswer.ToString();
        }



    } // end class
} // end ns