<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="newblogpost.aspx.cs" Inherits="blog.newblogpost" %>

<asp:Content ID="newblogpost" ContentPlaceHolderID="body" runat="server">
    <h2>New Blog Post</h2>
    <label>Page Title</label>
    
    <div class="formrow">
    <asp:TextBox runat="server" ID="page_title"></asp:TextBox>
    </div>

    <div class="formrow">
        <asp:TextBox runat="server" ID="page_body"></asp:TextBox>
    </div>

    <asp:Button OnClick="AddPost" Text="Add Post" runat="server" />

    </asp:Content>