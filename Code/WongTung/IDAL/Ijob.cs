using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Ijob ��ժҪ˵����
	/// </summary>
	public interface Ijob
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string JOB_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.job model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.job model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string JOB_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.job GetModel(string JOB_CODE);
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
