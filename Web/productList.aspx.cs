using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace hm.Web
{
    public partial class productList : WebPage
    {
        BLL.ed_node nBll = new BLL.ed_node();
        BLL.ed_product pBll = new BLL.ed_product();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    Model.ed_node model = nBll.GetModel(int.Parse(Request.QueryString["id"].ToString()));
                    DataTable dt = nBll.GetList("parentId=" + model.ID + " and types=3 order by orders desc").Tables[0];
                    if (dt.Rows.Count == 0)
                    {
                        dt = nBll.GetList("parentId=" + model.parentId.Value + " and types=3 order by orders desc").Tables[0];
                    }
                    rptNode.DataSource = dt;
                    rptNode.DataBind();

                    DataTable dt2 = pBll.GetList("nodeId=" + Request.QueryString["id"].ToString() + "or nodeId in (select Id from ed_node where parentId=" + Request.QueryString["id"].ToString() + ") order by addTime desc").Tables[0];
                    for(int i=0;i<dt2.Rows.Count;i++)
                    {
                        if (string.IsNullOrEmpty(dt2.Rows[i]["picBig"].ToString()))
                        {
                            dt2.Rows[i]["picBig"] = "/images/klm.png";
                        }
                    }
                    
                    rptProductList.DataSource = dt2;
                    rptProductList.DataBind();

                    //导航
                    List<Model.ed_node> list = nBll.GetModelList("id=" + model.parentId);
                    if (list.Count > 0)
                    {
                        if (list[0].parentId.Value != 0)
                        {
                            List<Model.ed_node> list2 = nBll.GetModelList("id=" + list[0].parentId);
                            if (list2.Count > 0)
                            {
                                litNav.Text = list2[0].title + " > " + list[0].title + ">" + model.title;
                            }
                        }
                        else
                        {
                            litNav.Text = list[0].title + ">" + model.title;
                        }
                    }
                    else
                    {
                        litNav.Text = model.title;
                    }

                }
                
            }
        }
    }
}