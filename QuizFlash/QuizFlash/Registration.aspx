<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="QuizFlash.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
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
<body>

    <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light">
                <img src="/Images/QuizFlashLogo.png" alt="" />
            </a>
    </nav>


    <form id="frmRegistration" runat="server">
        <div class="centered">
            <div class="form-group">
                <h1>Registration</h1>
            </div>
            <div class="form-group">
                <asp:Label ID="lblUserType" CssClass ="form-control" runat="server" Text="User Type: "></asp:Label>
                <asp:DropDownList ID="ddlUserType" Width="300px" CssClass ="form-control" runat="server">
                    <asp:ListItem>Student</asp:ListItem>
                    <asp:ListItem>Teacher</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="lblUsername" CssClass="form-control" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="txtUsername" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblPassword" CssClass="form-control" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblFirstName" CssClass="form-control" runat="server" Text="First Name"></asp:Label>
                <asp:TextBox ID="txtFirstName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblLastName" CssClass="form-control" runat="server" Text="Last Name"></asp:Label>
                <asp:TextBox ID="txtLastName" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblEmail" CssClass="form-control" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnCancel" CssClass="form-control" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                <br />
                <asp:Button ID="btnRegister" CssClass="form-control" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
            <div>
                <asp:Label ID="lblErrorMessage" runat="server" CssClass="form-control" Text="Error" Visible="false" ForeColor="Red" Font-Size="Large"></asp:Label>
            </div>

        </div>


    </form>
</body>
</html>
