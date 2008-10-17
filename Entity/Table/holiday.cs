using System;
using TableMapping;
namespace WongTung.Entity.Table.Model
{
	/// <summary>
	/// ʵ����holiday ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class holiday
	{
		public holiday()
		{}
		#region Model
		private string _hd_co_code;
		private string _hd_emp_code;
		private decimal _hd_line_no;
		private DateTime? _hd_date;
		private string _hd_leve_code;
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("HD_CO_CODE", "", typeof(string))]
		public string HD_CO_CODE
		{
			set{ _hd_co_code=value;}
			get{return _hd_co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("HD_EMP_CODE", "", typeof(string))]
		public string HD_EMP_CODE
		{
			set{ _hd_emp_code=value;}
			get{return _hd_emp_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("HD_LINE_NO", "", typeof(decimal))]
		public decimal HD_LINE_NO
		{
			set{ _hd_line_no=value;}
			get{return _hd_line_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("HD_DATE", "", typeof(DateTime))]
		public DateTime? HD_DATE
		{
			set{ _hd_date=value;}
			get{return _hd_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("HD_LEVE_CODE", "", typeof(string))]
		public string HD_LEVE_CODE
		{
			set{ _hd_leve_code=value;}
			get{return _hd_leve_code;}
		}
		#endregion Model

	}
}

