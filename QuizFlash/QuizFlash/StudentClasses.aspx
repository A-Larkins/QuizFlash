<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentClasses.aspx.cs" Inherits="QuizFlash.StudentClasses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Classes</title>

    
    <link rel="stylesheet" href="Styles/HomepageStyle.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

    <%--    ~~~~~~used for dropdown button~~~~--%>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

</head>
<body style="background-color: #d0d0d0">
    <form id="frmStudentClasses" runat="server">
        
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

        <div><p></p></div>
        <div class="d-flex justify-content-center">
            <h1><asp:Label ID="lblMyClasses" runat="server" Text="My Classes"></asp:Label></h1>
        </div>
        
        <div class="row justify-content-center">
            <div class="col-8">
                <div class="table-responsive">
                    <div class="table">
                        <asp:GridView ID="gvClasses" BackColor="LightGreen" BorderWidth="4px" BorderColor="DarkCyan" CssClass="table table-striped" runat="server" AutoGenerateColumns="False" OnRowCommand="gvClasses_RowCommand">
                            <Columns>
                                <asp:BoundField HeaderStyle-BackColor="LightSeaGreen" DataField="ClassName" HeaderText="Class" >
                                <HeaderStyle BackColor="LightSeaGreen"></HeaderStyle>
                                </asp:BoundField>
                                <asp:ButtonField ButtonType="Button" Text="Quizzes" ControlStyle-Width="75%" ControlStyle-CssClass="btn btn-primary" ItemStyle-HorizontalAlign="Center" CommandName="Quizzes" >
                                <ControlStyle CssClass="btn btn-primary" Width="75%"></ControlStyle>

                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>

        <div><p></p></div>
        <div class="d-flex justify-content-center">
            <h1><asp:Label ID="lblQuizzes" runat="server" Visible ="false" Text="Class Quizzes"></asp:Label></h1>
        </div>
        
        <div class="row justify-content-center">
            <div class="col-8">
                <div class="table-responsive">
                    <div class="table">
                        <asp:GridView ID="gvQuizzes" BackColor="LightGreen" BorderWidth="4px" BorderColor="DarkCyan" CssClass="table table-striped" runat="server" AutoGenerateColumns="False" OnRowCommand="gvQuizzes_RowCommand" Visible="False" >
                            <Columns>
                                <asp:BoundField HeaderStyle-BackColor="LightSeaGreen" DataField="QuizName" HeaderText="Quiz" >
                                <HeaderStyle BackColor="LightSeaGreen"></HeaderStyle>
                                </asp:BoundField>
                                <asp:ButtonField ButtonType="Button" Text="Take Quiz" ControlStyle-Width="75%" ControlStyle-CssClass="btn btn-primary" ItemStyle-HorizontalAlign="Center" CommandName="TakeQuiz" >
                                <ControlStyle CssClass="btn btn-primary" Width="75%"></ControlStyle>

                                <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>


    </form>
</body>
</html>
