using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Icompany ��ժҪ˵����
	/// </summary>
	public interface Icompany
	{
		#region  ��Ա����
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.company model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.company model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete();
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.company GetModel();
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
