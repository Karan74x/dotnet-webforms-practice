<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LINQ._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display All" />
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="524px">
    </asp:GridView>
    <br />
    <br />
    <asp:GridView ID="GridView2" runat="server" Width="524px">
    </asp:GridView>
    <br />
    <asp:GridView ID="GridView3" runat="server" Width="524px">
    </asp:GridView>
    <br />
    <asp:GridView ID="GridView4" runat="server" Width="524px">
    </asp:GridView>
    <br />
    <br />
    <asp:GridView ID="GridView5" runat="server" Width="524px">
    </asp:GridView>
    <br />
    <asp:GridView ID="GridView6" runat="server" Width="524px">
    </asp:GridView>
    <br />
    <asp:GridView ID="GridView7" runat="server" Width="524px">
    </asp:GridView>
    <br />
    <asp:GridView ID="GridView8" runat="server" Width="522px">
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />

</asp:Content>
