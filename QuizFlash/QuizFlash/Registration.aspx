<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="QuizFlash.Registration" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">


    <title>Registration Page</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <link rel="stylesheet" href="Styles/LoginStyle.css" />

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <%--    ~~~~~~used for dropdown button~~~~--%>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>


</head>
<body style="background-color: #cfffe4;" >

    <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="LoginPage.aspx">
                <img src="/Images/QuizFlashLogo.png" alt="" />
            </a>
    </nav>

    <form id="frmRegistration" runat="server" style="padding-top:80px; margin-left: 0%; margin-right: 0%; width: 65%">
        
        <div class="row">
            <div class="col">
                <h1 style="text-align:center; padding-bottom:80px; padding-left:600px;">Registration</h1>
            </div>
        </div>
        <div class="row" style="padding-bottom:20px;">
            <div class="col centered">
                <asp:DropDownList ID="ddlUserType" style="border-width:2px; border-color:lightseagreen" CssClass = "form-control" runat="server">
                    <asp:ListItem>Student</asp:ListItem>
                    <asp:ListItem>Teacher</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col centered">
                 <asp:TextBox ID="txtEmail" placeholder="Email" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>

            </div>
        </div>
        <div class="row" style="padding-bottom:20px;">
            <div class="col centered">
                <asp:TextBox ID="txtUsername" placeholder="Username" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>
                 
            </div>
            <div class="col centered">
                <asp:TextBox ID="txtPassword"  placeholder="Password" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>

            </div>    
        </div>
        
        <div class="row" style="padding-bottom:20px;">
            <div class="col centered">
                <asp:TextBox ID="txtFirstName"  placeholder="First Name" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>

            </div>
            <div class="col centered">
                <asp:TextBox ID="txtLastName"  placeholder="Last Name" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>

            </div>
        </div>
        <div class="row" style="padding-bottom:20px;">
            <div class="col centered">
                <asp:TextBox ID="txtSecurityQ1"  placeholder="Security Question 1" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>

            </div>
            <div class="col centered">
                <asp:TextBox ID="txtSecurityA1"  placeholder="Security Answer 1" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>

            </div>
        </div>
        <div class="row" style="padding-bottom:20px;">
            <div class="col centered">
                <asp:TextBox ID="txtSecurityQ2" placeholder="Security Question 2" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>

            </div>
            <div class="col centered" >
                <asp:TextBox ID="txtSecurityA2" placeholder="Security Answer 2" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>

            </div>
        </div>
        <div class="row" style="padding-bottom:20px;">
            <div class="col centered">
                <asp:TextBox ID="txtSecurityQ3"  placeholder="Security Question 3" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>

            </div>
            <div class="col centered">
                <asp:TextBox ID="txtSecurityA3"  placeholder="Security Answer 3" CssClass="form-control" style="border-width:2px; border-color:lightseagreen" runat="server"></asp:TextBox>

            </div>
        </div>
        <div class="row centered" style="padding-top:600px;" >
            <div class="col centered">
                <asp:Button ID="btnRegister" Width="250px" CssClass="btn btn-primary" runat="server" Text="Register" OnClick="btnRegister_Click" />

            </div>
        </div>
        <div class="row centered" style="padding-top:500px;">
            <div class="col centered">
                <asp:Button ID="btnCancel" Width="250px"  CssClass="btn btn-primary" runat="server" Text="Cancel" OnClick="btnCancel_Click" />

            </div>
        </div>
        <div class="row centered" style="padding-top:400px;">
            <div class="col centered">
                <asp:Label ID="lblErrorMessage"  runat="server" CssClass="form-control text-center" Text="Error" Visible="false" ForeColor="Red" Font-Size="Large"></asp:Label>

            </div>

        </div>

            
        




        
    </form>
</body>
</html>
