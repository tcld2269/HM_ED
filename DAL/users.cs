﻿using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:users
	/// </summary>
	public partial class users
	{
		public users()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("userId", "users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from users");
			strSql.Append(" where userId=@userId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@userId", OleDbType.Integer,4)
};
			parameters[0].Value = userId;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into users(");
			strSql.Append("userName,[password],trueName,nickName,address,deptId,deptName,roleId,roleName,sex,tel,email,qq,score,studyType,addTime,lastLoginTime,isAdmin,status)");
			strSql.Append(" values (");
			strSql.Append("@userName,@password,@trueName,@nickName,@address,@deptId,@deptName,@roleId,@roleName,@sex,@tel,@email,@qq,@score,@studyType,@addTime,@lastLoginTime,@isAdmin,@status)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@userName", OleDbType.VarChar,100),
					new OleDbParameter("@password", OleDbType.VarChar,100),
					new OleDbParameter("@trueName", OleDbType.VarChar,100),
					new OleDbParameter("@nickName", OleDbType.VarChar,100),
					new OleDbParameter("@address", OleDbType.VarChar,100),
					new OleDbParameter("@deptId", OleDbType.Integer,4),
					new OleDbParameter("@deptName", OleDbType.VarChar,100),
					new OleDbParameter("@roleId", OleDbType.Integer,4),
					new OleDbParameter("@roleName", OleDbType.VarChar,100),
					new OleDbParameter("@sex", OleDbType.Integer,4),
					new OleDbParameter("@tel", OleDbType.VarChar,100),
					new OleDbParameter("@email", OleDbType.VarChar,100),
					new OleDbParameter("@qq", OleDbType.VarChar,100),
					new OleDbParameter("@score", OleDbType.Integer,4),
					new OleDbParameter("@studyType", OleDbType.Integer,4),
					new OleDbParameter("@addTime", OleDbType.Date),
					new OleDbParameter("@lastLoginTime", OleDbType.Date),
					new OleDbParameter("@isAdmin", OleDbType.Integer,4),
					new OleDbParameter("@status", OleDbType.Integer,4)};
			parameters[0].Value = model.userName;
			parameters[1].Value = model.password;
			parameters[2].Value = model.trueName;
			parameters[3].Value = model.nickName;
			parameters[4].Value = model.address;
			parameters[5].Value = model.deptId;
			parameters[6].Value = model.deptName;
			parameters[7].Value = model.roleId;
			parameters[8].Value = model.roleName;
			parameters[9].Value = model.sex;
			parameters[10].Value = model.tel;
			parameters[11].Value = model.email;
			parameters[12].Value = model.qq;
			parameters[13].Value = model.score;
			parameters[14].Value = model.studyType;
			parameters[15].Value = model.addTime;
			parameters[16].Value = model.lastLoginTime;
			parameters[17].Value = model.isAdmin;
			parameters[18].Value = model.status;

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
		public bool Update(hm.Model.users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update users set ");
			strSql.Append("userName=@userName,");
			strSql.Append("[password]=@password,");
			strSql.Append("trueName=@trueName,");
			strSql.Append("nickName=@nickName,");
			strSql.Append("address=@address,");
			strSql.Append("deptId=@deptId,");
			strSql.Append("deptName=@deptName,");
			strSql.Append("roleId=@roleId,");
			strSql.Append("roleName=@roleName,");
			strSql.Append("sex=@sex,");
			strSql.Append("tel=@tel,");
			strSql.Append("email=@email,");
			strSql.Append("qq=@qq,");
			strSql.Append("score=@score,");
			strSql.Append("studyType=@studyType,");
			strSql.Append("addTime=@addTime,");
			strSql.Append("lastLoginTime=@lastLoginTime,");
			strSql.Append("isAdmin=@isAdmin,");
			strSql.Append("status=@status");
			strSql.Append(" where userId=@userId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@userName", OleDbType.VarChar,100),
					new OleDbParameter("@password", OleDbType.VarChar,100),
					new OleDbParameter("@trueName", OleDbType.VarChar,100),
					new OleDbParameter("@nickName", OleDbType.VarChar,100),
					new OleDbParameter("@address", OleDbType.VarChar,100),
					new OleDbParameter("@deptId", OleDbType.Integer,4),
					new OleDbParameter("@deptName", OleDbType.VarChar,100),
					new OleDbParameter("@roleId", OleDbType.Integer,4),
					new OleDbParameter("@roleName", OleDbType.VarChar,100),
					new OleDbParameter("@sex", OleDbType.Integer,4),
					new OleDbParameter("@tel", OleDbType.VarChar,100),
					new OleDbParameter("@email", OleDbType.VarChar,100),
					new OleDbParameter("@qq", OleDbType.VarChar,100),
					new OleDbParameter("@score", OleDbType.Integer,4),
					new OleDbParameter("@studyType", OleDbType.Integer,4),
					new OleDbParameter("@addTime", OleDbType.Date),
					new OleDbParameter("@lastLoginTime", OleDbType.Date),
					new OleDbParameter("@isAdmin", OleDbType.Integer,4),
					new OleDbParameter("@status", OleDbType.Integer,4),
					new OleDbParameter("@userId", OleDbType.Integer,4)};
			parameters[0].Value = model.userName;
			parameters[1].Value = model.password;
			parameters[2].Value = model.trueName;
            if(string.IsNullOrEmpty(model.nickName))
            { model.nickName = " "; }
            parameters[3].Value = model.nickName;
            if (string.IsNullOrEmpty(model.address))
            { model.address = " "; }
			parameters[4].Value = model.address;
			parameters[5].Value = model.deptId;
			parameters[6].Value = model.deptName;
			parameters[7].Value = model.roleId;
			parameters[8].Value = model.roleName;
			parameters[9].Value = model.sex;
			parameters[10].Value = model.tel;
			parameters[11].Value = model.email;
			parameters[12].Value = model.qq;
			parameters[13].Value = model.score;
			parameters[14].Value = model.studyType;
			parameters[15].Value = model.addTime;
			parameters[16].Value = model.lastLoginTime;
			parameters[17].Value = model.isAdmin;
			parameters[18].Value = model.status;
			parameters[19].Value = model.userId;

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
		public bool Delete(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from users ");
			strSql.Append(" where userId=@userId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@userId", OleDbType.Integer,4)
};
			parameters[0].Value = userId;

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
		public bool DeleteList(string userIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from users ");
			strSql.Append(" where userId in ("+userIdlist + ")  ");
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
		public hm.Model.users GetModel(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select userId,userName,password,trueName,nickName,address,deptId,deptName,roleId,roleName,sex,tel,email,qq,score,studyType,addTime,lastLoginTime,isAdmin,status from users ");
			strSql.Append(" where userId=@userId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@userId", OleDbType.Integer,4)
};
			parameters[0].Value = userId;

			hm.Model.users model=new hm.Model.users();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["userId"]!=null && ds.Tables[0].Rows[0]["userId"].ToString()!="")
				{
					model.userId=int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["userName"]!=null && ds.Tables[0].Rows[0]["userName"].ToString()!="")
				{
					model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["password"]!=null && ds.Tables[0].Rows[0]["password"].ToString()!="")
				{
					model.password=ds.Tables[0].Rows[0]["password"].ToString();
				}
				if(ds.Tables[0].Rows[0]["trueName"]!=null && ds.Tables[0].Rows[0]["trueName"].ToString()!="")
				{
					model.trueName=ds.Tables[0].Rows[0]["trueName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["nickName"]!=null && ds.Tables[0].Rows[0]["nickName"].ToString()!="")
				{
					model.nickName=ds.Tables[0].Rows[0]["nickName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["address"]!=null && ds.Tables[0].Rows[0]["address"].ToString()!="")
				{
					model.address=ds.Tables[0].Rows[0]["address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["deptId"]!=null && ds.Tables[0].Rows[0]["deptId"].ToString()!="")
				{
					model.deptId=int.Parse(ds.Tables[0].Rows[0]["deptId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["deptName"]!=null && ds.Tables[0].Rows[0]["deptName"].ToString()!="")
				{
					model.deptName=ds.Tables[0].Rows[0]["deptName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["roleId"]!=null && ds.Tables[0].Rows[0]["roleId"].ToString()!="")
				{
					model.roleId=int.Parse(ds.Tables[0].Rows[0]["roleId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["roleName"]!=null && ds.Tables[0].Rows[0]["roleName"].ToString()!="")
				{
					model.roleName=ds.Tables[0].Rows[0]["roleName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sex"]!=null && ds.Tables[0].Rows[0]["sex"].ToString()!="")
				{
					model.sex=int.Parse(ds.Tables[0].Rows[0]["sex"].ToString());
				}
				if(ds.Tables[0].Rows[0]["tel"]!=null && ds.Tables[0].Rows[0]["tel"].ToString()!="")
				{
					model.tel=ds.Tables[0].Rows[0]["tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["email"]!=null && ds.Tables[0].Rows[0]["email"].ToString()!="")
				{
					model.email=ds.Tables[0].Rows[0]["email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["qq"]!=null && ds.Tables[0].Rows[0]["qq"].ToString()!="")
				{
					model.qq=ds.Tables[0].Rows[0]["qq"].ToString();
				}
				if(ds.Tables[0].Rows[0]["score"]!=null && ds.Tables[0].Rows[0]["score"].ToString()!="")
				{
					model.score=int.Parse(ds.Tables[0].Rows[0]["score"].ToString());
				}
				if(ds.Tables[0].Rows[0]["studyType"]!=null && ds.Tables[0].Rows[0]["studyType"].ToString()!="")
				{
					model.studyType=int.Parse(ds.Tables[0].Rows[0]["studyType"].ToString());
				}
				if(ds.Tables[0].Rows[0]["addTime"]!=null && ds.Tables[0].Rows[0]["addTime"].ToString()!="")
				{
					model.addTime=DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["lastLoginTime"]!=null && ds.Tables[0].Rows[0]["lastLoginTime"].ToString()!="")
				{
					model.lastLoginTime=DateTime.Parse(ds.Tables[0].Rows[0]["lastLoginTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isAdmin"]!=null && ds.Tables[0].Rows[0]["isAdmin"].ToString()!="")
				{
					model.isAdmin=int.Parse(ds.Tables[0].Rows[0]["isAdmin"].ToString());
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
			strSql.Append("select userId,userName,[password],trueName,nickName,address,deptId,deptName,roleId,roleName,sex,tel,email,qq,score,studyType,addTime,lastLoginTime,isAdmin,status ");
			strSql.Append(" FROM users ");
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
			parameters[0].Value = "users";
			parameters[1].Value = "userId";
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

