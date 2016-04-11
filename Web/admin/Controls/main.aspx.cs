using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Microsoft.Win32;

namespace hm.Web.Controls
{
    public partial class main : AdminPage
    {
        BLL.users uBll = new BLL.users();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindDate();

                bindSysInfo();
            }
        }

        private void bindSysInfo()
        {
            this.serverVerson.Text = "<a href='#' class='verson'>1.1正式版</a>";
            //获取服务器名
            this.serverName.Text = "http://" + Request.Url.Host;
            //获取服务器IP
            this.serverIP.Text = Request.ServerVariables.Get("Local_Addr").ToString();
            //获取服务器操作系统版本
            this.serverSystem.Text = GetUserOS();
            //获取管理系统当前目录
            this.serverPath.Text = Request.PhysicalApplicationPath;
            //获取服务器当前时间
            this.serverDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //检测IE版本
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Version Vector");
            this.serverIE.Text = key.GetValue("IE", "未检测到").ToString();
            //检测访问端口
            this.serverPort.Text = Request.ServerVariables.Get("Server_Port").ToString();
        }
        public string GetUserOS()
        {

            string strSysVersion = "其他";

            HttpRequest Request = HttpContext.Current.Request;

            string strAgentInfo = Request.ServerVariables["HTTP_USER_AGENT"];

            if (strAgentInfo.Contains("NT 10"))
            {
                strSysVersion = "Windows10";
            }
            else if (strAgentInfo.Contains("NT 6.3"))
            {
                strSysVersion = "Windows8.1";
            }
            else if (strAgentInfo.Contains("NT 6.2"))
            {
                strSysVersion = "Windows8";
            }
            else if (strAgentInfo.Contains("NT 6.1"))
            {
                strSysVersion = "Windows7";
            }
            else if (strAgentInfo.Contains("NT 6.0"))
            {
                strSysVersion = "Windows Vista";
            }
            else if (strAgentInfo.Contains("NT 5.2"))
            {
                strSysVersion = "Windows 2003";
            }
            else if (strAgentInfo.Contains("NT 5.1"))
            {
                strSysVersion = "Windows XP";
            }
            else if (strAgentInfo.Contains("NT 5"))
            {
                strSysVersion = "Windows 2000";
            }
            else if (strAgentInfo.Contains("NT 4.9"))
            {
                strSysVersion = "Windows ME";
            }
            else if (strAgentInfo.Contains("NT 4"))
            {
                strSysVersion = "Windows NT4";
            }
            else if (strAgentInfo.Contains("NT 98"))
            {
                strSysVersion = "Windows 98";
            }
            else if (strAgentInfo.Contains("NT 95"))
            {
                strSysVersion = "Windows 95";
            }
            else if (strSysVersion.ToLower().Contains("Mac"))
            {
                strSysVersion = "Mac";
            }
            else if (strSysVersion.ToLower().Contains("unix"))
            {
                strSysVersion = "UNIX";
            }
            else if (strSysVersion.ToLower().Contains("linux"))
            {
                strSysVersion = "Linux";
            }
            else if (strSysVersion.Contains("SunOS"))
            {
                strSysVersion = "SunOS";
            }
            return strSysVersion;
        }
        private void bindDate()
        {
            string dateString = "";
            int hour = int.Parse(DateTime.Now.ToString("HH"));
            if (hour >= 9 & hour <= 10)
            {
                dateString = "上午";
            }
            else if (hour >= 5 & hour <= 8)
            {
                dateString = "早晨";
            }
            else if (hour >= 11 & hour <= 13)
            {
                dateString = "中午";
            }
            else if (hour >= 13 & hour <= 17)
            {
                dateString = "下午";
            }
            else if (hour >= 18 & hour <= 23)
            {
                dateString = "晚上";
            }
            else if (hour >= 0 & hour <= 4)
            {
                dateString = "凌晨";
            }

            HttpCookie cookie = Request.Cookies["trueName"];
            if (null == cookie)
            {
                Response.Write("<script language=javascript>window.parent.location='../Login.aspx';</script>");//
            }
            else
            {
                litLogInfo.Text = dateString + "好，<span style='color:red'>" + Maticsoft.Common.DEncrypt.DESEncrypt.Decrypt(cookie.Value) + "</span>，欢迎登陆系统！";
                litShowInfo.Text = "您上次登录系统的时间为" + Maticsoft.Common.DEncrypt.DESEncrypt.Decrypt(Request.Cookies["lastLoginTime"].Value) + ".";
            }
        }
    }
}