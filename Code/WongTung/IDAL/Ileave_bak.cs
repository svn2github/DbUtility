using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Ileave_bak ��ժҪ˵����
	/// </summary>
	public interface Ileave_bak
	{
		#region  ��Ա����
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.leave_bak model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.leave_bak model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete();
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.leave_bak GetModel();
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
