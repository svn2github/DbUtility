using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Ispe_endorse ��ժҪ˵����
	/// </summary>
	public interface Ispe_endorse
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string SPE_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.spe_endorse model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.spe_endorse model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string SPE_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.spe_endorse GetModel(string SPE_CODE);
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
