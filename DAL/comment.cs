using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:comment
	/// </summary>
	public partial class comment
	{
		public comment()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("ID", "comment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from comment");
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
		public bool Add(hm.Model.comment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into comment(");
			strSql.Append("parentId,nodeType,nodeId,userId,title,trueName,tel,email,remark,addTime,status)");
			strSql.Append(" values (");
			strSql.Append("@parentId,@nodeType,@nodeId,@userId,@title,@trueName,@tel,@email,@remark,@addTime,@status)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@parentId", OleDbType.Integer,4),
					new OleDbParameter("@nodeType", OleDbType.Integer,4),
					new OleDbParameter("@nodeId", OleDbType.Integer,4),
					new OleDbParameter("@userId", OleDbType.Integer,4),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@trueName", OleDbType.VarChar,255),
					new OleDbParameter("@tel", OleDbType.VarChar,255),
					new OleDbParameter("@email", OleDbType.VarChar,255),
					new OleDbParameter("@remark", OleDbType.VarChar,0),
					new OleDbParameter("@addTime", OleDbType.Date),
					new OleDbParameter("@status", OleDbType.Integer,4)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.nodeType;
			parameters[2].Value = model.nodeId;
			parameters[3].Value = model.userId;
			parameters[4].Value = model.title;
			parameters[5].Value = model.trueName;
			parameters[6].Value = model.tel;
			parameters[7].Value = model.email;
			parameters[8].Value = model.remark;
			parameters[9].Value = model.addTime;
			parameters[10].Value = model.status;

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
		public bool Update(hm.Model.comment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update comment set ");
			strSql.Append("parentId=@parentId,");
			strSql.Append("nodeType=@nodeType,");
			strSql.Append("nodeId=@nodeId,");
			strSql.Append("userId=@userId,");
			strSql.Append("title=@title,");
			strSql.Append("trueName=@trueName,");
			strSql.Append("tel=@tel,");
			strSql.Append("email=@email,");
			strSql.Append("remark=@remark,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("status=@status");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@parentId", OleDbType.Integer,4),
					new OleDbParameter("@nodeType", OleDbType.Integer,4),
					new OleDbParameter("@nodeId", OleDbType.Integer,4),
					new OleDbParameter("@userId", OleDbType.Integer,4),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@trueName", OleDbType.VarChar,255),
					new OleDbParameter("@tel", OleDbType.VarChar,255),
					new OleDbParameter("@email", OleDbType.VarChar,255),
					new OleDbParameter("@remark", OleDbType.VarChar,0),
					new OleDbParameter("@addTime", OleDbType.Date),
					new OleDbParameter("@status", OleDbType.Integer,4),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.nodeType;
			parameters[2].Value = model.nodeId;
			parameters[3].Value = model.userId;
			parameters[4].Value = model.title;
			parameters[5].Value = model.trueName;
			parameters[6].Value = model.tel;
			parameters[7].Value = model.email;
			parameters[8].Value = model.remark;
			parameters[9].Value = model.addTime;
			parameters[10].Value = model.status;
			parameters[11].Value = model.ID;

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
			strSql.Append("delete from comment ");
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
			strSql.Append("delete from comment ");
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
		public hm.Model.comment GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,parentId,nodeType,nodeId,userId,title,trueName,tel,email,remark,addTime,status from comment ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
};
			parameters[0].Value = ID;

			hm.Model.comment model=new hm.Model.comment();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["parentId"]!=null && ds.Tables[0].Rows[0]["parentId"].ToString()!="")
				{
					model.parentId=int.Parse(ds.Tables[0].Rows[0]["parentId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["nodeType"]!=null && ds.Tables[0].Rows[0]["nodeType"].ToString()!="")
				{
					model.nodeType=int.Parse(ds.Tables[0].Rows[0]["nodeType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["nodeId"]!=null && ds.Tables[0].Rows[0]["nodeId"].ToString()!="")
				{
					model.nodeId=int.Parse(ds.Tables[0].Rows[0]["nodeId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userId"]!=null && ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["trueName"]!=null && ds.Tables[0].Rows[0]["trueName"].ToString()!="")
				{
					model.trueName=ds.Tables[0].Rows[0]["trueName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["tel"]!=null && ds.Tables[0].Rows[0]["tel"].ToString()!="")
				{
					model.tel=ds.Tables[0].Rows[0]["tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["email"]!=null && ds.Tables[0].Rows[0]["email"].ToString()!="")
				{
					model.email=ds.Tables[0].Rows[0]["email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["remark"]!=null && ds.Tables[0].Rows[0]["remark"].ToString()!="")
				{
					model.remark=ds.Tables[0].Rows[0]["remark"].ToString();
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
			strSql.Append("select ID,parentId,nodeType,nodeId,userId,title,trueName,tel,email,remark,addTime,status ");
			strSql.Append(" FROM comment ");
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
			parameters[0].Value = "comment";
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

