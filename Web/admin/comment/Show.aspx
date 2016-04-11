<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="hm.Web.comment.Show" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
查看留言
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblroleId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		留言标题
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblTitle" runat="server"></asp:label>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		留言类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblType" runat="server"></asp:label>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		留言对象
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblNodeName" runat="server"></asp:label>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		留言人
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblTrueName" runat="server"></asp:label>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblTel" runat="server"></asp:label>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		邮箱  
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblEmail" runat="server"></asp:label>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		留言内容
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblRemark" runat="server"></asp:label>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		留言时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblAddTime" runat="server"></asp:label>
	</td></tr>
    <tr>
    <td colspan="2" align="center">
                <input type="button" value="返回" onclick="history.back()" />
    </td>
    </tr>
</table>

            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

