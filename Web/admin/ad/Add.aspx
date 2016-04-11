<%@ Page Language="C#" MasterPageFile="../MasterPage.master" AutoEventWireup="true"
	CodeBehind="Add.aspx.cs" Inherits="hm.Web.ad.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/js/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
添加广告
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
	<table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
		<tr>
			<td class="tdbg">
				
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
	
    <tr>
	<td height="25" width="30%" align="right">
		广告名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		广告位
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddlAp" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddlAp_SelectedIndexChanged"></asp:DropDownList>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		广告类别
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label ID="lblInfo" runat="server"></asp:Label>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		链接网址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUrl" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		起止时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStartDate" runat="server" Width="85px" onClick="WdatePicker()"></asp:TextBox> - <asp:TextBox id="txtEndDate" runat="server" Width="85px" onClick="WdatePicker()"></asp:TextBox>
	</td></tr>
     <tr>
	<td height="25" width="30%" align="right">
		<asp:Label ID="lblTypeName" runat="server" Text="图片"></asp:Label>
	：</td>
	<td height="25" width="*" align="left">
		<asp:FileUpload ID="flPic" runat="server" />
        <asp:TextBox ID="txtRemark" runat="server" TextMode="MultiLine" Width="350px" Height="100px" Visible="false"></asp:TextBox>
	</td></tr>
     <tr>
	<td height="25" width="30%" align="right">
		排序
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOrders" runat="server" Width="60px"></asp:TextBox>
	</td></tr>
</table>

			</td>
		</tr>
		<tr><th align="cneter"><asp:Button ID="btnSave" runat="server" Text="保存" 
					OnClick="btnSave_Click" class="right-button09"></asp:Button>
				<asp:Button ID="btnCancle" runat="server" Text="取消"
					OnClick="btnCancle_Click" class="right-button09" ></asp:Button></th></tr>
	</table>
	<br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
