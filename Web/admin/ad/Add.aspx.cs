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
namespace hm.Web.ad
{
	public partial class Add : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                BLL.ad_pos apBll = new BLL.ad_pos();
                ddlAp.DataValueField = "id";
                ddlAp.DataTextField = "title";
                ddlAp.DataSource = apBll.GetAllList();
                ddlAp.DataBind();

                if (Request.QueryString["type"] != null)
                {
                    ddlAp.SelectedValue = Request.QueryString["type"].ToString(); 
                }
                bindPos();
            }
		}

		protected void btnSave_Click(object sender, EventArgs e)
		{
			string strErr="";
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="广告名称不能为空！\\n";	
			}
            if (!PageValidate.IsDateTime(txtStartDate.Text))
            {
                strErr += "时间格式不正确！\\n";
            }
            if (!PageValidate.IsDateTime(txtEndDate.Text))
            {
                strErr += "时间格式不正确！\\n";
            }
            if (!PageValidate.IsNumber(txtOrders.Text))
            {
                strErr += "排序必须为数字！\\n";
            }
			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
            string title = txtTitle.Text;
            string url = txtUrl.Text;
            DateTime startDate = DateTime.Parse(txtStartDate.Text);
            DateTime endDate = DateTime.Parse(txtEndDate.Text);
            int orders = int.Parse(txtOrders.Text);
            string pic = "";
            string remark = txtRemark.Text;

            if (flPic.HasFile)
            {
                string result = Common.CommonHelper.Imageupload(flPic, "ad");
                if (result.IndexOf('|') > 0)
                {
                    pic = result.Split('|')[2];
                }
                else
                {
                    MessageBox.Show(this, result);
                    return;
                }
            }

            hm.Model.ad model = new hm.Model.ad();
            model.apId = int.Parse(ddlAp.SelectedValue);
            model.title = title;
            model.url = txtUrl.Text;
            model.pic = pic;
            model.startDate = startDate;
            model.endDate = endDate;
            model.remark = remark;
            model.orders = orders;
            model.addTime = DateTime.Now;
            model.status = 1;

            hm.BLL.ad bll = new hm.BLL.ad();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

		}


		public void btnCancle_Click(object sender, EventArgs e)
		{
			Response.Redirect("list.aspx");
		}

        protected void ddlAp_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindPos();
        }

        private void bindPos()
        {
            BLL.ad_pos apBll = new BLL.ad_pos();
            Model.ad_pos model = apBll.GetModel(int.Parse(ddlAp.SelectedValue));
            lblInfo.Text = "【" + ClassHelper.Ad_Type_Arr[model.types.Value] + "】 【宽：" + model.width + " 像素】【高：" + model.height + " 像素】";
            if (model.types.Value == 0)
            {
                flPic.Visible = true;
                txtRemark.Visible = false;
                lblTypeName.Text = "图片";
            }
            else if (model.types.Value == 1)
            {
                flPic.Visible = false;
                txtRemark.Visible = true;
                lblTypeName.Text = "文字";
            }
        }
	}
}
