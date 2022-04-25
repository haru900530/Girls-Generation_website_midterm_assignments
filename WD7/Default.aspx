<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WD7._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <h5 style="color:deeppink">現在，以後，永遠是少女時代</h5><br />
    <asp:Label ID="Label1" runat="server" Text="請先登入"></asp:Label>
    <asp:Panel ID="MyPanel" Visible="false" runat="server">
         <h5>少女時代最新照片(會員獨享)</h5>
        <img src="https://mcusoft.files.wordpress.com/2020/03/snsd.jpg" />
    </asp:Panel>
</asp:Content>
