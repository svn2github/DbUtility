using System;
using TableMapping;
namespace WongTung.Entity.Table.Model
{
	/// <summary>
	/// ʵ����leave_bak ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class leave_bak
	{
		public leave_bak()
		{}
		#region Model
		private string _co_code;
		private string _levae_code;
		private string _levae_desc;
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("CO_CODE", "", typeof(string))]
		public string CO_CODE
		{
			set{ _co_code=value;}
			get{return _co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("LEVAE_CODE", "", typeof(string))]
		public string LEVAE_CODE
		{
			set{ _levae_code=value;}
			get{return _levae_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("LEVAE_DESC", "", typeof(string))]
		public string LEVAE_DESC
		{
			set{ _levae_desc=value;}
			get{return _levae_desc;}
		}
		#endregion Model

	}
}

