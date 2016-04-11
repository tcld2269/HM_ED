using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:news
	/// </summary>
	public partial class news
	{
		public news()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("newsId", "news"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int newsId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from news");
			strSql.Append(" where newsId=@newsId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@newsId", OleDbType.Integer,4)
};
			parameters[0].Value = newsId;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into news(");
			strSql.Append("catId,catName,userId,userName,deptId,newsTitle,summary,newsContent,picUrl,videoUrl,contentSource,author,addTime,modifyTime,status,isHomePage,isSlide,isTop,fileUrl1,fileUrl2,fileUrl3)");
			strSql.Append(" values (");
			strSql.Append("@catId,@catName,@userId,@userName,@deptId,@newsTitle,@summary,@newsContent,@picUrl,@videoUrl,@contentSource,@author,@addTime,@modifyTime,@status,@isHomePage,@isSlide,@isTop,@fileUrl1,@fileUrl2,@fileUrl3)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@catId", OleDbType.Integer,4),
					new OleDbParameter("@catName", OleDbType.VarChar,0),
					new OleDbParameter("@userId", OleDbType.Integer,4),
					new OleDbParameter("@userName", OleDbType.VarChar,0),
					new OleDbParameter("@deptId", OleDbType.Integer,4),
					new OleDbParameter("@newsTitle", OleDbType.VarChar,0),
					new OleDbParameter("@summary", OleDbType.VarChar,0),
					new OleDbParameter("@newsContent", OleDbType.VarChar,0),
					new OleDbParameter("@picUrl", OleDbType.VarChar,0),
					new OleDbParameter("@videoUrl", OleDbType.VarChar,0),
					new OleDbParameter("@contentSource", OleDbType.VarChar,0),
					new OleDbParameter("@author", OleDbType.VarChar,0),
					new OleDbParameter("@addTime", OleDbType.Date),
					new OleDbParameter("@modifyTime", OleDbType.Date),
					new OleDbParameter("@status", OleDbType.Integer,4),
					new OleDbParameter("@isHomePage", OleDbType.Integer,4),
					new OleDbParameter("@isSlide", OleDbType.Integer,4),
					new OleDbParameter("@isTop", OleDbType.Integer,4),
					new OleDbParameter("@fileUrl1", OleDbType.VarChar,0),
					new OleDbParameter("@fileUrl2", OleDbType.VarChar,0),
					new OleDbParameter("@fileUrl3", OleDbType.VarChar,0)};
			parameters[0].Value = model.catId;
			parameters[1].Value = model.catName;
			parameters[2].Value = model.userId;
			parameters[3].Value = model.userName;
			parameters[4].Value = model.deptId;
			parameters[5].Value = model.newsTitle;
			parameters[6].Value = model.summary;
			parameters[7].Value = model.newsContent;
			parameters[8].Value = model.picUrl;
			parameters[9].Value = model.videoUrl;
			parameters[10].Value = model.contentSource;
			parameters[11].Value = model.author;
			parameters[12].Value = model.addTime;
			parameters[13].Value = model.modifyTime;
			parameters[14].Value = model.status;
			parameters[15].Value = model.isHomePage;
			parameters[16].Value = model.isSlide;
			parameters[17].Value = model.isTop;
			parameters[18].Value = model.fileUrl1;
			parameters[19].Value = model.fileUrl2;
			parameters[20].Value = model.fileUrl3;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update news set ");
			strSql.Append("catId=@catId,");
			strSql.Append("catName=@catName,");
			strSql.Append("userId=@userId,");
			strSql.Append("userName=@userName,");
			strSql.Append("deptId=@deptId,");
			strSql.Append("newsTitle=@newsTitle,");
			strSql.Append("summary=@summary,");
			strSql.Append("newsContent=@newsContent,");
			strSql.Append("picUrl=@picUrl,");
			strSql.Append("videoUrl=@videoUrl,");
			strSql.Append("contentSource=@contentSource,");
			strSql.Append("author=@author,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("modifyTime=@modifyTime,");
			strSql.Append("status=@status,");
			strSql.Append("isHomePage=@isHomePage,");
			strSql.Append("isSlide=@isSlide,");
			strSql.Append("isTop=@isTop,");
			strSql.Append("fileUrl1=@fileUrl1,");
			strSql.Append("fileUrl2=@fileUrl2,");
			strSql.Append("fileUrl3=@fileUrl3");
			strSql.Append(" where newsId=@newsId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@catId", OleDbType.Integer,4),
					new OleDbParameter("@catName", OleDbType.VarChar,0),
					new OleDbParameter("@userId", OleDbType.Integer,4),
					new OleDbParameter("@userName", OleDbType.VarChar,0),
					new OleDbParameter("@deptId", OleDbType.Integer,4),
					new OleDbParameter("@newsTitle", OleDbType.VarChar,0),
					new OleDbParameter("@summary", OleDbType.VarChar,0),
					new OleDbParameter("@newsContent", OleDbType.VarChar,0),
					new OleDbParameter("@picUrl", OleDbType.VarChar,0),
					new OleDbParameter("@videoUrl", OleDbType.VarChar,0),
					new OleDbParameter("@contentSource", OleDbType.VarChar,0),
					new OleDbParameter("@author", OleDbType.VarChar,0),
					new OleDbParameter("@addTime", OleDbType.Date),
					new OleDbParameter("@modifyTime", OleDbType.Date),
					new OleDbParameter("@status", OleDbType.Integer,4),
					new OleDbParameter("@isHomePage", OleDbType.Integer,4),
					new OleDbParameter("@isSlide", OleDbType.Integer,4),
					new OleDbParameter("@isTop", OleDbType.Integer,4),
					new OleDbParameter("@fileUrl1", OleDbType.VarChar,0),
					new OleDbParameter("@fileUrl2", OleDbType.VarChar,0),
					new OleDbParameter("@fileUrl3", OleDbType.VarChar,0),
					new OleDbParameter("@newsId", OleDbType.Integer,4)};
			parameters[0].Value = model.catId;
			parameters[1].Value = model.catName;
			parameters[2].Value = model.userId;
			parameters[3].Value = model.userName;
			parameters[4].Value = model.deptId;
			parameters[5].Value = model.newsTitle;
			parameters[6].Value = model.summary;
			parameters[7].Value = model.newsContent;
			parameters[8].Value = model.picUrl;
			parameters[9].Value = model.videoUrl;
			parameters[10].Value = model.contentSource;
			parameters[11].Value = model.author;
			parameters[12].Value = model.addTime;
			parameters[13].Value = model.modifyTime;
			parameters[14].Value = model.status;
			parameters[15].Value = model.isHomePage;
			parameters[16].Value = model.isSlide;
			parameters[17].Value = model.isTop;
			parameters[18].Value = model.fileUrl1;
			parameters[19].Value = model.fileUrl2;
			parameters[20].Value = model.fileUrl3;
			parameters[21].Value = model.newsId;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int newsId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from news ");
			strSql.Append(" where newsId=@newsId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@newsId", OleDbType.Integer,4)
};
			parameters[0].Value = newsId;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string newsIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from news ");
			strSql.Append(" where newsId in ("+newsIdlist + ")  ");
			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.news GetModel(int newsId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select newsId,catId,catName,userId,userName,deptId,newsTitle,summary,newsContent,picUrl,videoUrl,contentSource,author,addTime,modifyTime,status,isHomePage,isSlide,isTop,fileUrl1,fileUrl2,fileUrl3 from news ");
			strSql.Append(" where newsId=@newsId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@newsId", OleDbType.Integer,4)
};
			parameters[0].Value = newsId;

			hm.Model.news model=new hm.Model.news();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["newsId"]!=null && ds.Tables[0].Rows[0]["newsId"].ToString()!="")
				{
					model.newsId=int.Parse(ds.Tables[0].Rows[0]["newsId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["catId"]!=null && ds.Tables[0].Rows[0]["catId"].ToString()!="")
				{
					model.catId=int.Parse(ds.Tables[0].Rows[0]["catId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["catName"]!=null && ds.Tables[0].Rows[0]["catName"].ToString()!="")
				{
					model.catName=ds.Tables[0].Rows[0]["catName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["userId"]!=null && ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userName"]!=null && ds.Tables[0].Rows[0]["userName"].ToString()!="")
				{
					model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["deptId"]!=null && ds.Tables[0].Rows[0]["deptId"].ToString()!="")
				{
					model.deptId=int.Parse(ds.Tables[0].Rows[0]["deptId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["newsTitle"]!=null && ds.Tables[0].Rows[0]["newsTitle"].ToString()!="")
				{
					model.newsTitle=ds.Tables[0].Rows[0]["newsTitle"].ToString();
				}
				if(ds.Tables[0].Rows[0]["summary"]!=null && ds.Tables[0].Rows[0]["summary"].ToString()!="")
				{
					model.summary=ds.Tables[0].Rows[0]["summary"].ToString();
				}
				if(ds.Tables[0].Rows[0]["newsContent"]!=null && ds.Tables[0].Rows[0]["newsContent"].ToString()!="")
				{
					model.newsContent=ds.Tables[0].Rows[0]["newsContent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["picUrl"]!=null && ds.Tables[0].Rows[0]["picUrl"].ToString()!="")
				{
					model.picUrl=ds.Tables[0].Rows[0]["picUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["videoUrl"]!=null && ds.Tables[0].Rows[0]["videoUrl"].ToString()!="")
				{
					model.videoUrl=ds.Tables[0].Rows[0]["videoUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["contentSource"]!=null && ds.Tables[0].Rows[0]["contentSource"].ToString()!="")
				{
					model.contentSource=ds.Tables[0].Rows[0]["contentSource"].ToString();
				}
				if(ds.Tables[0].Rows[0]["author"]!=null && ds.Tables[0].Rows[0]["author"].ToString()!="")
				{
					model.author=ds.Tables[0].Rows[0]["author"].ToString();
				}
				if(ds.Tables[0].Rows[0]["addTime"]!=null && ds.Tables[0].Rows[0]["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["modifyTime"]!=null && ds.Tables[0].Rows[0]["modifyTime"].ToString()!="")
				{
					model.modifyTime=DateTime.Parse(ds.Tables[0].Rows[0]["modifyTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["status"]!=null && ds.Tables[0].Rows[0]["status"].ToString()!="")
				{
					model.status=int.Parse(ds.Tables[0].Rows[0]["status"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isHomePage"]!=null && ds.Tables[0].Rows[0]["isHomePage"].ToString()!="")
				{
					model.isHomePage=int.Parse(ds.Tables[0].Rows[0]["isHomePage"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isSlide"]!=null && ds.Tables[0].Rows[0]["isSlide"].ToString()!="")
				{
					model.isSlide=int.Parse(ds.Tables[0].Rows[0]["isSlide"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isTop"]!=null && ds.Tables[0].Rows[0]["isTop"].ToString()!="")
				{
					model.isTop=int.Parse(ds.Tables[0].Rows[0]["isTop"].ToString());
				}
				if(ds.Tables[0].Rows[0]["fileUrl1"]!=null && ds.Tables[0].Rows[0]["fileUrl1"].ToString()!="")
				{
					model.fileUrl1=ds.Tables[0].Rows[0]["fileUrl1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["fileUrl2"]!=null && ds.Tables[0].Rows[0]["fileUrl2"].ToString()!="")
				{
					model.fileUrl2=ds.Tables[0].Rows[0]["fileUrl2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["fileUrl3"]!=null && ds.Tables[0].Rows[0]["fileUrl3"].ToString()!="")
				{
					model.fileUrl3=ds.Tables[0].Rows[0]["fileUrl3"].ToString();
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select newsId,catId,catName,userId,userName,deptId,newsTitle,summary,newsContent,picUrl,videoUrl,contentSource,author,addTime,modifyTime,status,isHomePage,isSlide,isTop,fileUrl1,fileUrl2,fileUrl3 ");
			strSql.Append(" FROM news ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OleDbParameter[] parameters = {
					new OleDbParameter("@tblName", OleDbType.VarChar, 255),
					new OleDbParameter("@fldName", OleDbType.VarChar, 255),
					new OleDbParameter("@PageSize", OleDbType.Integer),
					new OleDbParameter("@PageIndex", OleDbType.Integer),
					new OleDbParameter("@IsReCount", OleDbType.Boolean),
					new OleDbParameter("@OrderType", OleDbType.Boolean),
					new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
					};
			parameters[0].Value = "news";
			parameters[1].Value = "newsId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

