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
    public partial class ApModify : Page
    {       

        protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
                    for (int i = 0; i < ClassHelper.Ad_Type_Arr.Length; i++)
                    {
                        ddlTypes.Items.Add(new ListItem(ClassHelper.Ad_Type_Arr[i], i.ToString()));
                    }

					int siId=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(siId);
				}
			}
		}
			
	private void ShowInfo(int siId)
	{
        hm.BLL.ad_pos bll = new hm.BLL.ad_pos();
        hm.Model.ad_pos model = bll.GetModel(siId);
		lblId.Text=model.id.ToString();
        txtTitle.Text = model.title;
        txtWidth.Text = model.width.ToString();
        txtHeight.Text = model.height.ToString();
        ddlTypes.SelectedValue = model.types.ToString();
	}

		public void btnSave_Click(object sender, EventArgs e)
		{

            string strErr = "";
            if (this.txtTitle.Text.Trim().Length == 0)
            {
                strErr += "广告位名称不能为空！\\n";
            }
            if (!PageValidate.IsNumber(txtWidth.Text))
            {
                strErr += "宽度必须为数字！\\n";
            }
            if (!PageValidate.IsNumber(txtHeight.Text))
            {
                strErr += "高度必须为数字！\\n";
            }
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }

            hm.BLL.ad_pos bll = new hm.BLL.ad_pos();
            hm.Model.ad_pos model = bll.GetModel(int.Parse(lblId.Text));
            model.title = this.txtTitle.Text;
            model.types = int.Parse(ddlTypes.SelectedValue);
            model.width = int.Parse(txtWidth.Text);
            model.height = int.Parse(txtHeight.Text);

			bll.Update(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "Aplist.aspx");

		}

    }
}
