using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Ioutstanding_temp ��ժҪ˵����
	/// </summary>
	public interface Ioutstanding_temp
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(decimal NUM);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.outstanding_temp model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.outstanding_temp model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(decimal NUM);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.outstanding_temp GetModel(decimal NUM);
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
