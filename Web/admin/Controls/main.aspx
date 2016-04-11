<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="hm.Web.Controls.main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../images/skin.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	background-color: #EEF2FB;
}
ul{
    list-style:none;
    margin:0px;
    padding:5px;
    text-align:left;
    font-size:12px;
}
ul li
{
    padding:5px
}
image{border:0px}
.sysinfo tr td{padding:5px; }
.line_table tr td p{color:#333;font-size:12px;padding-left:10px;}
.line_table tr td p a{line-height:12px;color:red}
.line_table tr td p a:link{line-height:12px;color:red}
.verson,.verson:link{font-weight:bold;color:#bf321c;line-height:12px}
-->
</style>
</head>
<body>
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td width="17" valign="top" background="../images/mail_leftbg.gif">
                <img src="../images/left-top-right.gif" width="17" height="29" />
            </td>
            <td valign="top" background="../images/content-bg.gif">
                <table width="100%" height="31" border="0" cellpadding="0" cellspacing="0" class="left_topbg"
                    id="table2">
                    <tr>
                        <td height="31">
                            <div class="titlebt">
                                ��ӭ����</div>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="16" valign="top" background="../images/mail_rightbg.gif">
                <img src="../images/nav-right-bg.gif" width="16" height="29" />
            </td>
        </tr>
        <tr>
            <td valign="middle" background="../images/mail_leftbg.gif">
                &nbsp;
            </td>
            <td valign="top" bgcolor="#F7F8F9">
                <table width="98%" border="0" align="center" cellpadding="0" cellspacing="0">
                    <tr>
                        <td colspan="2" valign="top">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td valign="top">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td width="40%" colspan="2" valign="top">
                            <span class="left_bt">
                                <asp:Literal ID="litLogInfo" runat="server"></asp:Literal></span><br>
                            <br>
                            <span class="left_txt">&nbsp;<img src="../images/ts.gif" width="16" height="16">
                                ��ʾ��<br>
                                <asp:Literal ID="litShowInfo" runat="server"></asp:Literal>
                                
                            </span>
                        </td>
                        <td width="7%">
                            &nbsp;
                        </td>
                        <td width="53%" valign="top">
                            <table width="100%" height="144" border="0" cellpadding="0" cellspacing="0" class="line_table">
                                <tr>
                                    <td width="2%" height="27" background="../images/news-title-bg.gif">
                                        <img src="../images/news-title-bg.gif" width="2" height="27" />
                                    </td>
                                    <td width="98%" background="../images/news-title-bg.gif" class="left_bt2">
                                        ���¶�̬
                                    </td>
                                </tr>
                                <tr>
                                    <td height="102" valign="top" colspan="2">
                                        <div style="height: 112px; overflow: auto">
                                            <ul>
                                                <asp:Repeater ID="rptActive" runat="server">
                                                    <ItemTemplate>
                                                        <li>
                                                            <%#DataBinder.Eval(Container.DataItem,"kc") %></li>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                            </ul>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td height="5" colspan="2">
                                        &nbsp;
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" valign="top">
                            
                            <table width="100px" border="0" cellpadding="0" cellspacing="0" id="secTable">
                                <tbody>
                                    <tr align="middle" height="20">
                                        <td align="center" class="sec2" onclick="secBoard(0)" style="border-top: 1px solid #ccc;
                                            border-left: 1px solid #ccc; border-right: 1px solid #ccc">
                                            ϵͳ��Ϣ
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                            <div style="height: 112px; overflow: auto; width: 100%; height: 225px; border: 1px solid #ccc;font-size:12px;color:#333">
                               <table class="sysinfo">
                               <tr>
                               <td width="100px">����汾��</td><td><asp:Label ID="serverVerson" runat="server"></asp:Label></td>
                               </tr>
                               <tr>
                               <td width="100px">����������</td><td><asp:Label ID="serverName" runat="server"></asp:Label></td>
                               </tr>
                               <tr>
                               <td width="100px">������IP��</td><td><asp:Label ID="serverIP" runat="server"></asp:Label></td>
                               </tr>
                               <tr>
                               <td width="100px">����ϵͳ�汾��</td><td><asp:Label ID="serverSystem" runat="server"></asp:Label></td>
                               </tr>
                               <tr>
                               <td width="100px">ϵͳ��ǰĿ¼��</td><td><asp:Label ID="serverPath" runat="server"></asp:Label></td>
                               </tr>
                               <tr>
                               <td width="100px">��������ǰʱ�䣺</td><td><asp:Label ID="serverDate" runat="server"></asp:Label></td>
                               </tr>
                               <tr>
                               <td width="100px">��ǰIE�汾��</td><td><asp:Label ID="serverIE" runat="server"></asp:Label></td>
                               </tr>
                               <tr>
                               <td width="100px">���ʶ˿ںţ�</td><td><asp:Label ID="serverPort" runat="server"></asp:Label></td>
                               </tr>
                               </table>
                            </div>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td valign="top">
                            <table width="100%" height="250" border="0" cellpadding="0" cellspacing="0" class="line_table">
                                <tr>
                                    <td width="1px" height="27" background="../images/news-title-bg.gif">
                                        
                                    </td>
                                    <td width="99%" height="27" background="../images/news-title-bg.gif" class="left_bt2">
                                        ʹ��˵��
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2" valign="top">
                                        <p>1.���ȱ༭<a href="webset.aspx">��վ����</a>�����ú���վ�Ļ�����Ϣ</p>
                                        <p>2.Ȼ��༭<a href="../node/list.aspx">��վ��Ŀ</a>����Ŀ��Ϊ���š���ҳ����Ʒ���ۺϣ�������������</p>
                                        <p>3.���༭<a href="../media/list.aspx">���ݹ���</a>��ÿ����Ŀ����ϸ��Ϣ</p>
                                        <p>&nbsp;a).������Ŀ�����ϴ����༭��ɾ����Ϣ</p>
                                        <p>&nbsp;b).��ҳ��Ŀ��һ���ɱ༭�ĵ���ҳ�棬������һ������</p>
                                        <p>&nbsp;c).��Ʒ��Ŀ������ӡ��༭��ɾ����Ʒ��Ϣ</p>
                                        <p>&nbsp;d).�ۺ���Ŀ��ΪͼƬ����Ƶ�����أ����������ʵ�ֲ�ͬ����</p>
                                        <p>4.ϵͳ�����б༭��ɫ������Ա���˵���ϵͳ��Ϣ</p>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
        <tr>
            <td height="40" colspan="4">
                <table width="100%" height="1" border="0" cellpadding="0" cellspacing="0" bgcolor="#CCCCCC">
                    <tr>
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td width="2%">
                &nbsp;
            </td>
            <td width="51%" class="left_txt">
                <img src="../images/icon-mail2.gif" width="16" height="11">
                �������䣺1164781677@qq.com<br>
                <img src="../images/icon-phone.gif" width="17" height="14">
                �ٷ���վ��http://www.jneou.com
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    </td>
    <td background="../images/mail_rightbg.gif">
        &nbsp;
    </td>
    </tr>
    <tr>
        <td valign="bottom" background="../images/mail_leftbg.gif">
            <img src="../images/buttom_left2.gif" width="17" height="17" />
        </td>
        <td background="../images/buttom_bgs.gif">
            <img src="../images/buttom_bgs.gif" width="17" height="17">
        </td>
        <td valign="bottom" background="../images/mail_rightbg.gif">
            <img src="../images/buttom_right2.gif" width="16" height="17" />
        </td>
    </tr>
    </table>
</body>
</html>
