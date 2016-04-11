using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using hm.Model;
namespace hm.BLL
{
	/// <summary>
	/// ed_productAttrValue
	/// </summary>
	public partial class ed_productAttrValue
	{
		private readonly hm.DAL.ed_productAttrValue dal=new hm.DAL.ed_productAttrValue();
		public ed_productAttrValue()
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
		public bool Add(hm.Model.ed_productAttrValue model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.ed_productAttrValue model)
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
		public hm.Model.ed_productAttrValue GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public hm.Model.ed_productAttrValue GetModelByCache(int ID)
		{
			
			string CacheKey = "ed_productAttrValueModel-" + ID;
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
			return (hm.Model.ed_productAttrValue)objModel;
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
		public List<hm.Model.ed_productAttrValue> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<hm.Model.ed_productAttrValue> DataTableToList(DataTable dt)
		{
			List<hm.Model.ed_productAttrValue> modelList = new List<hm.Model.ed_productAttrValue>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				hm.Model.ed_productAttrValue model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new hm.Model.ed_productAttrValue();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["productId"]!=null && dt.Rows[n]["productId"].ToString()!="")
					{
						model.productId=int.Parse(dt.Rows[n]["productId"].ToString());
					}
					if(dt.Rows[n]["attributeId"]!=null && dt.Rows[n]["attributeId"].ToString()!="")
					{
						model.attributeId=int.Parse(dt.Rows[n]["attributeId"].ToString());
					}
					if(dt.Rows[n]["attributeValue"]!=null && dt.Rows[n]["attributeValue"].ToString()!="")
					{
					model.attributeValue=dt.Rows[n]["attributeValue"].ToString();
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

