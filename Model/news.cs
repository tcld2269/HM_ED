﻿using System;
namespace hm.Model
{
	/// <summary>
	/// news:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class news
	{
		public news()
		{}
		#region Model
		private int _newsid;
		private int? _catid;
		private string _catname;
		private int? _userid;
		private string _username;
		private int? _deptid;
		private string _newstitle;
		private string _summary;
		private string _newscontent;
		private string _picurl;
		private string _videourl;
		private string _contentsource;
		private string _author;
		private DateTime? _addtime;
		private DateTime? _modifytime;
		private int? _status;
		private int? _ishomepage;
		private int? _isslide;
		private int? _istop;
		private string _fileurl1;
		private string _fileurl2;
		private string _fileurl3;
		/// <summary>
		/// 
		/// </summary>
		public int newsId
		{
			set{ _newsid=value;}
			get{return _newsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? catId
		{
			set{ _catid=value;}
			get{return _catid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string catName
		{
			set{ _catname=value;}
			get{return _catname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? userId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? deptId
		{
			set{ _deptid=value;}
			get{return _deptid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string newsTitle
		{
			set{ _newstitle=value;}
			get{return _newstitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string summary
		{
			set{ _summary=value;}
			get{return _summary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string newsContent
		{
			set{ _newscontent=value;}
			get{return _newscontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string picUrl
		{
			set{ _picurl=value;}
			get{return _picurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string videoUrl
		{
			set{ _videourl=value;}
			get{return _videourl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contentSource
		{
			set{ _contentsource=value;}
			get{return _contentsource;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string author
		{
			set{ _author=value;}
			get{return _author;}
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
		public DateTime? modifyTime
		{
			set{ _modifytime=value;}
			get{return _modifytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isHomePage
		{
			set{ _ishomepage=value;}
			get{return _ishomepage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isSlide
		{
			set{ _isslide=value;}
			get{return _isslide;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isTop
		{
			set{ _istop=value;}
			get{return _istop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fileUrl1
		{
			set{ _fileurl1=value;}
			get{return _fileurl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fileUrl2
		{
			set{ _fileurl2=value;}
			get{return _fileurl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fileUrl3
		{
			set{ _fileurl3=value;}
			get{return _fileurl3;}
		}
		#endregion Model

	}
}

