using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace hm.Web
{
    public partial class productShow : WebPage
    {
        BLL.ed_node nBll = new BLL.ed_node();
        BLL.ed_product pBll = new BLL.ed_product();
        public Model.ed_product model = new Model.ed_product();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    model = pBll.GetModel(int.Parse(Request.QueryString["id"].ToString()));

                    Model.ed_node modelNode = nBll.GetModel(model.nodeId.Value);
                    DataTable dt = nBll.GetList("parentId=" + modelNode.ID + " and types=3 order by orders desc").Tables[0];
                    if (dt.Rows.Count == 0)
                    {
                        dt = nBll.GetList("parentId=" + modelNode.parentId.Value + " and types=3 order by orders desc").Tables[0];
                    }
                    rptNode.DataSource = dt;
                    rptNode.DataBind();

                    


                }
                
            }
        }
    }
}