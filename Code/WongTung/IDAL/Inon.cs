using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Inon ��ժҪ˵����
	/// </summary>
	public interface Inon
	{
		#region  ��Ա����
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.non model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.non model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete();
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.non GetModel();
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
