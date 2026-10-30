<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Validations._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:Label ID="Label1" runat="server" Text="Student Registeration" Font-Size="X-Large"></asp:Label>

    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Student ID"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:CustomValidator ID= "CustomValidator1"  
        ControlToValidate="TextBox1"
        runat="server"
        OnServerValidate = "CustomValidator1_ServerValidate"
        ErrorMessage="Student Id must Start with STD"></asp:CustomValidator>
    &nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" controltovalidate="TextBox1" runat="server" ErrorMessage="Student Id is Required"></asp:RequiredFieldValidator>
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Full Name"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator  ID="RequiredFieldValidator1" 
        ControlToValidate="TextBox2"
        runat="server" 
        ErrorMessage="Name is Required"></asp:RequiredFieldValidator>
    <br />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    
    <asp:RangeValidator ID="RangeValidator1" 
        ControlToValidate ="TextBox3"
        Type ="Integer"
        runat="server"
        MinimumValue="18"
        MaximumValue="100"
        ErrorMessage="Age must be between 18-100"></asp:RangeValidator>
    <br />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Email Address"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
        runat="server" 
        ControlToValidate="TextBox4"
        ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
        ErrorMessage="Enter a valid email"></asp:RegularExpressionValidator>
    <br />
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Mobile Number"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
        ControlToValidate="TextBox5"
         ValidationExpression="^[0-9]{10}$"
        runat="server" 
        ErrorMessage="Enter a Valid Mobile Number"></asp:RegularExpressionValidator>
    <br />
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox6" TextMode="Password" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
        ControlToValidate="TextBox6"
        runat="server" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
    <br />
    <br />
    <br />
    <asp:Label ID="Label8"  runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;
    <asp:TextBox ID="TextBox7" TextMode="Password" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" 
        ControlToValidate="TextBox7"
        ControlToCompare="TextBox6"
        runat="server" 
        ErrorMessage="Password do not match"></asp:CompareValidator>
    <br />
    <br />
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" BackColor="#3366FF" ForeColor="White" Height="39px" Text="Submit" Width="145px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" CausesValidation="false" runat="server" Height="37px" Text="Clean Form" Width="155px" OnClick="Button2_Click" />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label9" runat="server"></asp:Label>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />

</asp:Content>
