<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherClasses.aspx.cs" Inherits="QuizFlash.TeacherClasses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Teacher Classes</title>


    <link rel="stylesheet" href="" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <%--    ~~~~~~used for dropdown button~~~~--%>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

    <style type="text/css">
        .auto-style1 {
            left: 1px;
            top: 3px;
        }
    </style>

</head>
<body>
    <form id="frmTeacherClasses" runat="server">
        
        <nav class="auto-style1" style="background-color: #8ec0e7; background: #8ec0e7;">
            <a class="navbar-brand text-light" href="TeacherHomepage.aspx">
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

        <div class="container-fluid">
            <div class="d-flex justify-content-center">
                <div class="row">

                    <asp:GridView ID="gvClasses" runat="server" OnSelectedIndexChanged="gvClasses_SelectedIndexChanged">
                        <Columns>
                            <asp:TemplateField HeaderText="Open Class">
                                <ItemTemplate>
                                    <asp:Button ID="btnOpen" runat="server" OnClick="Button1_Click" Text="Open Class" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <asp:Label ID="lblClassName" runat="server" Text="Enter a class name:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtClassName" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lblClassSubject" runat="server" Text="Enter a class subject:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtClassSubject" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnCreateClass" runat="server" Text="Create Class" OnClick="btnCreateClass_Click1" />
&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnDeleteClass" runat="server" Text="Delete Class" OnClick="btnCreateClass_Click1" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblClassError" runat="server" Text="Error"></asp:Label>

                </div>
            </div>
        </div>

        <div class="container-fluid">
            <div class="d-flex justify-content-center">
                <div class="row">

                    *Forms for adding a new class, editing a class, editing a quiz*

                </div>
            </div>
        </div>

    </form>
</body>
</html>
