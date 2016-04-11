using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace hm.Web.Controls
{
    public partial class webset : AdminPage
    {
        BLL.web_site bll = new BLL.web_site();
        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
                Model.web_site model = bll.GetModelList("")[0];
                txtWebName.Text = model.webName;
                txtWebTitle.Text = model.title;
                txtKeywords.Text = model.keywords;
                txtDes.Text = model.description;
                txtBottom.Text = model.bottom;
                txtQQ.Text = model.qq;
                image1.ImageUrl = model.logo;
			}
		}
			
	

		public void btnSave_Click(object sender, EventArgs e)
		{
            hm.BLL.users bllUser = new hm.BLL.users();
            HttpCookie cookie = Request.Cookies["userId"];
            if (null == cookie)
            {
                Response.Write("<script language=javascript>window.parent.location='../Login.aspx';</script>");//
            }
            else
            {
                Model.web_site model = bll.GetModelList("")[0];
                model.webName = txtWebName.Text;
                model.title = txtWebTitle.Text;
                model.keywords = txtKeywords.Text;
                model.description = txtDes.Text;
                model.bottom = txtBottom.Text;
                model.qq = txtQQ.Text;
                model.logo = image1.ImageUrl;
                if (flLogo.HasFile)
                {
                    string msg = Common.CommonHelper.Imageupload(flLogo, "logo");
                    if (msg.IndexOf('|') < 0)
                    {
                        MessageBox.Show(this,msg);
                        return;
                    }
                    if (msg.Split('|')[0].Equals("1"))
                    {
                        model.logo = msg.Split('|')[1];
                    }
                }
                bll.Update(model);
                MessageBox.Show(this, "保存成功！");
            }

		}

    }
}
