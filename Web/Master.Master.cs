using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace hm.Web
{
    public partial class Master : System.Web.UI.MasterPage
    {
        public string title, keywords, des, logo;
        BLL.ed_node nBll = new BLL.ed_node();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptNodelist.DataSource = nBll.GetList("parentId=0 and isShow=1 order by orders desc");
                rptNodelist.DataBind();

                BLL.web_site wsBll = new BLL.web_site();
                Model.web_site model = wsBll.GetModelList("")[0];
                title = model.title;
                keywords = "\"" + model.keywords + "\"";
                des = "\"" + model.description + "\"";
                litBottom.Text = model.bottom;
                logo = "<img alt=\""+model.webName+"\" src=\""+model.logo+"\" style=\"float: left;\" />";
            }
        }
        protected void rptNodelist_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            bool flag = false;
            DataRowView rowv = (DataRowView)e.Item.DataItem;//找到分类Repeater关联的数据项 
            int id = Convert.ToInt32(rowv["id"]); //获取填充子类的id 
            DataTable dt = nBll.GetList("parentId=" + id + " and isShow=1 order by orders desc").Tables[0];
            if (dt.Rows.Count != 0)
            {
                flag = true;
            }

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater rep = e.Item.FindControl("rptChildNodelist") as Repeater;//找到里层的repeater对象
                rep.DataSource = dt;
                rep.DataBind();
                
            }

            Literal litStart = e.Item.FindControl("litStart") as Literal;
            if (flag)
            {
                litStart.Text = "<div class=\"dropdown columns-1\" style=\"width:180px;\"><div class=\"column col1\"  style=\"width:180px;\"><ul class=\"l2\">";
            }
            else
            {
                litStart.Text = "";
            }
            Literal litEnd = e.Item.FindControl("litEnd") as Literal;
            if (flag)
            {
                litEnd.Text = "</ul></div>";
            }
            else
            {
                litEnd.Text = "";
            }

        }
        protected void rptChildNodelist_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            bool flag = false;
            DataRowView rowv = (DataRowView)e.Item.DataItem;//找到分类Repeater关联的数据项 
            int id = Convert.ToInt32(rowv["id"]); //获取填充子类的id 
            DataTable dt = nBll.GetList("parentId=" + id + " and isShow=1  order by orders desc").Tables[0];
            if (dt.Rows.Count != 0)
            {
                flag = true;
            }

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Repeater rep = e.Item.FindControl("rptChildNodelist2") as Repeater;//找到里层的repeater对象
                rep.DataSource = dt;
                rep.DataBind();
                
            }

            Literal litStart2 = e.Item.FindControl("litStart2") as Literal;
            if (flag)
            {
                litStart2.Text = "<div class=\"dropdown flyout columns-2\"><div class=\"column col1\"  style=\"width:225px;\"><ul class=\"l3\">";
            }
            else
            {
                litStart2.Text = "";
            }
            Literal litEnd2 = e.Item.FindControl("litEnd2") as Literal;
            if (flag)
            {
                litEnd2.Text = "</ul></div></div>";
            }
            else
            {
                litEnd2.Text = "";
            }

        }
        

        public static string getNodeUrl(string nodeId)
        {
            BLL.ed_node nBll = new BLL.ed_node();
            string result = "";
            Model.ed_node model = nBll.GetModel(int.Parse(nodeId));
            if (model.url == "0")
            {
                result = "javascript:void(0)";
            }
            else
            {
                if (!string.IsNullOrEmpty(model.url))
                {
                    result = model.url;
                }
                else
                {
                    if (model.types.ToString() == StatusHelper.Node_Type_Page)
                    {
                        result = "/node.aspx?id=" + model.ID;
                    }
                    else if (model.types.ToString() == StatusHelper.Node_Type_News)
                    {
                        result = "/newsList.aspx?id=" + model.ID;
                    }
                    else if (model.types.ToString() == StatusHelper.Node_Type_Product)
                    {
                        result = "/productList.aspx?id=" + model.ID;
                    }
                    else if (model.types.ToString() == StatusHelper.Node_Type_Media)
                    {
                        result = "/mediaList.aspx?id=" + model.ID;
                    }
                    else
                    {
                        result = "/error.aspx";
                    }
                }
            }
            
            return result;
        }
    }
}