<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckIn.aspx.cs" Inherits="WD7.CheckIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h5>請輸入代號與密碼，然後按確定</h5><br />
    <asp:Label ID="Label1" runat="server" Text="代號"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="100px"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="密碼"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="100px"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="確定" OnClick="Button1_Click" />
    <asp:Label ID="Label3" runat="server" Text=" "></asp:Label>
    <asp:Label ID="Label4" runat="server" Text=" "></asp:Label>
</asp:Content>
