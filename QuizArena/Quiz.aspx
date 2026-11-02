<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="QuizArena.Quiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  
         <form id="form2" runat="server">

        <h2>QuizArena - Online Quiz</h2>

        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br /><br />

        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        </asp:RadioButtonList>

        <br />

        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList2" runat="server">
        </asp:RadioButtonList>

             <br />

        <br />

        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList3" runat="server">
        </asp:RadioButtonList>

             <br />
             <br />

        <br />

        <asp:Button ID="Button1" runat="server"
            Text="Submit Quiz" OnClick="Button1_Click" />

        <br /><br />

        <asp:Label ID="Label4" runat="server"></asp:Label>

    </form>

</body>
</html>
