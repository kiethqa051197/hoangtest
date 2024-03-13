<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestLinkApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="column">
        <div class="col-md-8">
            <h2>UAT</h2>
            <p>
                <h1>UAT BizVN URL : <asp:HyperLink ID="HyperLink1" runat="server" Text="https://uat.hlb.my/bizvn/login.html " NavigateUrl="https://uat.hlb.my/bizvn/login.html"></asp:HyperLink></h1>
                <h2>Biz VN support center : <asp:HyperLink ID="HyperLink2" runat="server" Text="https://10.119.1.176:8543/bizvnsupportcenter " NavigateUrl="https://10.119.1.176:8543/bizvnsupportcenter"></asp:HyperLink></h2>
            </p>
        </div>
        <div class="col-md-8">
            <h2>Production</h2>
            <p>
                <h1>UAT BizVN URL : <asp:HyperLink ID="HyperLink3" runat="server" Text="https://uat.hlb.my/bizvn/login.html " NavigateUrl="https://uat.hlb.my/bizvn/login.html"></asp:HyperLink></h1>
    <h2>Biz VN support center : <asp:HyperLink ID="HyperLink4" runat="server" Text="https://10.119.1.176:8543/bizvnsupportcenter " NavigateUrl="https://10.119.1.176:8543/bizvnsupportcenter"></asp:HyperLink></h2>
            </p>
        </div>
        <div class="col-md-8">
            <h2>DR</h2>
            <p>
                <h1>UAT BizVN URL : <asp:HyperLink ID="HyperLink5" runat="server" Text="https://uat.hlb.my/bizvn/login.html " NavigateUrl="https://uat.hlb.my/bizvn/login.html"></asp:HyperLink></h1>
    <h2>Biz VN support center : <asp:HyperLink ID="HyperLink6" runat="server" Text="https://10.119.1.176:8543/bizvnsupportcenter " NavigateUrl="https://10.119.1.176:8543/bizvnsupportcenter"></asp:HyperLink></h2>
            </p>
        </div>
    </div>

</asp:Content>
