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
        List<FlashcardClass> set = new List<FlashcardClass>();


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
            FlashcardClass flashcard = new FlashcardClass();
            List<FlashcardClass> setInsert = new List<FlashcardClass>();
            String setName = Session["setName"].ToString();

            // get the input values from repeater
            foreach (RepeaterItem item in rptEdit.Items)
            {
                TextBox txtQuestion = (TextBox)item.FindControl("txtQuestion");
                if (txtQuestion.Text != null || !(String.IsNullOrWhiteSpace(txtQuestion.Text)))
                {
                    flashcard.FlashcardQuestion = txtQuestion.Text;
                }
                else if(txtQuestion.Text == null || String.IsNullOrWhiteSpace(txtQuestion.Text))
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = "Question can't be blank...";
                    break;
                }
                TextBox txtAnswer = (TextBox)item.FindControl("txtAnswer");
                if (txtAnswer.Text != null || !(String.IsNullOrWhiteSpace(txtAnswer.Text)))
                {
                    flashcard.FlashcardAnswer = txtAnswer.Text;
                }
                else if (txtAnswer.Text == null || String.IsNullOrWhiteSpace(txtAnswer.Text))
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = "Answer can't be blank...";
                    break;
                }
                TextBox txtImage = (TextBox)item.FindControl("txtImage");
                flashcard.FlashcardImage = txtImage.Text;
                flashcard.FlashcardSet = setName;
                String subject = GetSubject(setName);
                flashcard.FlashcardSubject = subject;
                flashcard.FlashcardUsername = Session["username"].ToString();

                // fill list
                setInsert.Add(flashcard);
               
            }
            // k have all data
            // delete flashcard set
            DeleteFlashcardSet(setName);
            // re-insert data
            Boolean ret = InsertFlashcardSet(setInsert);
            if (ret == true)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Successfully updated " + setName + "!";
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Error editing " + setName + "...";
            }
        }

        private Boolean InsertFlashcardSet(List<FlashcardClass> set)
        {
            // Serialize a list of flashcards into a JSON string.
            JavaScriptSerializer js = new JavaScriptSerializer();
            String jsonFlashcards = js.Serialize(set);

            try
            {
                // Setup an HTTP POST Web Request and get the HTTP Web Response from the server.
                WebRequest request = WebRequest.Create("https://localhost:44355/api/flashcards/insertflashcardset/");
                request.Method = "POST";
                request.ContentLength = jsonFlashcards.Length;
                request.ContentType = "application/json";

                // Write the JSON data to the Web Request
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write(jsonFlashcards);
                writer.Flush();
                writer.Close();

                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();

                if (data == "true")
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Error: " + ex.Message;
                return false;
            }
        }

        private void DeleteFlashcardSet(String setName)
        {
            FlashcardClass flashcard = new FlashcardClass();
            flashcard.FlashcardSet = setName;
            // Serialize a list of flashcards into a JSON string.
            JavaScriptSerializer js = new JavaScriptSerializer();
            String jsonFlashcards = js.Serialize(flashcard);
            try
            {
                // Setup an HTTP POST Web Request and get the HTTP Web Response from the server.
                WebRequest request = WebRequest.Create("https://localhost:44355/api/flashcards/deletesetofflashcards");
                request.Method = "DELETE";
                request.ContentLength = jsonFlashcards.Length;
                request.ContentType = "application/json";

                // Write the JSON data to the Web Request
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write(jsonFlashcards);
                writer.Flush();
                writer.Close();

                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Error...";
            }
        }

        private String GetSubject(String setName)
        {
            String ret ="";
            WebRequest request = WebRequest.Create("https://localhost:44355/api/flashcards/getsubjectbyset/" + setName);
            WebResponse response = request.GetResponse();


            // Read the data from the Web Response, which requires working with streams.
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();

            if (data == "")
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Click on create to make your own flashcard set!";

            }
            else
            {
                ret = data;
            }
            return ret;
        }

        //private void ClearTextboxes()
        //{
        //    foreach(RepeaterItem item in rptEdit.Items)
        //    {
        //        TextBox txtQuestion = (TextBox)item.FindControl("txtQuestion");
        //        txtQuestion.Text = "";
        //        TextBox txtAnswer = (TextBox)item.FindControl("txtAnswer");
        //        txtAnswer.Text = "";
        //        TextBox txtImage = (TextBox)item.FindControl("txtImage");
        //        txtImage.Text = "";
        //    }
        //
        //}


    } // end class
} // end ns