using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Ijobbud ��ժҪ˵����
	/// </summary>
	public interface Ijobbud
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string JOB_CO_CODE,string JOB_CODE,string JOB_SER,string JOB_POS);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.jobbud model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.jobbud model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string JOB_CO_CODE,string JOB_CODE,string JOB_SER,string JOB_POS);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.jobbud GetModel(string JOB_CO_CODE,string JOB_CODE,string JOB_SER,string JOB_POS);
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
