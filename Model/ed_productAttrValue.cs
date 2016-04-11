using System;
namespace hm.Model
{
	/// <summary>
	/// ed_productAttrValue:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ed_productAttrValue
	{
		public ed_productAttrValue()
		{}
		#region Model
		private int _id;
		private int? _productid;
		private int? _attributeid;
		private string _attributevalue;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? productId
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? attributeId
		{
			set{ _attributeid=value;}
			get{return _attributeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string attributeValue
		{
			set{ _attributevalue=value;}
			get{return _attributevalue;}
		}
		#endregion Model

	}
}

