<%@ Page Title="role" Language="C#" MasterPageFile="../ListMaster.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.ad.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title" runat="server">
广告管理
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="search" runat="server">
<table style="width: 95%;" cellpadding="2" cellspacing="1" class="border">
				<tr>
				<td width="21"><img src="../images/ico07.gif" width="20" height="18" /></td>
                    <td style="width: 90px" align="right" class="tdbg">
						 <b>所属广告位：</b>
					</td>
					<td class="tdbg" style="width:auto">
                        <asp:DropDownList ID="ddlAp" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="ddlAp_SelectedIndexChanged">
                        </asp:DropDownList>
                        <input type="button" value="广告位管理" onclick="location.href='ApList.aspx'" />
                        <input type="button" value="添加广告" onclick="location.href='add.aspx?type=<%=ddlAp.SelectedValue %>'" />
                    </td>
					<td class="tdbg">
					</td>
				</tr>
			</table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="list" runat="server">
			<br />
			<asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" 
					CellPadding="4"  OnPageIndexChanging ="gridView_PageIndexChanging"
					BorderWidth="1px" DataKeyNames="id" OnRowDataBound="gridView_RowDataBound"
					AutoGenerateColumns="False"  RowStyle-HorizontalAlign="Center" 
					OnRowCreated="gridView_OnRowCreated" BackColor="White" BorderColor="#DEDFDE" 
					BorderStyle="None" ForeColor="Black" GridLines="Vertical" 
                onrowdeleting="gridView_RowDeleting">
                <AlternatingRowStyle BackColor="White" />
					<Columns>
		<asp:BoundField DataField="title" HeaderText="标题" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
        <asp:BoundField DataField="url" HeaderText="链接" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
        <asp:TemplateField ControlStyle-Width="30" HeaderText="图片">
                <ItemTemplate>
                    <img width="45px" height="45px" src="<%#DataBinder.Eval(Container.DataItem,"pic").ToString()==""?"/images/nopic.jpg":DataBinder.Eval(Container.DataItem,"pic").ToString() %>" />
                </ItemTemplate>
            </asp:TemplateField>
        <asp:BoundField DataField="startDate" HeaderText="开始日期" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
        <asp:BoundField DataField="endDate" HeaderText="结束日期" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
        <asp:BoundField DataField="addTime" HeaderText="添加日期" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
        <asp:BoundField DataField="statusString" HeaderText="状态" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
        
							<asp:TemplateField ControlStyle-Width="50" HeaderText="管理"   Visible="true"  >
								<ItemTemplate>
                                    <a href="Modify.aspx?id=<%#DataBinder.Eval(Container.DataItem,"id")%>">编辑</a>
									<asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
										 Text="删除"></asp:LinkButton>
								</ItemTemplate>
							</asp:TemplateField>
						</Columns>
					<FooterStyle BackColor="#CCCC99" />
					<HeaderStyle BackColor="#e1e5ee" Font-Bold="True" ForeColor="#666666" Font-Size="14px" CssClass="nowtable" />
					<PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />

<RowStyle HorizontalAlign="Center" BackColor="#f2f2f2" Font-Size="12px"></RowStyle>
					<SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
					<SortedAscendingCellStyle BackColor="#FBFBF2" />
					<SortedAscendingHeaderStyle BackColor="#848384" />
					<SortedDescendingCellStyle BackColor="#EAEAD3" />
					<SortedDescendingHeaderStyle BackColor="#575357" />
				</asp:GridView>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
