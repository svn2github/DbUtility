using System;
using TableMapping;
namespace WongTung.Entity.Table.Model
{
	/// <summary>
	/// ʵ����outstanding_temp ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class outstanding_temp
	{
		public outstanding_temp()
		{}
		#region Model
		private decimal _num;
		private string _out_off_code;
		private string _out_off_name;
		private string _out_emp_code;
		private string _out_emp_name;
		private DateTime? _out_day;
		private decimal? _out_pos_class;
		private string _out_pos_code;
		private DateTime? _out_update_date;
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("NUM", "", typeof(decimal))]
		public decimal NUM
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OUT_OFF_CODE", "", typeof(string))]
		public string OUT_OFF_CODE
		{
			set{ _out_off_code=value;}
			get{return _out_off_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OUT_OFF_NAME", "", typeof(string))]
		public string OUT_OFF_NAME
		{
			set{ _out_off_name=value;}
			get{return _out_off_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OUT_EMP_CODE", "", typeof(string))]
		public string OUT_EMP_CODE
		{
			set{ _out_emp_code=value;}
			get{return _out_emp_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OUT_EMP_NAME", "", typeof(string))]
		public string OUT_EMP_NAME
		{
			set{ _out_emp_name=value;}
			get{return _out_emp_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OUT_DAY", "", typeof(DateTime))]
		public DateTime? OUT_DAY
		{
			set{ _out_day=value;}
			get{return _out_day;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OUT_POS_CLASS", "", typeof(decimal))]
		public decimal? OUT_POS_CLASS
		{
			set{ _out_pos_class=value;}
			get{return _out_pos_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OUT_POS_CODE", "", typeof(string))]
		public string OUT_POS_CODE
		{
			set{ _out_pos_code=value;}
			get{return _out_pos_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OUT_UPDATE_DATE", "", typeof(DateTime))]
		public DateTime? OUT_UPDATE_DATE
		{
			set{ _out_update_date=value;}
			get{return _out_update_date;}
		}
		#endregion Model

	}
}

