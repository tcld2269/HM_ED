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
    public partial class ApAdd : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                for (int i = 0; i < ClassHelper.Ad_Type_Arr.Length;i++ )
                {
                    ddlTypes.Items.Add(new ListItem(ClassHelper.Ad_Type_Arr[i], i.ToString()));
                }
            }
		}

		protected void btnSave_Click(object sender, EventArgs e)
		{
			string strErr="";
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="广告位名称不能为空！\\n";	
			}
            if (!PageValidate.IsNumber(txtWidth.Text))
            {
                strErr += "宽度必须为数字！\\n";
            }
            if (!PageValidate.IsNumber(txtHeight.Text))
            {
                strErr += "高度必须为数字！\\n";
            }
			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}

            hm.Model.ad_pos model = new hm.Model.ad_pos();
            model.title = this.txtTitle.Text;
            model.types = int.Parse(ddlTypes.SelectedValue);
            model.width = int.Parse(txtWidth.Text);
            model.height = int.Parse(txtHeight.Text);
            model.click = 0;

            hm.BLL.ad_pos bll = new hm.BLL.ad_pos();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

		}


		public void btnCancle_Click(object sender, EventArgs e)
		{
			Response.Redirect("list.aspx");
		}

	}
}
