using System;
using WongTung.DBUtility.TableMapping;
namespace WongTung.Entity.Table
{
	/// <summary>
	/// ʵ����offices ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class offices
	{
		public offices()
		{}
		#region Model
		private string _off_co_code;
		private string _off_code;
		private string _off_name;
		private string _off_endorse;
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OFF_CO_CODE", TypeCode.String)]
		public string OFF_CO_CODE
		{
			set{ _off_co_code=value;}
			get{return _off_co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OFF_CODE", TypeCode.String)]
		public string OFF_CODE
		{
			set{ _off_code=value;}
			get{return _off_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OFF_NAME", TypeCode.String)]
		public string OFF_NAME
		{
			set{ _off_name=value;}
			get{return _off_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("OFF_ENDORSE", TypeCode.String)]
		public string OFF_ENDORSE
		{
			set{ _off_endorse=value;}
			get{return _off_endorse;}
		}
		#endregion Model

	}
}

