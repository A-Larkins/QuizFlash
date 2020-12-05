<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="QuizFlash.LoginControl" %>

<div class="centered w-25 p-3">

    <div class="card" style="border-width:5px; border-color:lightseagreen">
        <div class="logo mb-3" Style="background-color:lightseagreen">
            <div class="card-header text-center">
                <h1 style= "color:white;" >Login</h1>
            </div>
        </div>
        <div class="form-group" >
            <asp:Label ID="lblUserType" CssClass ="form-control" style="border-width:2px; border-color:#ffa74a" runat="server" Text="User Type" Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:DropDownList ID="ddlUserType" style="border-width:2px; border-color:lightseagreen" CssClass ="form-control" runat="server">
                <asp:ListItem>Student</asp:ListItem>
                <asp:ListItem>Teacher</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label ID="lblUsername" style="border-width:2px; border-color:#ffa74a" CssClass="form-control" runat="server" Text="Username" Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="txtUsername" style="border-width:2px; border-color:lightseagreen" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblPassword" style="border-width:2px; border-color:#ffa74a" CssClass="form-control" runat="server" Text="Password" Font-Bold="True" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="txtPassword" style="border-width:2px; border-color:lightseagreen" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <div class="form-checked text-center">
                <asp:CheckBox ID="chkRememberMe" runat="server" />
                <asp:Label ID="lblRememberMe"  runat="server" Text="Remember Me"></asp:Label>
            </div>
        </div>
        
        <div class="col-md-12 mb-3 text-center">
            <div class="form-group">
        
                <asp:Button ID="btnLogin" CssClass="btn btn-primary" Width="40%" runat="server" Text="Login" OnClick="btnLogin_Click"  />
                <p><asp:Label ID="lblErrorMessage" CssClass="text-danger" runat="server" Text="Error" Visible="False"></asp:Label></p>
                <p></p>
                <p class="text-center">Create a new account: <asp:Button ID="btnRegister" CssClass="btn btn-link" runat="server" Text="Register" OnClick="Register_Click" /></p>
                <p class="text-center">Enter as guest: <asp:Button ID="btnGuest" CssClass="btn btn-link" runat="server" Text="Continue As Guest" OnClick="btnGuest_Click" /></p>
                <div class="form-group">
            </div>
        </div>       
        
    </div>
</div>
