using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Ipat_job_tem ��ժҪ˵����
	/// </summary>
	public interface Ipat_job_tem
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string AJ_CO_CODE,string AJ_EMP_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.pat_job_tem model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.pat_job_tem model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string AJ_CO_CODE,string AJ_EMP_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.pat_job_tem GetModel(string AJ_CO_CODE,string AJ_EMP_CODE);
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
