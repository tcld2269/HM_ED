using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// ed_node
	/// </summary>
	public partial class ed_node
	{
		private readonly hm.DAL.ed_node dal=new hm.DAL.ed_node();
		public ed_node()
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
		public bool Add(hm.Model.ed_node model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.ed_node model)
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
		public hm.Model.ed_node GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.ed_node GetModelByCache(int ID)
		{
			
			string CacheKey = "ed_nodeModel-" + ID;
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
			return (hm.Model.ed_node)objModel;
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
		public List<hm.Model.ed_node> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.ed_node> DataTableToList(DataTable dt)
		{
			List<hm.Model.ed_node> modelList = new List<hm.Model.ed_node>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.ed_node model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.ed_node();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["parentId"]!=null && dt.Rows[n]["parentId"].ToString()!="")
					{
						model.parentId=int.Parse(dt.Rows[n]["parentId"].ToString());
					}
					if(dt.Rows[n]["title"]!=null && dt.Rows[n]["title"].ToString()!="")
					{
					model.title=dt.Rows[n]["title"].ToString();
					}
					if(dt.Rows[n]["pic"]!=null && dt.Rows[n]["pic"].ToString()!="")
					{
					model.pic=dt.Rows[n]["pic"].ToString();
					}
					if(dt.Rows[n]["url"]!=null && dt.Rows[n]["url"].ToString()!="")
					{
					model.url=dt.Rows[n]["url"].ToString();
					}
					if(dt.Rows[n]["types"]!=null && dt.Rows[n]["types"].ToString()!="")
					{
						model.types=int.Parse(dt.Rows[n]["types"].ToString());
					}
					if(dt.Rows[n]["orders"]!=null && dt.Rows[n]["orders"].ToString()!="")
					{
						model.orders=int.Parse(dt.Rows[n]["orders"].ToString());
					}
					if(dt.Rows[n]["isShow"]!=null && dt.Rows[n]["isShow"].ToString()!="")
					{
						model.isShow=int.Parse(dt.Rows[n]["isShow"].ToString());
					}
                    if (dt.Rows[n]["models"] != null && dt.Rows[n]["models"].ToString() != "")
                    {
                        model.models = int.Parse(dt.Rows[n]["models"].ToString());
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

