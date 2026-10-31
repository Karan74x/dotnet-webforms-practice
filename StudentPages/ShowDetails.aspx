<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowDetails.aspx.cs" Inherits="StudentPages.ShowDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <h2>STUDENT INFORMATION<h2>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
        </div>
        <asp:Label ID="Label1" Font-Italic="True" Font-Size="Large" runat="server" ForeColor="#009933"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Select Hobbies" />
    </form>
</body>
</html>
