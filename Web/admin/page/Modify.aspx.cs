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
    public partial class Modify : WebPage
    {
        hm.BLL.ed_page bll = new hm.BLL.ed_page();
        BLL.ed_node nBll = new BLL.ed_node();
        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
                if (Request.QueryString["id"] != null)
                {
                    ShowInfo(int.Parse(Request.QueryString["id"].ToString()));
                }
                else
                {
                    MessageBox.ShowAndRedirect(this, "参数丢失！", "../media/list.aspx?id=" + litId.Text);
                    return;
                }
			}
		}
			
	private void ShowInfo(int siId)
	{
        
        hm.Model.ed_page model = bll.GetModel(siId);
        this.lblId.Text = model.ID.ToString();
        this.txtRemark.Text = model.remark;

        Model.ed_node modelNode = nBll.GetModel(model.nodeId.Value);
        litId.Text = modelNode.ID.ToString();
        litName.Text = modelNode.title;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{

            hm.BLL.ed_page bll = new hm.BLL.ed_page();
            string strErr = "";
            if (this.txtRemark.Text.Trim().Length == 0)
            {
                strErr += "内容不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }

            int Id = int.Parse(lblId.Text);
            int nodeId = int.Parse(litId.Text);
            string title = litName.Text;
            string remark = this.txtRemark.Text;

            hm.Model.ed_page model = bll.GetModel(Id);
            model.nodeId = nodeId;
            model.title = title;
            model.remark = remark;
            model.pic = "";
			
			bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "../media/list.aspx?id=" + model.nodeId);

		}


    }
}
