using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iholiday_date ��ժҪ˵����
	/// </summary>
	public interface Iholiday_date
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string HO_CO_CODE,string HO_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.holiday_date model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.holiday_date model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string HO_CO_CODE,string HO_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.holiday_date GetModel(string HO_CO_CODE,string HO_CODE);
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
