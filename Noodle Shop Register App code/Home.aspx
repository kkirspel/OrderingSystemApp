<%@ Page Title="Home" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Home.aspx.vb" Inherits="Noodle_Shop_Register_App._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Home</h2>
    <p>
        
        <asp:Label ID="lblFirstName" runat="server" Text="First Name:"></asp:Label>
        <br />
        <asp:TextBox ID="txtFirstName" runat="server" AutoPostBack="True" TabIndex="1" 
            Width="160px" ToolTip="Enter First Name"></asp:TextBox>
        <asp:Label ID="lblFirstNameError" runat="server"></asp:Label>
        
    </p>
    <p>
       
        <asp:Label ID="lblLastName" runat="server" Text="Last Name:"></asp:Label>
        <br />
        <asp:TextBox ID="txtLastName" runat="server" AutoPostBack="True" TabIndex="2" 
            Width="160px" ToolTip="Enter Last Name"></asp:TextBox>
        <asp:Label ID="lblLastNameError" runat="server"></asp:Label>
       
    </p>
    <p>
       
        <asp:Label ID="lblEmail" runat="server" Text="Email Address:"></asp:Label>
        <br />
        <asp:TextBox ID="txtEmail" runat="server" AutoPostBack="True" TabIndex="3" Width="160px" ToolTip="Enter Email Address"></asp:TextBox>
        <asp:RegularExpressionValidator ID="revEmail" runat="server" 
            ControlToValidate="txtEmail" ErrorMessage="* incorrect email format" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
       
    </p>
    <p>
       
    <asp:Button ID="btnClear" runat="server" Text="Clear" Width="100px" TabIndex="4" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnContinue" runat="server" Enabled="False" Text="Continue" Width="100px" TabIndex="5" />
    </p>
</asp:Content>
