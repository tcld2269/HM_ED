using System;
namespace hm.Model
{
	/// <summary>
	/// ed_product:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ed_product
	{
		public ed_product()
		{}
		#region Model
		private int _id;
		private int? _nodeid;
		private string _title;
		private string _picsmall;
		private string _picbig;
		private string _remark;
		private int? _isrecommend;
		private DateTime? _addtime;
		private int? _status;
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
		public int? nodeId
		{
            set { _nodeid = value; }
            get { return _nodeid; }
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
		public string picSmall
		{
			set{ _picsmall=value;}
			get{return _picsmall;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string picBig
		{
			set{ _picbig=value;}
			get{return _picbig;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isRecommend
		{
			set{ _isrecommend=value;}
			get{return _isrecommend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? addTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

