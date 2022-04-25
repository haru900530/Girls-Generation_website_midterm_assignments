<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WD7.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>關於少女時代你不能不知道的事</h2>
    <asp:Label ID="Label1" runat="server" Text="請先登入"></asp:Label>
    <br />    
    <asp:Panel ID="Panel1" runat="server" Visible="False" Font-Size="12pt">
        <asp:Label ID="Label2" runat="server" ForeColor="#FF66CC" Font-Size="15pt"></asp:Label>
        <br />
        <img src="https://a.ksd-i.com/a/2017-07-13/96324-525225.jpg" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" BackColor="#FF6699" Font-Size="15pt"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" ForeColor="#FF66CC" Font-Size="15pt"></asp:Label>
        <br />
        <img src="https://cdn2.ettoday.net/images/5052/d5052558.jpg" />
    </asp:Panel>
</asp:Content>
