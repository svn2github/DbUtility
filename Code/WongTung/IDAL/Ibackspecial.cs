using System;
using System.Data;
namespace WongTung.IDAL
{
	/// <summary>
	/// �ӿڲ�Ibackspecial ��ժҪ˵����
	/// </summary>
	public interface Ibackspecial
	{
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(string BS_CODE);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(WongTung.Model.backspecial model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(WongTung.Model.backspecial model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(string BS_CODE);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		WongTung.Model.backspecial GetModel(string BS_CODE);
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
