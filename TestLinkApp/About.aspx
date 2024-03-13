<%@ Page Title="UAT" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="TestLinkApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <address>
    <h1>UAT BizVN URL : <asp:HyperLink ID="HyperLink1" runat="server" Text="https://uat.hlb.my/bizvn/login.html " NavigateUrl="https://uat.hlb.my/bizvn/login.html"></asp:HyperLink></h1>
    <h2>Biz VN support center : <asp:HyperLink ID="HyperLink2" runat="server" Text="https://10.119.1.176:8543/bizvnsupportcenter " NavigateUrl="https://10.119.1.176:8543/bizvnsupportcenter"></asp:HyperLink></h2>
    </address>
</asp:Content>
