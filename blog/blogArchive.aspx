<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Layout.Master" CodeBehind="blogarchive.aspx.cs" Inherits="blog.blogArchive" %>



<asp:Content ID="blog_list" ContentPlaceHolderID="body" runat="server">
    <h1> Blog Post Archives</h1>
    <div class="_table" runat="server">
        <div class="listitem">
        <div class="col2">Blog Title</div>
        <div class="col2last">Blog Post</div>
        </div>
    <div id="bloglist_result" runat="server">
        </div>
    </div>
</asp:Content>