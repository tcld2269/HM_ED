<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="node.aspx.cs" Inherits="hm.Web.node" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rt-container">
    <asp:Literal ID="litContent" runat="server"></asp:Literal>
        
        <div class="clear">
        </div>
    </div>
    <script>
        function getQueryString(name) {
            var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
            var r = window.location.search.substr(1).match(reg);
            if (r != null) return unescape(r[2]); return null;
        }
        document.getElementById("nodeMain").className = "item101 last"; 
        document.getElementById("node" + getQueryString("id")).className = "item138 parent active";
    </script>
</asp:Content>
