using System;
namespace WongTung.Model
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
		public string CP_CO_CODE
		{
			set{ _cp_co_code=value;}
			get{return _cp_co_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CP_USER_CODE
		{
			set{ _cp_user_code=value;}
			get{return _cp_user_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CP_NEW_PWD
		{
			set{ _cp_new_pwd=value;}
			get{return _cp_new_pwd;}
		}
		#endregion Model

	}
}

