using System;
namespace WongTung.Model
{
	/// <summary>
	/// ʵ����nocontrol ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class nocontrol
	{
		public nocontrol()
		{}
		#region Model
		private string _no_co_code;
		private string _no_code;
		private string _no_desc;
		private decimal? _no_sta_no;
		private decimal? _no_seq_no;
		/// <summary>
		/// 
		/// </summary>
		public string NO_CO_CODE
		{
			set{ _no_co_code=value;}
			get{return _no_co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NO_CODE
		{
			set{ _no_code=value;}
			get{return _no_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NO_DESC
		{
			set{ _no_desc=value;}
			get{return _no_desc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? NO_STA_NO
		{
			set{ _no_sta_no=value;}
			get{return _no_sta_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? NO_SEQ_NO
		{
			set{ _no_seq_no=value;}
			get{return _no_seq_no;}
		}
		#endregion Model

	}
}

