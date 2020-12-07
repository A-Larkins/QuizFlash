<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StudyControl.ascx.cs" Inherits="QuizFlash.StudyControl" %>

<div class="card text-center" style="border-color: darkcyan; border-width:thick;" >
  <div class="card-header" style="border-color:darkcyan; border-width: thick; background-color:lightseagreen">
      <asp:Label ID="lblSetName" runat="server" Text="Set Name" Font-Bold="True" Font-Size="XX-Large" ></asp:Label>
  </div>

  <asp:Image ID="flashcardImage" CssClass="card image cap" runat="server" style="background-color:lightgreen" />
  <div class="card-body" style="background-color:lightgreen; ">
    <h5 class="card-title"><asp:Label ID="lblQuestion" runat="server" Font-Size="X-Large" Text="Question Question Question?"></asp:Label></h5>
    
    <p class="card-text"><asp:Label ID="lblAnswer" runat="server" Font-Size="Large" Text="Answer Answer Answer" Visible="False"></asp:Label></p>
    <p class="card-text">
        <asp:Button ID="btnShowAnswer" runat="server" Font-Size="Medium" Text="Reveal" class="btn btn-primary" OnClick="btnShowAnswer_Click" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
        <asp:Button ID="btnRemove" runat="server" Font-Size="Medium" Text="Remove" class="btn btn-primary" OnClick="btnRemove_Click" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; 
        <asp:Button ID="btnRelax" runat="server" Font-Size="Medium" Text="Relax" class="btn btn-primary" OnClick="btnRelax_Click" />
    </p>
    <p class="card-text">
        <asp:Button ID="btnNext" runat="server" Width="40%" Font-Size="Large" Text="Next" class="btn btn-primary" OnClick="btnNext_Click" />
    </p>

  </div>
  
</div>