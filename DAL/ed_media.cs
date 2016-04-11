using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:ed_media
	/// </summary>
	public partial class ed_media
	{
		public ed_media()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("ID", "ed_media"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ed_media");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
};
			parameters[0].Value = ID;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.ed_media model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ed_media(");
            strSql.Append("nodeId,mediaType,title,picSmall,picBig,mediaUrl,remark,isRecommend,addTime,status)");
			strSql.Append(" values (");
            strSql.Append("@nodeId,@mediaType,@title,@picSmall,@picBig,@mediaUrl,@remark,@isRecommend,@addTime,@status)");
			OleDbParameter[] parameters = {
                    new OleDbParameter("@nodeId", OleDbType.Integer,4),
					new OleDbParameter("@mediaType", OleDbType.Integer,4),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@picSmall", OleDbType.VarChar,255),
					new OleDbParameter("@picBig", OleDbType.VarChar,255),
					new OleDbParameter("@mediaUrl", OleDbType.VarChar,255),
					new OleDbParameter("@remark", OleDbType.VarChar,0),
					new OleDbParameter("@isRecommend", OleDbType.Integer,4),
					new OleDbParameter("@addTime", OleDbType.Date),
					new OleDbParameter("@status", OleDbType.Integer,4)};
			parameters[0].Value = model.nodeId;
            parameters[1].Value = model.mediaType;
			parameters[2].Value = model.title;
			parameters[3].Value = model.picSmall;
			parameters[4].Value = model.picBig;
			parameters[5].Value = model.mediaUrl;
			parameters[6].Value = model.remark;
			parameters[7].Value = model.isRecommend;
			parameters[8].Value = model.addTime;
			parameters[9].Value = model.status;

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
		public bool Update(hm.Model.ed_media model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ed_media set ");
			strSql.Append("mediaType=@mediaType,");
			strSql.Append("nodeId=@nodeId,");
			strSql.Append("title=@title,");
			strSql.Append("picSmall=@picSmall,");
			strSql.Append("picBig=@picBig,");
			strSql.Append("mediaUrl=@mediaUrl,");
			strSql.Append("remark=@remark,");
			strSql.Append("isRecommend=@isRecommend,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("status=@status");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@mediaType", OleDbType.Integer,4),
					new OleDbParameter("@nodeId", OleDbType.Integer,4),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@picSmall", OleDbType.VarChar,255),
					new OleDbParameter("@picBig", OleDbType.VarChar,255),
					new OleDbParameter("@mediaUrl", OleDbType.VarChar,255),
					new OleDbParameter("@remark", OleDbType.VarChar,0),
					new OleDbParameter("@isRecommend", OleDbType.Integer,4),
					new OleDbParameter("@addTime", OleDbType.Date),
					new OleDbParameter("@status", OleDbType.Integer,4),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = model.mediaType;
			parameters[1].Value = model.nodeId;
			parameters[2].Value = model.title;
			parameters[3].Value = model.picSmall;
			parameters[4].Value = model.picBig;
			parameters[5].Value = model.mediaUrl;
			parameters[6].Value = model.remark;
			parameters[7].Value = model.isRecommend;
			parameters[8].Value = model.addTime;
			parameters[9].Value = model.status;
			parameters[10].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ed_media ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ed_media ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public hm.Model.ed_media GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,mediaType,nodeId,title,picSmall,picBig,mediaUrl,remark,isRecommend,addTime,status from ed_media ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
};
			parameters[0].Value = ID;

			hm.Model.ed_media model=new hm.Model.ed_media();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["mediaType"]!=null && ds.Tables[0].Rows[0]["mediaType"].ToString()!="")
				{
					model.mediaType=int.Parse(ds.Tables[0].Rows[0]["mediaType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["nodeId"]!=null && ds.Tables[0].Rows[0]["nodeId"].ToString()!="")
				{
					model.nodeId=int.Parse(ds.Tables[0].Rows[0]["nodeId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["picSmall"]!=null && ds.Tables[0].Rows[0]["picSmall"].ToString()!="")
				{
					model.picSmall=ds.Tables[0].Rows[0]["picSmall"].ToString();
				}
				if(ds.Tables[0].Rows[0]["picBig"]!=null && ds.Tables[0].Rows[0]["picBig"].ToString()!="")
				{
					model.picBig=ds.Tables[0].Rows[0]["picBig"].ToString();
				}
				if(ds.Tables[0].Rows[0]["mediaUrl"]!=null && ds.Tables[0].Rows[0]["mediaUrl"].ToString()!="")
				{
					model.mediaUrl=ds.Tables[0].Rows[0]["mediaUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["remark"]!=null && ds.Tables[0].Rows[0]["remark"].ToString()!="")
				{
					model.remark=ds.Tables[0].Rows[0]["remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["isRecommend"]!=null && ds.Tables[0].Rows[0]["isRecommend"].ToString()!="")
				{
					model.isRecommend=int.Parse(ds.Tables[0].Rows[0]["isRecommend"].ToString());
				}
				if(ds.Tables[0].Rows[0]["addTime"]!=null && ds.Tables[0].Rows[0]["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["status"]!=null && ds.Tables[0].Rows[0]["status"].ToString()!="")
				{
					model.status=int.Parse(ds.Tables[0].Rows[0]["status"].ToString());
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
			strSql.Append("select ID,mediaType,nodeId,title,picSmall,picBig,mediaUrl,remark,isRecommend,addTime,status ");
			strSql.Append(" FROM ed_media ");
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
			parameters[0].Value = "ed_media";
			parameters[1].Value = "ID";
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

