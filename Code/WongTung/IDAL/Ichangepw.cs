using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Ichangepw ��ժҪ˵����
	/// </summary>
	public interface Ichangepw
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string CP_USER_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.changepw model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.changepw model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string CP_USER_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.changepw GetModel(string CP_USER_CODE);
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
