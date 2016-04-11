using System;
namespace hm.Model
{
	/// <summary>
	/// ed_node:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ed_node
	{
		public ed_node()
		{}
		#region Model
		private int _id;
		private int? _parentid;
		private string _title;
		private string _pic;
		private string _url;
		private int? _types;
		private int? _orders;
		private int? _isshow;
        private int? _models;
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
		public int? parentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
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
		public string pic
		{
			set{ _pic=value;}
			get{return _pic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string url
		{
			set{ _url=value;}
			get{return _url;}
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
		public int? orders
		{
			set{ _orders=value;}
			get{return _orders;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isShow
		{
			set{ _isshow=value;}
			get{return _isshow;}
		}
        public int? models
		{
            set { _models = value; }
            get { return _models; }
		}
        
		#endregion Model

	}
}

