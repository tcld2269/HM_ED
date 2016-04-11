﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Maticsoft.Common;
using System.Drawing;
using LTP.Accounts.Bus;
namespace hm.Web.comment
{
	public partial class List : Page
	{



        hm.BLL.comment bll = new hm.BLL.comment();

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
			#region
			//if (!Context.User.Identity.IsAuthenticated)
			//{
			//    return;
			//}
			//AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
			//if (user.HasPermissionID(PermId_Modify))
			//{
			//    gridView.Columns[6].Visible = true;
			//}
			//if (user.HasPermissionID(PermId_Delete))
			//{
			//    gridView.Columns[7].Visible = true;
			//}
			#endregion

			DataSet ds = new DataSet();
			StringBuilder strWhere = new StringBuilder();
			strWhere.Append(" 1=1  ");
            if (ddlType.SelectedValue != "-1")
            {
                strWhere.Append(" and nodeType=" + ddlType.SelectedValue + " ");
            }
			if (txtKeyword.Text.Trim() != "")
			{
                strWhere.AppendFormat(" and (trueName like '%{0}%' or title like '%{0}%') ", txtKeyword.Text.Trim());
			}
			ds = bll.GetList(strWhere.ToString());
            Common.CommonHelper.AddDtColumns(ds.Tables[0], "nodeType", ClassHelper.Comment_Type_Arr);
			gridView.DataSource = ds;
			gridView.DataBind();
		}

		protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			gridView.PageIndex = e.NewPageIndex;
			BindData();
		}
		protected void gridView_OnRowCreated(object sender, GridViewRowEventArgs e)
		{
			if (e.Row.RowType == DataControlRowType.Header)
			{
				//e.Row.Cells[0].Text = "<input id='Checkbox2' type='checkbox' onclick='CheckAll()'/><label></label>";
			}
		}
		protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
		{
			//e.Row.Attributes.Add("style", "background:#FFF");
			if (e.Row.RowType == DataControlRowType.DataRow)
			{
				LinkButton linkbtnDel = (LinkButton)e.Row.FindControl("LinkButton1");
				linkbtnDel.Attributes.Add("onclick", "return confirm(\"你确认要删除吗\")");
				
				//object obj1 = DataBinder.Eval(e.Row.DataItem, "Levels");
				//if ((obj1 != null) && ((obj1.ToString() != "")))
				//{
				//    e.Row.Cells[1].Text = obj1.ToString();
				//}
			   
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
