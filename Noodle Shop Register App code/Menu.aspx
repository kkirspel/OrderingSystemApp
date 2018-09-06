<%@ Page Title="Menu" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Menu.aspx.vb" Inherits="Noodle_Shop_Register_App.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Menu</h2>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="cbxNoodle" runat="server" Text="Noodle Soup" AutoPostBack="True" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlNoodle" runat="server" Width="160px" Enabled="False" AutoPostBack="True">
            <asp:ListItem>Choose One:</asp:ListItem>
            <asp:ListItem>Miso Ramen</asp:ListItem>
            <asp:ListItem>Kitsune Udon</asp:ListItem>
            <asp:ListItem>Zaru Soba</asp:ListItem>
            <asp:ListItem>Shoyu Ramen</asp:ListItem>
            <asp:ListItem>Tonkotsu Ramen</asp:ListItem>
            <asp:ListItem>Tonkotsu-Shoyu Ramen</asp:ListItem>
        </asp:DropDownList>
        <br />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="cbxRice" runat="server" Text="Rice" AutoPostBack="True" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlRice" runat="server" Width="160px" Enabled="False" AutoPostBack="True">
            <asp:ListItem>Choose One:</asp:ListItem>
            <asp:ListItem>Fried Rice (Small)</asp:ListItem>
            <asp:ListItem>Fried Rice (Regular)</asp:ListItem>
            <asp:ListItem>Kimchi Fried Rice</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;
    </p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="cbxOther" runat="server" Text="Other Dish" AutoPostBack="True" />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlOther" runat="server" Enabled="False" Width="160px" AutoPostBack="True">
        <asp:ListItem>Choose One:</asp:ListItem>
        <asp:ListItem>Gyoza</asp:ListItem>
    </asp:DropDownList>
    </p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:CheckBox ID="cbxToppings" runat="server" Text="Toppings" 
        AutoPostBack="True" />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlToppings" runat="server" Width="160px" 
        Enabled="False" AutoPostBack="True">
            <asp:ListItem>Choose One:</asp:ListItem>
            <asp:ListItem>Kaedama</asp:ListItem>
            <asp:ListItem>Chashu Pork</asp:ListItem>
            <asp:ListItem>Nori</asp:ListItem>
            <asp:ListItem>Kimchi</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="cbxTea" runat="server" Text="Tea" AutoPostBack="True" />
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlTea" runat="server" Width="160px" Enabled="False" AutoPostBack="True">
            <asp:ListItem>Choose One:</asp:ListItem>
            <asp:ListItem>Oolong Tea</asp:ListItem>
            <asp:ListItem>Green Tea</asp:ListItem>
        </asp:DropDownList>
    </p>
<p>
    <asp:Button ID="btnClear" runat="server" Text="Clear" Width="100px" />
    &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnContinue" runat="server" Enabled="False" Text="Continue" Width="100px" />
    </p>
</asp:Content>
