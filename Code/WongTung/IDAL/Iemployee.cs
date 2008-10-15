using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iemployee ��ժҪ˵����
	/// </summary>
	public interface Iemployee
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string EMP_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.employee model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.employee model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string EMP_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.employee GetModel(string EMP_CODE);
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
