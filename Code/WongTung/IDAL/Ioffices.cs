using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Ioffices ��ժҪ˵����
	/// </summary>
	public interface Ioffices
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string OFF_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.offices model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.offices model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string OFF_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.offices GetModel(string OFF_CODE);
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
