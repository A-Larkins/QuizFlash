<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClassPage.aspx.cs" Inherits="QuizFlash.ClassPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Class Page</title>

    <link rel="stylesheet" href="Styles/HomepageStyle.css" />
    <link rel="stylesheet" href="Styles/StudyStyle.css" />

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <%--    ~~~~~~used for dropdown button~~~~--%>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="frmClassPage" runat="server">
        <nav class="navbar navbar-expand-lg" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="TeacherHomepage.aspx">
                <img src="/Images/QuizFlashLogo.png" alt="" /></a>
            
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item mx-1">
                        <asp:TextBox ID="txtSearchSets" Text="Search..." CssClass="form-control" Width="200px" runat="server"></asp:TextBox>
                    </li>
                    <li>
                        <asp:Button ID="btnSearchSets" runat="server" Text="Search" CssClass="btn btn-info" OnClick="btnSearchSets_Click" />
                        &nbsp; &nbsp; &nbsp;
                    </li>
                    <li class="nav-item mx-1">
                        <a class="navbar-brand text-light" href="TeacherClasses.aspx">Classes</a>
                    </li>
                    <li class="nav-item mx-1">
                        <a class="navbar-brand text-light" href="TeacherCreate.aspx">Create</a>
                    </li>
                    
                </ul>
                <div class="form-inline my-2 my-lg-0">
                    <asp:Label ID="lblUserName" runat="server" CssClass="navbar-brand text-light" Text="Username"></asp:Label>
                    &nbsp; &nbsp;
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-info" OnClick="btnLogout_Click" />
                </div>
            </div>
        </nav>

        <div>
            <asp:GridView ID="gvSets" runat="server">
            </asp:GridView>
            <asp:GridView ID="gvStudents" runat="server">
                <EmptyDataTemplate>
                    <asp:Button ID="btnRemove" runat="server" Text="Remove Student" />
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
