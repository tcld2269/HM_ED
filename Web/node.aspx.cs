using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace hm.Web
{
    public partial class node : WebPage
    {
        BLL.ed_node nBll = new BLL.ed_node();
        BLL.ed_page pBll = new BLL.ed_page();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    //Model.ed_node model = nBll.GetModel(int.Parse(Request.QueryString["id"].ToString()));
                    //DataTable dt = new DataTable();
                    //if (model.parentId.Value == 0)
                    //{
                    //    dt = nBll.GetList("parentId=" + Request.QueryString["id"].ToString() + " order by orders asc").Tables[0];
                    //    rptNode.DataSource = dt;
                    //    rptNode.DataBind();
                    //}
                    //else
                    //{
                    //    dt = nBll.GetList("parentId=" + model.parentId + " order by orders asc").Tables[0];
                    //    rptNode.DataSource = dt;
                    //    rptNode.DataBind();
                    //}

                    DataTable dt2 = pBll.GetList("nodeId=" + Request.QueryString["id"].ToString()).Tables[0];
                    if (dt2.Rows.Count > 0)
                    {
                        litContent.Text = dt2.Rows[0]["remark"].ToString();
                    }

                }
                
            }
        }
    }
}