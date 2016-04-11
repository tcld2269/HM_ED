using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:ed_page
	/// </summary>
	public partial class ed_page
	{
		public ed_page()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("ID", "ed_page"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ed_page");
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
		public bool Add(hm.Model.ed_page model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ed_page(");
			strSql.Append("nodeId,title,pic,remark)");
			strSql.Append(" values (");
			strSql.Append("@nodeId,@title,@pic,@remark)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@nodeId", OleDbType.Integer,4),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@pic", OleDbType.VarChar,255),
					new OleDbParameter("@remark", OleDbType.VarChar,0)};
			parameters[0].Value = model.nodeId;
			parameters[1].Value = model.title;
			parameters[2].Value = model.pic;
			parameters[3].Value = model.remark;

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
		public bool Update(hm.Model.ed_page model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ed_page set ");
			strSql.Append("nodeId=@nodeId,");
			strSql.Append("title=@title,");
			strSql.Append("pic=@pic,");
			strSql.Append("remark=@remark");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@nodeId", OleDbType.Integer,4),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@pic", OleDbType.VarChar,255),
					new OleDbParameter("@remark", OleDbType.VarChar,0),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = model.nodeId;
			parameters[1].Value = model.title;
			parameters[2].Value = model.pic;
			parameters[3].Value = model.remark;
			parameters[4].Value = model.ID;

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
			strSql.Append("delete from ed_page ");
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
			strSql.Append("delete from ed_page ");
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
		public hm.Model.ed_page GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,nodeId,title,pic,remark from ed_page ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
};
			parameters[0].Value = ID;

			hm.Model.ed_page model=new hm.Model.ed_page();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["nodeId"]!=null && ds.Tables[0].Rows[0]["nodeId"].ToString()!="")
				{
					model.nodeId=int.Parse(ds.Tables[0].Rows[0]["nodeId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pic"]!=null && ds.Tables[0].Rows[0]["pic"].ToString()!="")
				{
					model.pic=ds.Tables[0].Rows[0]["pic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["remark"]!=null && ds.Tables[0].Rows[0]["remark"].ToString()!="")
				{
					model.remark=ds.Tables[0].Rows[0]["remark"].ToString();
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
			strSql.Append("select ID,nodeId,title,pic,remark ");
			strSql.Append(" FROM ed_page ");
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
			parameters[0].Value = "ed_page";
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

