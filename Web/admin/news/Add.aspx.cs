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
namespace hm.Web.news
{
    public partial class Add : WebPage
    {
        BLL.ed_node nBll = new BLL.ed_node();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                litId.Text = Request.QueryString["id"].ToString();
                Model.ed_node model = nBll.GetModel(int.Parse(litId.Text));
                litName.Text = model.title;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtnewsTitle.Text.Trim().Length==0)
			{
				strErr+="标题不能为空！\\n";	
			}
			if(this.txtContent.Text.Trim().Length==0)
			{
				strErr+="新闻内容不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
            int catId = int.Parse(litId.Text);
			int userId=int.Parse(Request.Cookies["userId"].Value);
            string userName = Request.Cookies["userName"].Value;

            int deptId = 1;
            
			string newsTitle=this.txtnewsTitle.Text;
			string summary="";
            string newsContent = this.txtContent.Text;
			string contentSource="";
			string author="";
            DateTime addTime = DateTime.Now;
            DateTime modifyTime = DateTime.Now;
			int status=1;
			int isHomePage=0;
			int isSlide=0;
            
			hm.Model.news model=new hm.Model.news();
			model.catId=catId;
			model.catName="";
			model.userId=userId;
			model.userName=userName;
			model.deptId=deptId;
			model.newsTitle=newsTitle;
			model.summary=summary;
			model.newsContent=newsContent;
			model.contentSource=contentSource;
			model.author=author;
			model.addTime=addTime;
			model.modifyTime=modifyTime;
			model.status=status;
			model.isHomePage=isHomePage;
			model.isSlide=isSlide;
            model.picUrl = "";
            model.videoUrl = "";
            model.isTop = 0;
            model.fileUrl1 = "";
            model.fileUrl2 = "";
            model.fileUrl3 = "";

			hm.BLL.news bll=new hm.BLL.news();
			bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "../media/list.aspx?id=" + model.catId);

		}

    }
}
