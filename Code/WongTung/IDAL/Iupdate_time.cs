using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iupdate_time ��ժҪ˵����
	/// </summary>
	public interface Iupdate_time
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string UT_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.update_time model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.update_time model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string UT_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.update_time GetModel(string UT_CODE);
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
