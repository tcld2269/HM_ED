using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace hm.Web
{
    public class WebPage : Page
    {
        public WebPage()
        {

        }

        public static void bindDropDownNode(DropDownList ddlNode)
        {
            hm.BLL.ed_node nBll = new hm.BLL.ed_node();
            ddlNode.Items.Clear();
            DataTable dt = nBll.GetList("parentId=0 order by orders desc").Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListItem li = new ListItem(dt.Rows[i]["title"].ToString(), dt.Rows[i]["id"].ToString());
                //li.Attributes.Add("disabled", "true");
                ddlNode.Items.Add(li);
                DataTable dt2 = nBll.GetList("parentId=" + dt.Rows[i]["id"].ToString() + " order by orders desc").Tables[0];
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    ddlNode.Items.Add(new ListItem("┣" + dt2.Rows[j]["title"].ToString(), dt2.Rows[j]["id"].ToString()));
                    DataTable dt3 = nBll.GetList("parentId=" + dt2.Rows[j]["id"].ToString() + " order by orders desc").Tables[0];
                    for (int k = 0; k < dt3.Rows.Count; k++)
                    {
                        ddlNode.Items.Add(new ListItem("┣╍" + dt3.Rows[k]["title"].ToString(), dt3.Rows[k]["id"].ToString()));
                    }
                }
            }
        }

        public static void bindDropDownNode(DropDownList ddlNode, string type)
        {
            hm.BLL.ed_node nBll = new hm.BLL.ed_node();
            ddlNode.Items.Clear();
            DataTable dt = nBll.GetList("parentId=0 and types=" + type + " order by orders desc").Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListItem li = new ListItem(dt.Rows[i]["title"].ToString(), dt.Rows[i]["id"].ToString());
                //li.Attributes.Add("disabled", "true");
                ddlNode.Items.Add(li);
                DataTable dt2 = nBll.GetList("parentId=" + dt.Rows[i]["id"].ToString() + " and types=" + type + " order by orders desc").Tables[0];
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    ddlNode.Items.Add(new ListItem("┣" + dt2.Rows[j]["title"].ToString(), dt2.Rows[j]["id"].ToString()));
                    DataTable dt3 = nBll.GetList("parentId=" + dt2.Rows[j]["id"].ToString() + " order by orders desc").Tables[0];
                    for (int k = 0; k < dt3.Rows.Count; k++)
                    {
                        ddlNode.Items.Add(new ListItem("┣╍" + dt3.Rows[k]["title"].ToString(), dt3.Rows[k]["id"].ToString()));
                    }
                }
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