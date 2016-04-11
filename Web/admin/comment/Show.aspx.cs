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
namespace hm.Web.comment
{
    public partial class Show : Page
    {       

        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(int roleId)
	{
        hm.BLL.comment bll = new hm.BLL.comment();
        hm.Model.comment model = bll.GetModel(roleId);
		this.lblroleId.Text=model.ID.ToString();
        lblTitle.Text = model.title;
        lblTrueName.Text = model.trueName;
        lblType.Text = ClassHelper.Comment_Type_Arr[model.nodeType.Value];
        lblTel.Text = model.tel;
        lblEmail.Text = model.email;
        lblRemark.Text = model.remark;
        lblAddTime.Text = model.addTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
        if(model.nodeType.Value==1)
        {
            lblNodeName.Text = new BLL.news().GetModel(model.nodeId.Value).newsTitle;
        }
        else if (model.nodeType.Value == 2)
        {
            lblNodeName.Text = new BLL.ed_page().GetModel(model.nodeId.Value).title;
        }
        else if (model.nodeType.Value == 3)
        {
            lblNodeName.Text = new BLL.ed_product().GetModel(model.nodeId.Value).title;
        }
        else if (model.nodeType.Value == 4)
        {
            lblNodeName.Text = new BLL.ed_media().GetModel(model.nodeId.Value).title;
        }

	}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
