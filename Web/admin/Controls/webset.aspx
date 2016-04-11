<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true" CodeBehind="webset.aspx.cs" Inherits="hm.Web.Controls.webset" Title="修改页" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
网站设置
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	<tr>
	<td height="25" width="30%" align="right">
		网站名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtWebName" runat="server" Width="300px"></asp:TextBox>
	</td></tr>
    
    <tr>
	<td height="25" width="30%" align="right">
		网站Logo
	：</td>
	<td height="25" width="*" align="left">
		<asp:FileUpload ID="flLogo" runat="server" />
        <asp:Image ID="image1" runat="server" Width="100px" />
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		底部信息
	：</td>
	<td height="25" width="*" align="left">
        <CKEditor:CKEditorControl ID="txtBottom" runat="server" Height="60px"></CKEditor:CKEditorControl>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		联系QQ
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtQQ" runat="server" Width="300px" Height="50" TextMode="MultiLine"></asp:TextBox> <span style=" vertical-align:top;line-height:40px">(多个QQ请用 | 隔开)</span>
	</td></tr>
    <tr>
    <td colspan="2" style="background-color:#dedede; text-align:center; padding:10px; font-weight:bold">推广信息</td>
    </tr>
    <tr>
	<td height="25" width="30%" align="right">
		网站标题
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtWebTitle" runat="server" Width="300px"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		关键字
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtKeywords" runat="server" Width="300px" Height="50" TextMode="MultiLine"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		描述
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtDes" runat="server" Width="300px" Height="50" TextMode="MultiLine"></asp:TextBox>
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

