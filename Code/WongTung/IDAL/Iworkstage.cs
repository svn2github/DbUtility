using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iworkstage ��ժҪ˵����
	/// </summary>
	public interface Iworkstage
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string WT_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.workstage model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.workstage model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string WT_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.workstage GetModel(string WT_CODE);
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
