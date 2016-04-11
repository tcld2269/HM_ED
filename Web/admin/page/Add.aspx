<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="hm.Web.page.Add" Title="增加页" %>
<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
添加
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	<tr>
	<td height="25" width="30%" align="right">
		所属栏目
	：</td>
	<td height="25" width="*" align="left">
		<asp:Literal ID="litName" runat="server"></asp:Literal><asp:Literal ID="litId" runat="server" Visible="false"></asp:Literal>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		内容
	：</td>
	<td height="25" width="*" align="left">
		<CKEditor:CKEditorControl ID="txtRemark" runat="server" Height="300px"></CKEditor:CKEditorControl>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
