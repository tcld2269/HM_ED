using System;
namespace hm.Model
{
	/// <summary>
	/// web_site:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class web_site
	{
		public web_site()
		{}
		#region Model
		private int _id;
		private string _webname;
		private string _title;
		private string _keywords;
		private string _description;
		private string _logo;
		private string _bottom;
		private string _qq;
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
		public string webName
		{
			set{ _webname=value;}
			get{return _webname;}
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
		public string keywords
		{
			set{ _keywords=value;}
			get{return _keywords;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string logo
		{
			set{ _logo=value;}
			get{return _logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bottom
		{
			set{ _bottom=value;}
			get{return _bottom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		#endregion Model

	}
}

