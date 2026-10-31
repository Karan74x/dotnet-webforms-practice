<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hobbies.aspx.cs" Inherits="StudentPages.Hobbies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>
            Select the Hobbies</h2>
        <asp:Label ID="Label1" runat="server" Text="Hobbies"></asp:Label>
        :
        <asp:ListBox ID="ListBox1" runat="server" Height="117px" SelectionMode="Multiple">
            <asp:ListItem>Select the Hobbies</asp:ListItem>
            <asp:ListItem>Reading</asp:ListItem>
            <asp:ListItem>Meditation</asp:ListItem>
            <asp:ListItem>Coding</asp:ListItem>
            <asp:ListItem>Running</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
