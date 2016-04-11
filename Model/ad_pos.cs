using System;
namespace hm.Model
{
	/// <summary>
	/// ad_pos:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ad_pos
	{
		public ad_pos()
		{}
		#region Model
		private int _id;
		private string _title;
		private int? _types;
		private int? _width;
		private int? _height;
		private int? _click;
		/// <summary>
		/// 
		/// </summary>
		public int id
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
		public int? types
		{
			set{ _types=value;}
			get{return _types;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? width
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? height
		{
			set{ _height=value;}
			get{return _height;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? click
		{
			set{ _click=value;}
			get{return _click;}
		}
		#endregion Model

	}
}

