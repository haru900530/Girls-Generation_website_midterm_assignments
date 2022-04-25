<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WD7.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>少女時代熱門曲目</h2>
    <asp:Label ID="Label1" runat="server" Text="請先登入"></asp:Label>
    <br />
    <asp:Panel ID="Panel1" runat="server" Visible="False">
        <asp:TextBox ID="TextBox1" runat="server" width="100px" height="30px" ForeColor="#FF9999"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" Text="搜尋歌名"  width="100px" height="30px" OnClick="Button6_Click" BackColor="#FF9999" ForeColor="White"/>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="歌曲編號" DataSourceID="SqlDataSource3" BackColor="White" Font-Size="15pt" ForeColor="#9900FF" Height="300px" Width="600px">
            <Columns>
                <asp:BoundField DataField="歌曲編號" HeaderText="歌曲編號" ReadOnly="True" SortExpression="歌曲編號" />
                <asp:BoundField DataField="排名" HeaderText="排名" SortExpression="排名" />
                <asp:BoundField DataField="發行時間" HeaderText="發行時間" SortExpression="發行時間" />
                <asp:BoundField DataField="歌名" HeaderText="歌名" SortExpression="歌名" />
            </Columns>
        </asp:GridView>
        </asp:Panel>
<asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Table]"></asp:SqlDataSource>
</asp:Content>
