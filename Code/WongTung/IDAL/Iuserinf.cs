using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iuserinf ��ժҪ˵����
	/// </summary>
	public interface Iuserinf
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string USER_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.userinf model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.userinf model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string USER_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.userinf GetModel(string USER_CODE);
		/// <summary>
		/// ��������б�
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// ���ݷ�ҳ��������б�
		/// </summary>
//		DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  ��Ա����
	}
}
