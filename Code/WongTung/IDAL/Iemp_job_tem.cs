using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iemp_job_tem ��ժҪ˵����
	/// </summary>
	public interface Iemp_job_tem
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string EJ_CO_CODE,string EJ_EMP_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.emp_job_tem model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.emp_job_tem model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string EJ_CO_CODE,string EJ_EMP_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.emp_job_tem GetModel(string EJ_CO_CODE,string EJ_EMP_CODE);
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
