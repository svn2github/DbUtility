using System;
using WongTung.DBUtility.TableMapping;
namespace WongTung.Entity.Table
{
	/// <summary>
	/// 实体类backspecial 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class backspecial : iTable
	{
		public backspecial()
		{}
		public enum Fields
		{
			BS_CO_CODE,
			BS_CODE,
			BS_DATE,
			BS_CURDATE,
		}

		public static string TableName
		{
			get { return "backspecial"; }
		}

		#region Model
		private String _bs_co_code;
		private String _bs_code;
		private DateTime? _bs_date;
		private DateTime? _bs_curdate;
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BS_CO_CODE", TypeCode.String)]
		public String BS_CO_CODE
		{
			set{ _bs_co_code=value;}
			get{return _bs_co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BS_CODE", TypeCode.String)]
		public String BS_CODE
		{
			set{ _bs_code=value;}
			get{return _bs_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BS_DATE", TypeCode.DateTime)]
		public DateTime? BS_DATE
		{
			set{ _bs_date=value;}
			get{return _bs_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BS_CURDATE", TypeCode.DateTime)]
		public DateTime? BS_CURDATE
		{
			set{ _bs_curdate=value;}
			get{return _bs_curdate;}
		}
		#endregion Model

	}
}

