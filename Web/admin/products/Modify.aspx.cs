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
namespace hm.Web.products
{
    public partial class Modify : WebPage
    {
        BLL.ed_node nBll = new BLL.ed_node();
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
			
	private void ShowInfo(int siId)
	{
        hm.BLL.ed_product bll = new hm.BLL.ed_product();
        hm.Model.ed_product model = bll.GetModel(siId);
        this.lblId.Text = model.ID.ToString();
        txtTitle.Text = model.title;
        this.txtRemark.Text = model.remark;
        imagePic.ImageUrl = model.picSmall;
        litPicSmall.Text = model.picSmall;
        litPicBig.Text = model.picBig;
        if (model.isRecommend.Value == 1)
        {
            cbRecommend.Checked = true;
        }

        Model.ed_node modelNode = nBll.GetModel(model.nodeId.Value);
        litId.Text = modelNode.ID.ToString();
        litName.Text = modelNode.title;
	}

		public void btnSave_Click(object sender, EventArgs e)
		{

            hm.BLL.ed_product bll = new hm.BLL.ed_product();
            string strErr = "";
            if (this.txtTitle.Text.Trim().Length == 0)
            {
                strErr += "标题不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }

            int Id = int.Parse(lblId.Text);
            int nodeId = int.Parse(litId.Text);
            string title = txtTitle.Text;
            string remark = this.txtRemark.Text;
            string spic = litPicSmall.Text, bpic = litPicBig.Text;
            int recommend = 0;

            if (flPic.HasFile)
            {
                string msg = Common.CommonHelper.Imageupload(flPic, "product");
                if (msg.Split('|')[0].Equals("1"))
                {
                    bpic = msg.Split('|')[1];
                    spic = msg.Split('|')[2];
                }
            }
            if (cbRecommend.Checked)
            {
                recommend = 1;
            }

            hm.Model.ed_product model = bll.GetModel(Id);
            model.nodeId = nodeId;
            model.title = title;
            model.remark = remark;
            model.picBig = bpic;
            model.picSmall = spic;
            model.isRecommend = recommend;
            model.addTime = model.addTime;
            model.status = model.status;
			
			bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "../media/list.aspx?id=" + model.nodeId);

		}


    }
}
