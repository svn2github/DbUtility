using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iholiday ��ժҪ˵����
	/// </summary>
	public interface Iholiday
	{
		#region  ��Ա����
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.holiday model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.holiday model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete();
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.holiday GetModel();
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
