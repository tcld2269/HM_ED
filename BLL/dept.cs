﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// dept
	/// </summary>
	public partial class dept
	{
		private readonly hm.DAL.dept dal=new hm.DAL.dept();
		public dept()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int deptId)
		{
			return dal.Exists(deptId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.dept model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.dept model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int deptId)
		{
			
			return dal.Delete(deptId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string deptIdlist )
		{
			return dal.DeleteList(deptIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.dept GetModel(int deptId)
		{
			
			return dal.GetModel(deptId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.dept GetModelByCache(int deptId)
		{
			
			string CacheKey = "deptModel-" + deptId;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(deptId);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.dept)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.dept> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.dept> DataTableToList(DataTable dt)
		{
			List<hm.Model.dept> modelList = new List<hm.Model.dept>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.dept model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.dept();
					if(dt.Rows[n]["deptId"]!=null && dt.Rows[n]["deptId"].ToString()!="")
					{
						model.deptId=int.Parse(dt.Rows[n]["deptId"].ToString());
					}
					if(dt.Rows[n]["parentId"]!=null && dt.Rows[n]["parentId"].ToString()!="")
					{
						model.parentId=int.Parse(dt.Rows[n]["parentId"].ToString());
					}
					if(dt.Rows[n]["deptName"]!=null && dt.Rows[n]["deptName"].ToString()!="")
					{
					model.deptName=dt.Rows[n]["deptName"].ToString();
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
        public string GetAllChild(int placeId)
        {
            string result = "";
            DataTable dt = dal.GetAllChild(placeId);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result += dt.Rows[i]["deptId"].ToString() + ",";
            }
            if (dt.Rows.Count > 0)
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }
	}
}

