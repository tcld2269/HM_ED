using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:sysItem
	/// </summary>
	public partial class sysItem
	{
		public sysItem()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("siId", "sysItem"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int siId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sysItem");
			strSql.Append(" where siId=@siId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@siId", OleDbType.Integer,4)
};
			parameters[0].Value = siId;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.sysItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sysItem(");
			strSql.Append("sicId,itemName,orders,col1,col2,col3,col4)");
			strSql.Append(" values (");
			strSql.Append("@sicId,@itemName,@orders,@col1,@col2,@col3,@col4)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@sicId", OleDbType.Integer,4),
					new OleDbParameter("@itemName", OleDbType.VarChar,0),
					new OleDbParameter("@orders", OleDbType.Integer,4),
					new OleDbParameter("@col1", OleDbType.VarChar,255),
					new OleDbParameter("@col2", OleDbType.VarChar,255),
					new OleDbParameter("@col3", OleDbType.VarChar,255),
					new OleDbParameter("@col4", OleDbType.Integer,4)};
			parameters[0].Value = model.sicId;
			parameters[1].Value = model.itemName;
			parameters[2].Value = model.orders;
			parameters[3].Value = model.col1;
			parameters[4].Value = model.col2;
			parameters[5].Value = model.col3;
			parameters[6].Value = model.col4;

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
		public bool Update(hm.Model.sysItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sysItem set ");
			strSql.Append("sicId=@sicId,");
			strSql.Append("itemName=@itemName,");
			strSql.Append("orders=@orders,");
			strSql.Append("col1=@col1,");
			strSql.Append("col2=@col2,");
			strSql.Append("col3=@col3,");
			strSql.Append("col4=@col4");
			strSql.Append(" where siId=@siId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@sicId", OleDbType.Integer,4),
					new OleDbParameter("@itemName", OleDbType.VarChar,0),
					new OleDbParameter("@orders", OleDbType.Integer,4),
					new OleDbParameter("@col1", OleDbType.VarChar,255),
					new OleDbParameter("@col2", OleDbType.VarChar,255),
					new OleDbParameter("@col3", OleDbType.VarChar,255),
					new OleDbParameter("@col4", OleDbType.Integer,4),
					new OleDbParameter("@siId", OleDbType.Integer,4)};
			parameters[0].Value = model.sicId;
			parameters[1].Value = model.itemName;
			parameters[2].Value = model.orders;
			parameters[3].Value = model.col1;
			parameters[4].Value = model.col2;
			parameters[5].Value = model.col3;
			parameters[6].Value = model.col4;
			parameters[7].Value = model.siId;

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
		public bool Delete(int siId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sysItem ");
			strSql.Append(" where siId=@siId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@siId", OleDbType.Integer,4)
};
			parameters[0].Value = siId;

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
		public bool DeleteList(string siIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from sysItem ");
			strSql.Append(" where siId in ("+siIdlist + ")  ");
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
		public hm.Model.sysItem GetModel(int siId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select siId,sicId,itemName,orders,col1,col2,col3,col4 from sysItem ");
			strSql.Append(" where siId=@siId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@siId", OleDbType.Integer,4)
};
			parameters[0].Value = siId;

			hm.Model.sysItem model=new hm.Model.sysItem();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["siId"]!=null && ds.Tables[0].Rows[0]["siId"].ToString()!="")
				{
					model.siId=int.Parse(ds.Tables[0].Rows[0]["siId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sicId"]!=null && ds.Tables[0].Rows[0]["sicId"].ToString()!="")
				{
					model.sicId=int.Parse(ds.Tables[0].Rows[0]["sicId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["itemName"]!=null && ds.Tables[0].Rows[0]["itemName"].ToString()!="")
				{
					model.itemName=ds.Tables[0].Rows[0]["itemName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
				}
				if(ds.Tables[0].Rows[0]["col1"]!=null && ds.Tables[0].Rows[0]["col1"].ToString()!="")
				{
					model.col1=ds.Tables[0].Rows[0]["col1"].ToString();
				}
				if(ds.Tables[0].Rows[0]["col2"]!=null && ds.Tables[0].Rows[0]["col2"].ToString()!="")
				{
					model.col2=ds.Tables[0].Rows[0]["col2"].ToString();
				}
				if(ds.Tables[0].Rows[0]["col3"]!=null && ds.Tables[0].Rows[0]["col3"].ToString()!="")
				{
					model.col3=ds.Tables[0].Rows[0]["col3"].ToString();
				}
				if(ds.Tables[0].Rows[0]["col4"]!=null && ds.Tables[0].Rows[0]["col4"].ToString()!="")
				{
					model.col4=int.Parse(ds.Tables[0].Rows[0]["col4"].ToString());
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
			strSql.Append("select siId,sicId,itemName,orders,col1,col2,col3,col4 ");
			strSql.Append(" FROM sysItem ");
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
			parameters[0].Value = "sysItem";
			parameters[1].Value = "siId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method

        public int DeleteByCatId(int catId)
        {
            string sql = "delete FROM sysItem where sicId=" + catId;
            return DbHelperOleDb.ExecuteSql(sql);
        }
	}
}

