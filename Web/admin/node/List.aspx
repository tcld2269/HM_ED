<%@ Page Title="menu" Language="C#" MasterPageFile="../ListMaster.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.admin.node.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
<script>
    
    function showModelAdd(index) {
        if (index == "4") {
            document.getElementById("ctl00_ctl00_ContentPlaceHolder1_search_ddrModelAdd").className = "show";
        }
        else {
            document.getElementById("ctl00_ctl00_ContentPlaceHolder1_search_ddrModelAdd").className = "hide";
        }
    }

    function showModel(index) {
        if (index == "4") {
            document.getElementById("ctl00_ctl00_ContentPlaceHolder1_list_ddrModel").className = "show";
        }
        else {
            document.getElementById("ctl00_ctl00_ContentPlaceHolder1_list_ddrModel").className = "hide";
        }
    }
</script>
<style>
.show{display:block}
.hide{display:none}
.left{float:left}
</style>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title" runat="server">
栏目管理
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="search" runat="server">
<table style="width: 95%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                <td width="18"><img src="../images/add.gif" width="16" height="16" /></td>
                    <td style="width: 70px" align="right" class="tdbg">
                         <b>上级栏目：</b>
                    </td>
                    <td class="tdbg" style="width:430px">                       
                    <asp:DropDownList ID="ddrNodeAdd" runat="server"></asp:DropDownList>   
                    栏目名称：
                    <asp:TextBox ID="txtTitleAdd" runat="server" Width="120px"></asp:TextBox> 
                    类型：
                    <asp:DropDownList ID="ddrTypesAdd" runat="server" onChange="showModelAdd(this.value)"></asp:DropDownList> 
                    </td>
                    <td class="tdbg" style="width:55px">   
                    <asp:DropDownList ID="ddrModelAdd" runat="server"></asp:DropDownList>
                    </td>
                    <td class="tdbg">   
                    路径：
                    <asp:TextBox ID="txtUrlAdd" runat="server" Width="150px" placeholder="填0则不进行任何跳转"></asp:TextBox> 
                    排序：
                    <asp:TextBox ID="txtOrderAdd" runat="server" Width="20px" Text="1"></asp:TextBox> 
                    显示：
                    <asp:CheckBox ID="cbShowAdd" runat="server" Checked="true" />
                    &nbsp;
                    <asp:Button ID="Button1" CssClass="right-button02" runat="server" Text="添加栏目"  OnClick="btnAdd_Click" >
                    </asp:Button>   
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="list" runat="server">
<div style="float:left;width:50%">
<asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" ShowLines="True" 
        onselectednodechanged="TreeView1_SelectedNodeChanged" >
    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
    <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" 
        HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
    <ParentNodeStyle Font-Bold="False" />
    <SelectedNodeStyle Font-Bold="True" />
    </asp:TreeView>
</div>
<div style="float:left;width:50%">
<table width="100%" border="0" cellpadding="4" cellspacing="1" class="show-table">
<tr>
	<td height="25" width="100%" colspan="2" align="center">
		修改栏目
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		上级栏目
	：</td>
	<td height="25" width="*" align="left">
		<asp:DropDownList ID="ddrParent" runat="server"></asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		栏目名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle" runat="server" Width="200px" MaxLength="50"></asp:TextBox><span class="red">* </span>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		类型
	：</td>
	<td height="25" width="*" align="left">
		
        <asp:DropDownList ID="ddrTypes" runat="server" onChange="showModel(this.value)" CssClass="left"></asp:DropDownList> 
        
        <asp:DropDownList ID="ddrModel" runat="server" CssClass="left"></asp:DropDownList>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		路径
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUrl" runat="server" Width="200px" MaxLength="50"  placeholder="填0则不进行任何跳转"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		排序
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOrder" runat="server" Width="200px" MaxLength="50"></asp:TextBox><span class="red">* </span>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		是否显示
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="cbShow" runat="server" Checked="true" />
	</td></tr>
    <tr>
	<td height="25" width="100%" colspan="2" align="center">
		<asp:Button ID="btnMod" runat="server" Text="修改" OnClick="btnMod_Click" /> <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click" OnClientClick="return confirm('确定删除？')" />
	</td></tr>
</table>
</div>
<script>

</script>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
