using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Iplan_pos ��ժҪ˵����
	/// </summary>
	public interface Iplan_pos
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string PLA_POS_CO,string PLA_POS_OFF,string PLA_POS_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.plan_pos model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.plan_pos model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string PLA_POS_CO,string PLA_POS_OFF,string PLA_POS_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.plan_pos GetModel(string PLA_POS_CO,string PLA_POS_OFF,string PLA_POS_CODE);
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
