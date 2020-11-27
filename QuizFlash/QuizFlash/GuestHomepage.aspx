<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuestHomepage.aspx.cs" Inherits="QuizFlash.GuestHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guest Homepage</title>
    
    <link rel="stylesheet" href="master.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <%--    ~~~~~~used for dropdown button~~~~--%>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="frmGuestHomepage" runat="server">
        
        <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="#">
                <img src="/Images/QuizFlashLogo.png" alt="" /></a>
            

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item mx-1">
                        <asp:TextBox ID="txtSearchSets" CssClass="form-control" Width="200px" runat="server"></asp:TextBox>
                    </li>
                    <li>
                        <asp:Button ID="btnSearchSets" runat="server" Text="Search" CssClass="btn btn-info" />
                    </li>
                </ul>
                <div class="form-inline my-2 my-lg-0">
                    <asp:Button ID="btnCreateAnAccount" runat="server" Text="Account" CssClass="btn btn-info" OnClick="btnCreateAnAccount_Click" />
                </div>
            </div>
        </nav>

    </form>
</body>
</html>
