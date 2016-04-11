using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:ad
	/// </summary>
	public partial class ad
	{
		public ad()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("id", "ad"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ad");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)
};
			parameters[0].Value = id;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.ad model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ad(");
			strSql.Append("apId,title,url,pic,remark,startDate,endDate,orders,addTime,status)");
			strSql.Append(" values (");
			strSql.Append("@apId,@title,@url,@pic,@remark,@startDate,@endDate,@orders,@addTime,@status)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@apId", OleDbType.Integer,4),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@url", OleDbType.VarChar,255),
					new OleDbParameter("@pic", OleDbType.VarChar,255),
					new OleDbParameter("@remark", OleDbType.VarChar,0),
					new OleDbParameter("@startDate", OleDbType.Date),
					new OleDbParameter("@endDate", OleDbType.Date),
					new OleDbParameter("@orders", OleDbType.Integer,4),
					new OleDbParameter("@addTime", OleDbType.Date),
					new OleDbParameter("@status", OleDbType.Integer,4)};
			parameters[0].Value = model.apId;
			parameters[1].Value = model.title;
			parameters[2].Value = model.url;
			parameters[3].Value = model.pic;
			parameters[4].Value = model.remark;
			parameters[5].Value = model.startDate;
			parameters[6].Value = model.endDate;
			parameters[7].Value = model.orders;
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
		public bool Update(hm.Model.ad model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ad set ");
			strSql.Append("apId=@apId,");
			strSql.Append("title=@title,");
			strSql.Append("url=@url,");
			strSql.Append("pic=@pic,");
			strSql.Append("remark=@remark,");
			strSql.Append("startDate=@startDate,");
			strSql.Append("endDate=@endDate,");
			strSql.Append("orders=@orders,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("status=@status");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@apId", OleDbType.Integer,4),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@url", OleDbType.VarChar,255),
					new OleDbParameter("@pic", OleDbType.VarChar,255),
					new OleDbParameter("@remark", OleDbType.VarChar,0),
					new OleDbParameter("@startDate", OleDbType.Date),
					new OleDbParameter("@endDate", OleDbType.Date),
					new OleDbParameter("@orders", OleDbType.Integer,4),
					new OleDbParameter("@addTime", OleDbType.Date),
					new OleDbParameter("@status", OleDbType.Integer,4),
					new OleDbParameter("@id", OleDbType.Integer,4)};
			parameters[0].Value = model.apId;
			parameters[1].Value = model.title;
			parameters[2].Value = model.url;
			parameters[3].Value = model.pic;
			parameters[4].Value = model.remark;
			parameters[5].Value = model.startDate;
			parameters[6].Value = model.endDate;
			parameters[7].Value = model.orders;
			parameters[8].Value = model.addTime;
			parameters[9].Value = model.status;
			parameters[10].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ad ");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)
};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ad ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public hm.Model.ad GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,apId,title,url,pic,remark,startDate,endDate,orders,addTime,status from ad ");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)
};
			parameters[0].Value = id;

			hm.Model.ad model=new hm.Model.ad();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["apId"]!=null && ds.Tables[0].Rows[0]["apId"].ToString()!="")
				{
					model.apId=int.Parse(ds.Tables[0].Rows[0]["apId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["url"]!=null && ds.Tables[0].Rows[0]["url"].ToString()!="")
				{
					model.url=ds.Tables[0].Rows[0]["url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pic"]!=null && ds.Tables[0].Rows[0]["pic"].ToString()!="")
				{
					model.pic=ds.Tables[0].Rows[0]["pic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["remark"]!=null && ds.Tables[0].Rows[0]["remark"].ToString()!="")
				{
					model.remark=ds.Tables[0].Rows[0]["remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["startDate"]!=null && ds.Tables[0].Rows[0]["startDate"].ToString()!="")
				{
					model.startDate=DateTime.Parse(ds.Tables[0].Rows[0]["startDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["endDate"]!=null && ds.Tables[0].Rows[0]["endDate"].ToString()!="")
				{
					model.endDate=DateTime.Parse(ds.Tables[0].Rows[0]["endDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
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
			strSql.Append("select id,apId,title,url,pic,remark,startDate,endDate,orders,addTime,status ");
			strSql.Append(" FROM ad ");
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
			parameters[0].Value = "ad";
			parameters[1].Value = "id";
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

