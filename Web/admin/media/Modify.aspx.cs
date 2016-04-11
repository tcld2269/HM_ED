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
namespace hm.Web.media
{
    public partial class Modify : WebPage
    {
        BLL.ed_node nBll = new BLL.ed_node();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    int Id = (Convert.ToInt32(Request.Params["id"]));
                    ShowInfo(Id);
                }
            }
        }

        private void ShowInfo(int siId)
        {
            hm.BLL.ed_media bll = new hm.BLL.ed_media();
            hm.Model.ed_media model = bll.GetModel(siId);
            this.lblId.Text = model.ID.ToString();
            txtTitle.Text = model.title;
            image1.ImageUrl = model.picSmall;
            lblPicBig.Text = model.picBig;
            txtRemark.Text = model.remark;
            lblFile.Text = model.mediaUrl;
            if (model.isRecommend.Value == 1)
            {
                cbRecommend.Checked = true;
            }

            Model.ed_node modelNode = nBll.GetModel(model.nodeId.Value);
            litId.Text = modelNode.ID.ToString();
            litName.Text = modelNode.title;

        }

        protected void btnSave_Click(object sender, EventArgs e)
		{
            hm.BLL.ed_media bll = new hm.BLL.ed_media();
			string strErr="";
            if (this.txtTitle.Text.Trim().Length == 0)
            {
                strErr += "标题不能为空！\\n";
            }


			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}

            int nodeId = int.Parse(litId.Text);
            int mediaTypeId = 1;
            string title = txtTitle.Text;
            string remark = this.txtRemark.Text;
            string spic = image1.ImageUrl, bpic = lblPicBig.Text, url = lblFile.Text;
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
            if (flUrl.HasFile)
            {
                string[] allowExtension = { ".jpg", ".png", ".gif", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".txt", ".rar", ".zip", ".7z", ".flv" };
                string msg = Common.CommonHelper.Fileupload(flPic, "fujian", allowExtension,10);
                if (msg.Split('|')[0].Equals("1"))
                {
                    url = msg.Split('|')[1];
                }
            }
            if (cbRecommend.Checked)
            {
                recommend = 1;
            }

            hm.Model.ed_media model = bll.GetModel(int.Parse(lblId.Text));
            model.nodeId = nodeId;
            model.mediaType = mediaTypeId;
            model.title = title;
            model.remark = remark;
            model.picBig = bpic;
            model.picSmall = spic;
            model.mediaUrl = url;
            model.isRecommend = recommend;
            model.addTime = DateTime.Now;
            model.status = StatusHelper.Product_Status_Normal;
            
			bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "../media/list.aspx?id=" + model.nodeId);

		}


    }
}
