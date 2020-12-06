<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecoverAccountPage.aspx.cs" Inherits="QuizFlash.RecoverAccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recover Account Page</title>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <script src="https://cdn.jsdelivr.net/jquery.validation/1.15.1/jquery.validate.min.js"></script>
    <link href="https://fonts.googleapis.com/css?family=Kaushan+Script" rel="stylesheet">
    <link href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" integrity="sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN" crossorigin="anonymous">


    <link rel="stylesheet" href="Styles/LoginStyle.css" />



</head>
<body style="background-color:#cfffe4;">

    <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="LoginPage.aspx">
                <img src="/Images/QuizFlashLogo.png" alt="" />
            </a>
    </nav>

    <form id="frmRecoverAccount" runat="server">
        
        <div class="centered w-25 p-3">
            <div class="card" id="cardAccount">
                <div class="logo mb-3" style = "background-color:lightseagreen">
                    <div class="card-header text-center"><h1 style= "color:white;" >Account Recovery</h1></div>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblEmail" style="border-width:2px; border-color:#ffa74a" CssClass="form-control" runat="server" Text="Email" Font-Bold="True" Font-Size="Large"></asp:Label>
                    <asp:TextBox ID="txtEmail" placeholder="you@temple.edu" style="border-width:2px; border-color:lightseagreen" CssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="form-group">
                    <asp:Label ID="lblQuestion1" style="border-width:2px; border-color:#ffa74a" CssClass="form-control" Visible="false" runat="server" Text="Question 1" Font-Bold="True" Font-Size="Large"></asp:Label>
                    <asp:TextBox ID="txtAnswer1" placeholder="Answer 1" style="border-width:2px; border-color:lightseagreen" Visible="false" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblQuestion2" Visible="false" style="border-width:2px; border-color:#ffa74a" CssClass="form-control" runat="server" Text="Question 2" Font-Bold="True" Font-Size="Large"></asp:Label>
                    <asp:TextBox ID="txtAnswer2" Visible="false" placeholder="Answer 2" style="border-width:2px; border-color:lightseagreen" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblQuestion3" Visible="false" style="border-width:2px; border-color:#ffa74a" CssClass="form-control" runat="server" Text="Question 3" Font-Bold="True" Font-Size="Large"></asp:Label>
                    <asp:TextBox ID="txtAnswer3" Visible="false" placeholder="Answer 3" style="border-width:2px; border-color:lightseagreen" CssClass="form-control" runat="server"></asp:TextBox>
                </div>


                <div class="col-md-12 mb-3 text-center">
                    <div class="form-group">
                        <p></p>
                        <asp:Button ID="btnConfirmEmail" CssClass="btn btn-primary" Width="40%" runat="server" Text="Correct Email" OnClick="btnConfirmEmail_Click"   />
                        <p></p>
                        <asp:Button ID="btnSendEmail" Visible="false" CssClass="btn btn-primary" Width="40%" runat="server" Text="Get Credentials" OnClick="btnSendEmail_Click"  />
                        <p></p>
                        <asp:Button ID="btnCancel"  CssClass="btn btn-primary" Width="40%" runat="server" Text="Cancel" OnClick="btnCancel_Click"  />
                        <p></p>
                        <p><asp:Label ID="lblErrorMessage" CssClass="text-danger" runat="server" Text="Error" Visible="False"></asp:Label></p>
                        <p></p>
                    <div class="form-group">
                </div>
        </div>    


            </div>
        </div>
        

    </form>
</body>
</html>
