using System;
using TableMapping;
namespace WongTung.Entity.Table.Model
{
	/// <summary>
	/// ʵ����workstage ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class workstage
	{
		public workstage()
		{}
		#region Model
		private string _wt_co_code;
		private string _wt_code;
		private string _wt_desc;
		private string _wt_desc_t;
		private string _wt_desc_s;
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("WT_CO_CODE", "", typeof(string))]
		public string WT_CO_CODE
		{
			set{ _wt_co_code=value;}
			get{return _wt_co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("WT_CODE", "", typeof(string))]
		public string WT_CODE
		{
			set{ _wt_code=value;}
			get{return _wt_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("WT_DESC", "", typeof(string))]
		public string WT_DESC
		{
			set{ _wt_desc=value;}
			get{return _wt_desc;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("WT_DESC_T", "", typeof(string))]
		public string WT_DESC_T
		{
			set{ _wt_desc_t=value;}
			get{return _wt_desc_t;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("WT_DESC_S", "", typeof(string))]
		public string WT_DESC_S
		{
			set{ _wt_desc_s=value;}
			get{return _wt_desc_s;}
		}
		#endregion Model

	}
}

