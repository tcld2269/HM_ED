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
    public partial class Modify : Page
    {       

        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
                    BLL.ad_pos apBll = new BLL.ad_pos();
                    ddlAp.DataValueField = "id";
                    ddlAp.DataTextField = "title";
                    ddlAp.DataSource = apBll.GetAllList();
                    ddlAp.DataBind();

					int siId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(siId);
				}
			}
		}
			
	private void ShowInfo(int siId)
	{
        hm.BLL.ad bll = new hm.BLL.ad();
        hm.Model.ad model = bll.GetModel(siId);
		lblId.Text=model.id.ToString();
        txtTitle.Text = model.title;
        ddlAp.SelectedValue = model.apId.Value.ToString();
        txtUrl.Text = model.url;
        txtStartDate.Text = model.startDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        txtEndDate.Text = model.endDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
        if (!string.IsNullOrEmpty(model.pic))
        {
            imgPic.ImageUrl = model.pic;
        }
        txtRemark.Text = model.remark;
        txtOrders.Text = model.orders.ToString();
        bindPos();
	}

		public void btnSave_Click(object sender, EventArgs e)
		{

            string strErr = "";
            if (this.txtTitle.Text.Trim().Length == 0)
            {
                strErr += "广告名称不能为空！\\n";
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
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string title = txtTitle.Text;
            string url = txtUrl.Text;
            DateTime startDate = DateTime.Parse(txtStartDate.Text);
            DateTime endDate = DateTime.Parse(txtEndDate.Text);
            int orders = int.Parse(txtOrders.Text);
            string pic = imgPic.ImageUrl;
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

            hm.BLL.ad bll = new hm.BLL.ad();
            Model.ad model = bll.GetModel(int.Parse(lblId.Text));
            model.apId = int.Parse(ddlAp.SelectedValue);
            model.title = title;
            model.url = txtUrl.Text;
            model.pic = pic;
            model.startDate = startDate;
            model.endDate = endDate;
            model.remark = remark;
            model.orders = orders;

			bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

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
                imgPic.Visible = true;
            }
            else if (model.types.Value == 1)
            {
                flPic.Visible = false;
                txtRemark.Visible = true;
                lblTypeName.Text = "文字";
                imgPic.Visible = false;
            }
        }
    }
}
