using System;
namespace WongTung.Model
{
	/// <summary>
	/// ʵ����employee ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class employee
	{
		public employee()
		{}
		#region Model
		private string _emp_co_code;
		private string _emp_code;
		private string _emp_name;
		private string _emp_pos_code;
		private string _emp_dep_code;
		private string _emp_initial;
		private string _emp_office;
		private string _emp_chname;
		private string _emp_spe;
		private DateTime _emp_cre_date;
		private string _emp_del;
		/// <summary>
		/// 
		/// </summary>
		public string EMP_CO_CODE
		{
			set{ _emp_co_code=value;}
			get{return _emp_co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMP_CODE
		{
			set{ _emp_code=value;}
			get{return _emp_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMP_NAME
		{
			set{ _emp_name=value;}
			get{return _emp_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMP_POS_CODE
		{
			set{ _emp_pos_code=value;}
			get{return _emp_pos_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMP_DEP_CODE
		{
			set{ _emp_dep_code=value;}
			get{return _emp_dep_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMP_INITIAL
		{
			set{ _emp_initial=value;}
			get{return _emp_initial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMP_OFFICE
		{
			set{ _emp_office=value;}
			get{return _emp_office;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMP_CHNAME
		{
			set{ _emp_chname=value;}
			get{return _emp_chname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMP_SPE
		{
			set{ _emp_spe=value;}
			get{return _emp_spe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EMP_CRE_DATE
		{
			set{ _emp_cre_date=value;}
			get{return _emp_cre_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMP_DEL
		{
			set{ _emp_del=value;}
			get{return _emp_del;}
		}
		#endregion Model

	}
}

