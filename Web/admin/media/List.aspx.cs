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
namespace hm.Web.media
{
    public partial class List : WebPage
    {
        hm.BLL.news newsBll = new hm.BLL.news();
        hm.BLL.ed_page pageBll = new hm.BLL.ed_page();
        hm.BLL.ed_product proBll = new hm.BLL.ed_product();
        hm.BLL.ed_media medBll = new hm.BLL.ed_media();

        hm.BLL.ed_node nBll = new hm.BLL.ed_node();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                btnDelete.Attributes.Add("onclick", "return confirm(\"你确认要删除吗？\")");

                bindDropDownNode(ddrNode);

                if (Request.QueryString["id"] != null)
                {
                    ddrNode.SelectedValue = Request.QueryString["id"].ToString();
                }

                BindData();

                
            }
        }
        
        
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string idlist = GetSelIDlist();
            if (idlist.Trim().Length == 0) 
                return;

            if (gridView1.Visible == true)
            { newsBll.DeleteList(idlist); }
            else if (gridView2.Visible == true)
            { pageBll.DeleteList(idlist); }
            else if (gridView3.Visible == true)
            { proBll.DeleteList(idlist); }
            else if (gridView4.Visible == true)
            { medBll.DeleteList(idlist); }

            BindData();
        }
        
        #region gridView
                        
        public void BindData()
        {
            gridView1.Visible = false;
            gridView2.Visible = false;
            gridView3.Visible = false;
            gridView4.Visible = false;
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            
            
            Model.ed_node model = nBll.GetModel(int.Parse(ddrNode.SelectedValue));
            if (model.types.Value == 1)
            { 
                //新闻
                gridView1.Visible = true;
                strWhere.Append(" status=1");
                ds = newsBll.GetList(strWhere.ToString() + " order by addTime desc");
                gridView1.DataSource = ds;
                gridView1.DataBind();
            }
            else if (model.types.Value == 2)
            {
                //单页
                gridView2.Visible = true;
                strWhere.Append(" nodeId=" + ddrNode.SelectedValue);
                ds = pageBll.GetList(strWhere.ToString() + " order by ID desc");
                gridView2.DataSource = ds;
                gridView2.DataBind();
            }
            else if (model.types.Value == 3)
            {
                //产品
                gridView3.Visible = true;
                strWhere.Append(" nodeId=" + ddrNode.SelectedValue);
                ds = proBll.GetList(strWhere.ToString() + " order by ID desc");
                gridView3.DataSource = ds;
                gridView3.DataBind();
            }
            else if (model.types.Value == 4)
            {
                //综合
                gridView4.Visible = true;
                strWhere.Append(" nodeId=" + ddrNode.SelectedValue);
                ds = medBll.GetList(strWhere.ToString() + " order by ID desc");
                gridView4.DataSource = ds;
                gridView4.DataBind();
            }
            
            
            
        }

        protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            if (gridView1.Visible == true)
            { gridView1.PageIndex = e.NewPageIndex; }
            else if (gridView2.Visible == true)
            { gridView2.PageIndex = e.NewPageIndex; }
            else if (gridView3.Visible == true)
            { gridView3.PageIndex = e.NewPageIndex; }
            else if (gridView4.Visible == true)
            { gridView4.PageIndex = e.NewPageIndex; }
            
            BindData();
        }

        private string GetSelIDlist()
        {
            string idlist = "";
            bool BxsChkd = false;

            if (gridView1.Visible == true)
            {
                for (int i = 0; i < gridView1.Rows.Count; i++)
                {
                    CheckBox ChkBxItem = (CheckBox)gridView1.Rows[i].FindControl("DeleteThis");
                    if (ChkBxItem != null && ChkBxItem.Checked)
                    {
                        BxsChkd = true;
                        if (gridView1.DataKeys[i].Value != null)
                        {
                            idlist += gridView1.DataKeys[i].Value.ToString() + ",";
                        }
                    }
                }
            }
            else if (gridView2.Visible == true)
            {
                for (int i = 0; i < gridView2.Rows.Count; i++)
                {
                    CheckBox ChkBxItem = (CheckBox)gridView2.Rows[i].FindControl("DeleteThis");
                    if (ChkBxItem != null && ChkBxItem.Checked)
                    {
                        BxsChkd = true;
                        if (gridView2.DataKeys[i].Value != null)
                        {
                            idlist += gridView2.DataKeys[i].Value.ToString() + ",";
                        }
                    }
                }
            }
            else if (gridView3.Visible == true)
            {
                for (int i = 0; i < gridView3.Rows.Count; i++)
                {
                    CheckBox ChkBxItem = (CheckBox)gridView3.Rows[i].FindControl("DeleteThis");
                    if (ChkBxItem != null && ChkBxItem.Checked)
                    {
                        BxsChkd = true;
                        if (gridView3.DataKeys[i].Value != null)
                        {
                            idlist += gridView3.DataKeys[i].Value.ToString() + ",";
                        }
                    }
                }
            }
            else if (gridView4.Visible == true)
            {
                for (int i = 0; i < gridView4.Rows.Count; i++)
                {
                    CheckBox ChkBxItem = (CheckBox)gridView4.Rows[i].FindControl("DeleteThis");
                    if (ChkBxItem != null && ChkBxItem.Checked)
                    {
                        BxsChkd = true;
                        if (gridView4.DataKeys[i].Value != null)
                        {
                            idlist += gridView4.DataKeys[i].Value.ToString() + ",";
                        }
                    }
                }
            }

            
            if (BxsChkd)
            {
                idlist = idlist.Substring(0, idlist.LastIndexOf(","));
            }
            return idlist;
        }

        #endregion

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (gridView1.Visible == true)
            { Response.Redirect("../news/Add.aspx?id=" + ddrNode.SelectedValue); }
            else if (gridView2.Visible == true)
            { Response.Redirect("../page/Add.aspx?id=" + ddrNode.SelectedValue); }
            else if (gridView3.Visible == true)
            { Response.Redirect("../products/Add.aspx?id=" + ddrNode.SelectedValue); }
            else if (gridView4.Visible == true)
            { Response.Redirect("../media/Add.aspx?id=" + ddrNode.SelectedValue); }
            
        }

        protected void ddrNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindData();
        }
        


    }
}
