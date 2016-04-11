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
namespace hm.Web.page
{
    public partial class Add : WebPage
    {
        BLL.ed_node nBll = new BLL.ed_node();
        hm.BLL.ed_page bll = new hm.BLL.ed_page();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    litId.Text = Request.QueryString["id"].ToString();

                    if (bll.GetList("nodeId=" + litId.Text).Tables[0].Rows.Count > 0)
                    {
                        MessageBox.ShowAndRedirect(this, "已添加过该栏目的单页！", "../media/list.aspx?id=" + litId.Text);
                        return;
                    }

                    Model.ed_node model = nBll.GetModel(int.Parse(litId.Text));
                    litName.Text = model.title;
                }
                else
                {
                    MessageBox.ShowAndRedirect(this, "参数丢失！", "../media/list.aspx?id=" + litId.Text);
                    return;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
		{
            
			string strErr="";
            if (this.txtRemark.Text.Trim().Length == 0)
            {
                strErr += "内容不能为空！\\n";
            }
            if (bll.GetList("nodeId=" + litId.Text).Tables[0].Rows.Count > 0)
            {
                strErr += "已添加过该栏目的单页！\\n";
            }

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}

            int nodeId = int.Parse(litId.Text);
            string title = litName.Text;
            string remark = this.txtRemark.Text;

            hm.Model.ed_page model = new hm.Model.ed_page();
            model.nodeId = nodeId;
            model.title = title;
            model.remark = remark;
            model.pic = "";

            
			bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "../media/list.aspx?id=" + model.nodeId);

		}


    }
}
