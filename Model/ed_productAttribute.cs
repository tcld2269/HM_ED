using System;
namespace hm.Model
{
	/// <summary>
	/// ed_productAttribute:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ed_productAttribute
	{
		public ed_productAttribute()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _valuelist;
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string valueList
		{
			set{ _valuelist=value;}
			get{return _valuelist;}
		}
		#endregion Model

	}
}

