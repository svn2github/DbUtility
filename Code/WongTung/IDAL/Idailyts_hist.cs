using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Idailyts_hist ��ժҪ˵����
	/// </summary>
	public interface Idailyts_hist
	{
		#region  ��Ա����
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.dailyts_hist model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.dailyts_hist model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete();
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.dailyts_hist GetModel();
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
