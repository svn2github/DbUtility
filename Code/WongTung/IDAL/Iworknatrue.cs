using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iworknatrue ��ժҪ˵����
	/// </summary>
	public interface Iworknatrue
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string WN_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.worknatrue model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.worknatrue model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string WN_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.worknatrue GetModel(string WN_CODE);
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
