using System;
namespace hm.Model
{
	/// <summary>
	/// sysItem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sysItem
	{
		public sysItem()
		{}
		#region Model
		private int _siid;
		private int? _sicid;
		private string _itemname;
		private int? _orders;
		private string _col1;
		private string _col2;
		private string _col3;
		private int? _col4;
		/// <summary>
		/// 
		/// </summary>
		public int siId
		{
			set{ _siid=value;}
			get{return _siid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sicId
		{
			set{ _sicid=value;}
			get{return _sicid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string itemName
		{
			set{ _itemname=value;}
			get{return _itemname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? orders
		{
			set{ _orders=value;}
			get{return _orders;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string col1
		{
			set{ _col1=value;}
			get{return _col1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string col2
		{
			set{ _col2=value;}
			get{return _col2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string col3
		{
			set{ _col3=value;}
			get{return _col3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? col4
		{
			set{ _col4=value;}
			get{return _col4;}
		}
		#endregion Model

	}
}

