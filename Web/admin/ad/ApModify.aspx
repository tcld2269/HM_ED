<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true" CodeBehind="ApModify.aspx.cs" Inherits="hm.Web.ad.ApModify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
编辑广告位
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		广告位名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		广告类型
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlTypes" runat="server"></asp:DropDownList>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		宽*高
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWidth" runat="server" Width="80px"></asp:TextBox> * <asp:TextBox id="txtHeight" runat="server" Width="80px"></asp:TextBox>
	</td></tr>
    <tr>
    <td colspan="2">
    <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="right-button09"></asp:Button>
<input name="btnFanhui" type="button" class="right-button09" value="返回" onclick="history.go(-1)" />
    </td>
    </tr>
</table>

            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

