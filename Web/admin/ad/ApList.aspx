<%@ Page Title="role" Language="C#" MasterPageFile="../ListMaster.master" AutoEventWireup="true"
    CodeBehind="ApList.aspx.cs" Inherits="hm.Web.ad.ApList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="title" runat="server">
    广告位管理
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="search" runat="server">
    <table style="width: 95%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td width="21">
                <img src="../images/ico07.gif" width="20" height="18" />
            </td>
            <td style="width: 60px" align="right" class="tdbg">
                <b>关键字：</b>
            </td>
            <td class="tdbg">
                <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" CssClass="right-button02" runat="server" Text="查询" OnClick="btnSearch_Click">
                </asp:Button>
            </td>
            <td class="tdbg">
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="list" runat="server">
    <br />
    <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="4"
        OnPageIndexChanging="gridView_PageIndexChanging" BorderWidth="1px" DataKeyNames="id"
        AutoGenerateColumns="False" RowStyle-HorizontalAlign="Center" BackColor="White"
        BorderColor="#DEDFDE" BorderStyle="None" ForeColor="Black" GridLines="Vertical">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="title" HeaderText="广告位名称" SortExpression="roleName" ItemStyle-HorizontalAlign="Center" />
            <asp:TemplateField HeaderText="广告位类型">
                <ItemTemplate>
                    <%#DataBinder.Eval(Container.DataItem,"typesString")%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="width" HeaderText="宽度" SortExpression="roleName" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="height" HeaderText="高度" SortExpression="roleName" ItemStyle-HorizontalAlign="Center" />
            <asp:TemplateField ControlStyle-Width="50" HeaderText="管理" Visible="true">
                <ItemTemplate>
                    <a href="ApModify.aspx?id=<%#DataBinder.Eval(Container.DataItem,"id")%>">编辑</a>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                        Text="删除"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#e1e5ee" Font-Bold="True" ForeColor="#666666" Font-Size="14px"
            CssClass="nowtable" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle HorizontalAlign="Center" BackColor="#f2f2f2" Font-Size="12px"></RowStyle>
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
        <EmptyDataTemplate>
            暂无信息
        </EmptyDataTemplate>
    </asp:GridView>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
