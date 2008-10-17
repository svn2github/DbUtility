using System;
using TableMapping;
namespace WongTung.Entity.Table.Model
{
	/// <summary>
	/// ʵ����icpinq ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class icpinq
	{
		public icpinq()
		{}
		#region Model
		private string _icp_co_code;
		private string _icp_office_code;
		private string _icp_office_name;
		private string _icp_emp_code;
		private string _icp_emp_name;
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("ICP_CO_CODE", "", typeof(string))]
		public string ICP_CO_CODE
		{
			set{ _icp_co_code=value;}
			get{return _icp_co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("ICP_OFFICE_CODE", "", typeof(string))]
		public string ICP_OFFICE_CODE
		{
			set{ _icp_office_code=value;}
			get{return _icp_office_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("ICP_OFFICE_NAME", "", typeof(string))]
		public string ICP_OFFICE_NAME
		{
			set{ _icp_office_name=value;}
			get{return _icp_office_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("ICP_EMP_CODE", "", typeof(string))]
		public string ICP_EMP_CODE
		{
			set{ _icp_emp_code=value;}
			get{return _icp_emp_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("ICP_EMP_NAME", "", typeof(string))]
		public string ICP_EMP_NAME
		{
			set{ _icp_emp_name=value;}
			get{return _icp_emp_name;}
		}
		#endregion Model

	}
}

