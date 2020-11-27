<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherCreate.aspx.cs" Inherits="QuizFlash.TeacherCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher Create</title>

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
    <form id="frmTeacherCreate" runat="server">
        
        <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="StudentHomepage.aspx">
                <img src="/Images/QuizFlashLogo.png" alt="" /></a>
            
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav mr-auto">
                   
                    
                </ul>
                <div class="form-inline my-2 my-lg-0">
                    <asp:Label ID="lblUserName" runat="server" CssClass="navbar-brand text-light" Text="Username"></asp:Label>
                    &nbsp; &nbsp;
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-info" OnClick="btnLogout_Click" />
                </div>
            </div>
        </nav>

    </form>
</body>
</html>
