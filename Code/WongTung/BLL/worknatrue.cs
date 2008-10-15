using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using WongTung.Model;
using WongTung.DALFactory;
using WongTung.IDAL;
namespace WongTung.BLL
{
	/// <summary>
	/// ҵ���߼���worknatrue ��ժҪ˵����
	/// </summary>
	public class worknatrue
	{
		private readonly Iworknatrue dal=DataAccess.Createworknatrue();
		public worknatrue()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string WN_CODE)
		{
			return dal.Exists(WN_CODE);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.worknatrue model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.worknatrue model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string WN_CODE)
		{
			
			dal.Delete(WN_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.worknatrue GetModel(string WN_CODE)
		{
			
			return dal.GetModel(WN_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.worknatrue GetModelByCache(string WN_CODE)
		{
			
			string CacheKey = "worknatrueModel-" + WN_CODE;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(WN_CODE);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.worknatrue)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<WongTung.Model.worknatrue> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.worknatrue> modelList = new List<WongTung.Model.worknatrue>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.worknatrue model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.worknatrue();
					model.WN_CO_CODE=ds.Tables[0].Rows[n]["WN_CO_CODE"].ToString();
					model.WN_CODE=ds.Tables[0].Rows[n]["WN_CODE"].ToString();
					model.WN_DESC=ds.Tables[0].Rows[n]["WN_DESC"].ToString();
					model.WN_DESC_T=ds.Tables[0].Rows[n]["WN_DESC_T"].ToString();
					model.WN_DESC_S=ds.Tables[0].Rows[n]["WN_DESC_S"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

