using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Maticsoft.Common;
using System.Drawing;
using LTP.Accounts.Bus;
namespace hm.Web.ad
{
    public partial class ApList : Page
	{
        hm.BLL.ad_pos bll = new hm.BLL.ad_pos();

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				BindData();
			}
		}
		
		protected void btnSearch_Click(object sender, EventArgs e)
		{
			BindData();
		}
		
		#region gridView
						
		public void BindData()
		{
			DataSet ds = new DataSet();
			StringBuilder strWhere = new StringBuilder();
			strWhere.Append(" 1=1  ");
			if (txtKeyword.Text.Trim() != "")
			{
                strWhere.AppendFormat(" and title like '%{0}%' ", txtKeyword.Text.Trim());
			}
			ds = bll.GetList(strWhere.ToString());
            Common.CommonHelper.AddDtColumns(ds.Tables[0], "types", ClassHelper.Ad_Type_Arr);
			gridView.DataSource = ds;
			gridView.DataBind();
		}

		protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			gridView.PageIndex = e.NewPageIndex;
			BindData();
		}
		
		protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
		{
			//e.Row.Attributes.Add("style", "background:#FFF");
			if (e.Row.RowType == DataControlRowType.DataRow)
			{
				LinkButton linkbtnDel = (LinkButton)e.Row.FindControl("LinkButton1");
				linkbtnDel.Attributes.Add("onclick", "return confirm(\"你确认要删除吗\")");
			}
		}
		
		protected void gridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
		{
			int ID = Convert.ToInt32(gridView.DataKeys[e.RowIndex].Value);
			bll.Delete(ID);
			BindData();
		}

		#endregion





	}
}
