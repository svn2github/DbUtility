using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iptl_job_tem ��ժҪ˵����
	/// </summary>
	public interface Iptl_job_tem
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string TJ_CO_CODE,string TJ_EMP_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.ptl_job_tem model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.ptl_job_tem model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string TJ_CO_CODE,string TJ_EMP_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.ptl_job_tem GetModel(string TJ_CO_CODE,string TJ_EMP_CODE);
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
