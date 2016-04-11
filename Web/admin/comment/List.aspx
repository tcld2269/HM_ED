<%@ Page Title="role" Language="C#" MasterPageFile="../ListMaster.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="hm.Web.comment.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title" runat="server">
评论管理
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="search" runat="server">
<table style="width: 95%;" cellpadding="2" cellspacing="1" class="border">
				<tr>
				<td width="21"><img src="../images/ico07.gif" width="20" height="18" /></td>
                    <td style="width: 50px" align="right" class="tdbg">
						 <b>类别：</b>
					</td>
					<td class="tdbg" style="width:60px">
                        <asp:DropDownList ID="ddlType" runat="server">
                        <asp:ListItem Value="-1">全部</asp:ListItem>
                        <asp:ListItem Value="0">站点</asp:ListItem>
                        <asp:ListItem Value="1">新闻</asp:ListItem>
                        <asp:ListItem Value="2">单页</asp:ListItem>
                        <asp:ListItem Value="3">产品</asp:ListItem>
                        <asp:ListItem Value="4">综合</asp:ListItem>
                        </asp:DropDownList>
                    </td>
					<td style="width: 60px" align="right" class="tdbg">
						 <b>关键字：</b>
					</td>
					<td class="tdbg">                       
					<asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
					&nbsp;&nbsp;&nbsp;&nbsp;
					<asp:Button ID="Button1" CssClass="right-button02" runat="server" Text="查询"  OnClick="btnSearch_Click" >
					</asp:Button>                    
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
					<Columns>
		<asp:BoundField DataField="title" HeaderText="标题" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
        <asp:TemplateField HeaderText="类别">
        <ItemTemplate>
        <%#DataBinder.Eval(Container.DataItem,"nodeTypeString")%>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="trueName" HeaderText="留言人" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
        <asp:BoundField DataField="tel" HeaderText="电话" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
        <asp:BoundField DataField="title" HeaderText="标题" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
        <asp:BoundField DataField="addTime" HeaderText="留言时间" SortExpression="roleName" ItemStyle-HorizontalAlign="Center"  /> 
							<asp:TemplateField ControlStyle-Width="50" HeaderText="管理"   Visible="true"  >
								<ItemTemplate>
                                    <a href="Show.aspx?id=<%#DataBinder.Eval(Container.DataItem,"id")%>">查看</a>
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
