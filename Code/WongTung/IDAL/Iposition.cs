using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iposition ��ժҪ˵����
	/// </summary>
	public interface Iposition
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string POS_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.position model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.position model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string POS_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.position GetModel(string POS_CODE);
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
