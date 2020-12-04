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
    public partial class EditFlashcardSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                String setname = Session["setName"].ToString();
                GetFlashcardsForSet(setname);
                
            }
        }
        
        private void GetFlashcardsForSet(String setName)
        {
            List<FlashcardClass> set = new List<FlashcardClass>();

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


            foreach (FlashcardClass flashcard in sets)
            {
                set.Add(flashcard);
            }

            rptEdit.DataSource = set;
            rptEdit.DataBind();
            
        }
        

        protected void btnLogout_Click1(object sender, EventArgs e)
        {
            Session["username"] = "";
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // delete flashcard set

            // check that input is valid and then re-insert data


        }


    } // end class
} // end ns