using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iemp_day_tem ��ժҪ˵����
	/// </summary>
	public interface Iemp_day_tem
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string ED_CO_CODE,string ED_EMP_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.emp_day_tem model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.emp_day_tem model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string ED_CO_CODE,string ED_EMP_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.emp_day_tem GetModel(string ED_CO_CODE,string ED_EMP_CODE);
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
