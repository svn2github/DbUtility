using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Ibk_jobbud ��ժҪ˵����
	/// </summary>
	public interface Ibk_jobbud
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string JOB_CO_CODE,string JOB_CODE,string JOB_SER,string JOB_STAFF);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.bk_jobbud model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.bk_jobbud model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string JOB_CO_CODE,string JOB_CODE,string JOB_SER,string JOB_STAFF);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.bk_jobbud GetModel(string JOB_CO_CODE,string JOB_CODE,string JOB_SER,string JOB_STAFF);
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
