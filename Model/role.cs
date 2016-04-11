using System;
namespace hm.Model
{
	/// <summary>
	/// role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class role
	{
		public role()
		{}
		#region Model
		private int _roleid;
		private string _rolename;
		/// <summary>
		/// 
		/// </summary>
		public int roleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string roleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		#endregion Model

	}
}

