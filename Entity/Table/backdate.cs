using System;
using TableMapping;
namespace WongTung.Entity.Table.Model
{
	/// <summary>
	/// ʵ����backdate ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class backdate
	{
		public backdate()
		{}
		#region Model
		private string _bk_co_code;
		private string _bk_user;
		private string _bk_ran_no;
		private string _bk_emp;
		private DateTime _bk_ran_date;
		private DateTime _bk_cre_date;
		private string _bk_status;
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BK_CO_CODE", "", typeof(string))]
		public string BK_CO_CODE
		{
			set{ _bk_co_code=value;}
			get{return _bk_co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BK_USER", "", typeof(string))]
		public string BK_USER
		{
			set{ _bk_user=value;}
			get{return _bk_user;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BK_RAN_NO", "", typeof(string))]
		public string BK_RAN_NO
		{
			set{ _bk_ran_no=value;}
			get{return _bk_ran_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BK_EMP", "", typeof(string))]
		public string BK_EMP
		{
			set{ _bk_emp=value;}
			get{return _bk_emp;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BK_RAN_DATE", "", typeof(DateTime))]
		public DateTime BK_RAN_DATE
		{
			set{ _bk_ran_date=value;}
			get{return _bk_ran_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BK_CRE_DATE", "", typeof(DateTime))]
		public DateTime BK_CRE_DATE
		{
			set{ _bk_cre_date=value;}
			get{return _bk_cre_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("BK_STATUS", "", typeof(string))]
		public string BK_STATUS
		{
			set{ _bk_status=value;}
			get{return _bk_status;}
		}
		#endregion Model

	}
}

