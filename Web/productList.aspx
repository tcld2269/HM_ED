<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true"
    CodeBehind="productList.aspx.cs" Inherits="hm.Web.productList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
.plist ul{ list-style:none }
.plist ul li{float:left; border:1px solid #eee; text-align:center; margin:10px;}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="rt-container">
    <div class="rt-grid-9 ">
	<div class="rt-block">
		<div id="rt-mainbody">
        <article class="item-page">
					<h2><asp:Literal ID="litNav" runat="server"></asp:Literal>
						</h2>
			<div class="component-content plist">
				<ul>
    <asp:Repeater ID="rptProductList" runat="server">
    <ItemTemplate>
    <li id="node<%#Eval("id")%>" class="item138 parent">
    <a class="item" href="productShow.aspx?id=<%#Eval("id")%>"  ><img width="302px"  src="<%#Eval("picBig")%>" /><br />
                        
                                <span class="rt-item-border"></span>
                                                <%#Eval("title")%>                                <span class="border-fixer"></span>
                            </a>
                            </li>
                        
    </ItemTemplate>
    </asp:Repeater>
        </ul>
        </article>
			</div>
		</div>
	</div>
<div class="rt-grid-3 ">
	<div id="rt-sidebar-b">
		<div class="rt-block box2 title4">
			<div class="module-surround">
				<div class="module-title">
					<h2 class="title">
						产品</h2>
				</div>
				<div class="module-content">
					<ul class="nav menu">
                    <asp:Repeater ID="rptNode" runat="server">
    <ItemTemplate>
    <li class="item-243">
							<a href="productList.aspx?id=<%#Eval("id")%>"><%#Eval("title")%></a></li>
    </ItemTemplate>
    </asp:Repeater>
					</ul>
				</div>
			</div>
		</div>
	</div>
</div>

    
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
