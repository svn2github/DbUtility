using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Idepartment ��ժҪ˵����
	/// </summary>
	public interface Idepartment
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string DEPT_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.department model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.department model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string DEPT_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.department GetModel(string DEPT_CODE);
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
