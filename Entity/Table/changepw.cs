using System;
using WongTung.DBUtility.TableMapping;
namespace WongTung.Entity.Table
{
	/// <summary>
	/// ʵ����changepw ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	public class changepw
	{
		public changepw()
		{}
		#region Model
		private string _cp_co_code;
		private string _cp_user_code;
		private string _cp_new_pwd;
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("CP_CO_CODE", TypeCode.String)]
		public string CP_CO_CODE
		{
			set{ _cp_co_code=value;}
			get{return _cp_co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("CP_USER_CODE", TypeCode.String)]
		public string CP_USER_CODE
		{
			set{ _cp_user_code=value;}
			get{return _cp_user_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("CP_NEW_PWD", TypeCode.String)]
		public string CP_NEW_PWD
		{
			set{ _cp_new_pwd=value;}
			get{return _cp_new_pwd;}
		}
		#endregion Model

	}
}

