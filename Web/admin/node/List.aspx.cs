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
namespace hm.Web.admin.node
{
    public partial class List : Page
    {
        hm.BLL.ed_node bll = new hm.BLL.ed_node();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                bindParentMenuAdd();
                BindData();

                ddrModel.DataTextField = "itemName";
                ddrModel.DataValueField = "siId";
                ddrModel.DataSource = ClassHelper.GetSystemItem("Node_Media");
                ddrModel.DataBind();

                ddrModelAdd.DataTextField = "itemName";
                ddrModelAdd.DataValueField = "siId";
                ddrModelAdd.DataSource = ClassHelper.GetSystemItem("Node_Media");
                ddrModelAdd.DataBind();

                ddrModel.CssClass = "hide";
                ddrModelAdd.CssClass = "hide";
            }
        }

        public void BindData()
        {
            DataSet ds = new DataSet();

            ds = bll.GetList("1=1 order by orders desc");

            string[] arr = { "parentId", "title", "ID"};
            Common.CommonHelper.AddTopTreeViewNodes(TreeView1, ds.Tables[0], arr);

            Common.CommonHelper.bindNodeTypes(ddrTypes);
            Common.CommonHelper.bindNodeTypes(ddrTypesAdd);
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode t = this.TreeView1.SelectedNode;
            int Id = int.Parse(t.Value);
            Model.ed_node model = bll.GetModel(Id);

            bindParentMenu();
            lblId.Text = model.ID.ToString();
            ddrParent.SelectedValue = model.parentId.ToString();
            txtTitle.Text = model.title;
            txtOrder.Text=model.orders.ToString();
            txtUrl.Text=model.url;
            ddrTypes.SelectedValue = model.types.ToString();
            if (model.types.Value == 4)
            {
                ddrModel.CssClass = "show";
                ddrModel.SelectedValue = model.models.ToString();
            }
            else
            {
                ddrModel.CssClass = "hide";
            }
            cbShow.Checked = false;
            if (model.isShow.Value == 1)
            {
                cbShow.Checked = true;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.txtTitleAdd.Text.Trim().Length == 0)
            {
                strErr += "名称不能为空！\\n";
            }
            if (!PageValidate.IsNumber(txtOrderAdd.Text))
            {
                strErr += "排序格式错误！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string title = this.txtTitleAdd.Text;
            int parentId = int.Parse(this.ddrNodeAdd.SelectedValue);
            int orders = int.Parse(txtOrderAdd.Text);
            string url=txtUrlAdd.Text;
            int types = int.Parse(this.ddrTypesAdd.SelectedValue);
            int models = 0;
            if (types == 4)
            {
                models = int.Parse(ddrModel.SelectedValue);
            }

            hm.Model.ed_node model = new hm.Model.ed_node();
            model.title = title;
            model.parentId = parentId;
            model.pic = "";
            model.types = types;
            model.orders=orders;
            model.url=url;
            model.isShow = 1;
            model.models = models;
            if (!cbShowAdd.Checked)
            {
                model.isShow = 0;
            }

            bll.Add(model);
            bindParentMenuAdd();
            BindData();
        }

        protected void btnMod_Click(object sender, EventArgs e)
        {
            string id = lblId.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show(this, "请选择修改的栏目！");
                return;
            }
            string strErr = "";
            if (this.txtTitle.Text.Trim().Length == 0)
            {
                strErr += "名称不能为空！\\n";
            }
            if (!PageValidate.IsNumber(txtOrderAdd.Text))
            {
                strErr += "排序格式错误！\\n";
            }
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            string title = this.txtTitle.Text;
            int parentId = int.Parse(this.ddrParent.SelectedValue);
            int orders = int.Parse(txtOrder.Text);
            string url = txtUrl.Text;
            int types = int.Parse(this.ddrTypes.SelectedValue);
            int models = 0;
            if (types == 4)
            {
                models = int.Parse(ddrModel.SelectedValue);
            }

            hm.Model.ed_node model = bll.GetModel(int.Parse(lblId.Text));
            model.title = title;
            model.parentId = parentId;
            model.pic = "";
            model.types = types;
            model.orders = orders;
            model.url = url;
            model.isShow = 1;
            if (!cbShow.Checked)
            {
                model.isShow = 0;
            }
            model.models = models;

            bll.Update(model);
            bindParentMenuAdd();
            BindData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lblId.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show(this, "请选择要删除的栏目！");
                return;
            }

            if (bll.GetList("parentId=" + id).Tables[0].Rows.Count > 0)
            {
                MessageBox.Show(this, "请先删除下级菜单！");
                return;
            }

            bll.Delete(int.Parse(id));
            lblId.Text = "";
            txtTitle.Text = "";
            ddrParent.SelectedValue = "0";
            txtOrder.Text = "";
            txtUrl.Text = "";
            bindParentMenuAdd();
            BindData();
        }

        private void bindParentMenuAdd()
        {
            ddrNodeAdd.Items.Clear();
            BLL.ed_node deptBll = new BLL.ed_node();
            DataTable dt = deptBll.GetList("parentId=0   order by orders desc").Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddrNodeAdd.Items.Add(new ListItem(dt.Rows[i]["title"].ToString(), dt.Rows[i]["Id"].ToString()));
                DataTable dt2 = deptBll.GetList("parentId="+dt.Rows[i]["id"].ToString()+"   order by orders desc").Tables[0];
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    ddrNodeAdd.Items.Add(new ListItem("┣" + dt2.Rows[j]["title"].ToString(), dt2.Rows[j]["Id"].ToString()));
                }
            }
            ddrNodeAdd.Items.Insert(0, new ListItem("根栏目", "0"));
        }
        private void bindParentMenu()
        {
            ddrParent.Items.Clear();
            BLL.ed_node deptBll = new BLL.ed_node();
            DataTable dt = deptBll.GetList("parentId=0 order by orders asc").Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddrParent.Items.Add(new ListItem(dt.Rows[i]["title"].ToString(), dt.Rows[i]["Id"].ToString()));
                DataTable dt2 = deptBll.GetList("parentId=" + dt.Rows[i]["id"].ToString() + "   order by orders desc").Tables[0];
                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    ddrParent.Items.Add(new ListItem("┣" + dt2.Rows[j]["title"].ToString(), dt2.Rows[j]["Id"].ToString()));
                }
            }
            ddrParent.Items.Insert(0, new ListItem("根栏目", "0"));
        }
    }
}
