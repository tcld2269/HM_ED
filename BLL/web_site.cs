using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// web_site
	/// </summary>
	public partial class web_site
	{
		private readonly hm.DAL.web_site dal=new hm.DAL.web_site();
		public web_site()
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
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.web_site model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.web_site model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.web_site GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.web_site GetModelByCache(int ID)
		{
			
			string CacheKey = "web_siteModel-" + ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (hm.Model.web_site)objModel;
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
		public List<hm.Model.web_site> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.web_site> DataTableToList(DataTable dt)
		{
			List<hm.Model.web_site> modelList = new List<hm.Model.web_site>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.web_site model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.web_site();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["webName"]!=null && dt.Rows[n]["webName"].ToString()!="")
					{
					model.webName=dt.Rows[n]["webName"].ToString();
					}
					if(dt.Rows[n]["title"]!=null && dt.Rows[n]["title"].ToString()!="")
					{
					model.title=dt.Rows[n]["title"].ToString();
					}
					if(dt.Rows[n]["keywords"]!=null && dt.Rows[n]["keywords"].ToString()!="")
					{
					model.keywords=dt.Rows[n]["keywords"].ToString();
					}
					if(dt.Rows[n]["description"]!=null && dt.Rows[n]["description"].ToString()!="")
					{
					model.description=dt.Rows[n]["description"].ToString();
					}
					if(dt.Rows[n]["logo"]!=null && dt.Rows[n]["logo"].ToString()!="")
					{
					model.logo=dt.Rows[n]["logo"].ToString();
					}
					if(dt.Rows[n]["bottom"]!=null && dt.Rows[n]["bottom"].ToString()!="")
					{
					model.bottom=dt.Rows[n]["bottom"].ToString();
					}
					if(dt.Rows[n]["qq"]!=null && dt.Rows[n]["qq"].ToString()!="")
					{
					model.qq=dt.Rows[n]["qq"].ToString();
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
	}
}

