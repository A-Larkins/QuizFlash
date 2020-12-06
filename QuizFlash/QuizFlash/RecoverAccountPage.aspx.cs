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
    public partial class RecoverAccountPage : System.Web.UI.Page
    {
        public static User user;
        private Encrypt encryptor;


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
        

        private void LoadForm()
        {
            btnConfirmEmail.Visible = false;
            btnSendEmail.Visible = true;
            lblEmail.Visible = false;
            txtEmail.Visible = false;
            lblQuestion1.Visible = true;
            txtAnswer1.Visible = true;
            lblQuestion2.Visible = true;
            txtAnswer2.Visible = true;
            lblQuestion3.Visible = true;
            txtAnswer3.Visible = true;
        }

        
        protected void btnConfirmEmail_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Enter an email...";
            }
            else
            {
                String emailIn = txtEmail.Text;
                LoginClass login = new LoginClass();
                Boolean userIsStudent = login.AccountExistsInStudents(emailIn);
                Boolean userIsTeacher = login.AccountExistsInTeachers(emailIn);
                if (userIsStudent || userIsTeacher)
                {
                    if(userIsStudent)
                    {
                        user = login.GetQuestionsAndAnswersForStudent(emailIn);
                        lblQuestion1.Text = user.Question1.ToString();
                        lblQuestion2.Text = user.Question2.ToString();
                        lblQuestion3.Text = user.Question3.ToString();
                        LoadForm();
                    }
                    else if (userIsTeacher) {
                        user = login.GetQuestionsAndAnswersForTeacher(emailIn);
                            lblQuestion1.Text = user.Question1.ToString();
                            lblQuestion2.Text = user.Question2.ToString();
                            lblQuestion3.Text = user.Question3.ToString();
                    }
                    
                }
                else
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = "No account with that email...";
                }
            }
        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            Boolean valid = false;
            if(!String.IsNullOrWhiteSpace(txtAnswer1.Text) && !String.IsNullOrWhiteSpace(txtAnswer2.Text)
                && !String.IsNullOrWhiteSpace(txtAnswer3.Text))
            {
                valid = true;
            }

            if(valid)
            {
                encryptor = new Encrypt();
                String emailIn = txtEmail.Text;
                String inAnswer1 = txtAnswer1.Text;
                String inAnswer2 = txtAnswer2.Text;
                String inAnswer3 = txtAnswer3.Text;
                String password = user.Password.ToString();
                String decrpyted;
                decrpyted = encryptor.DoDecryption(password);
                String emailMessage = "Your username: " + user.Username + " Your password: " + decrpyted;
                if (inAnswer1 == user.Answer1.ToString() && inAnswer2 == user.Answer2.ToString()
                    && inAnswer3 == user.Answer3.ToString())
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = "Your username: " + user.Username + " Your password: " + decrpyted;

                    //Email email = new Email();
                    //try
                    //{
                    //    String sentBy = "tuh34847@temple.edu";
                    //    String sub = "Your account recovery information";
                    //
                    //    email.SendMail(emailIn, sentBy, sub, emailMessage);
                    //    lblErrorMessage.Visible = true;
                    //    lblErrorMessage.Text = "You've got mail...";
                    //    return;
                    //}
                    //catch (Exception ex)
                    //{
                    //    lblErrorMessage.Visible = true;
                    //    lblErrorMessage.Text = "There was a problem sending the email...";
                    //    return;
                    //}
                }
                else
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = "Imposter...";
                }
            }
            else
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "Fill out the answer form to get your login credentials...";
            }
            
        }




    } // end class
} // end ns