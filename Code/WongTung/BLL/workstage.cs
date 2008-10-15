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
	/// ҵ���߼���workstage ��ժҪ˵����
	/// </summary>
	public class workstage
	{
		private readonly Iworkstage dal=DataAccess.Createworkstage();
		public workstage()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string WT_CODE)
		{
			return dal.Exists(WT_CODE);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.workstage model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.workstage model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string WT_CODE)
		{
			
			dal.Delete(WT_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.workstage GetModel(string WT_CODE)
		{
			
			return dal.GetModel(WT_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.workstage GetModelByCache(string WT_CODE)
		{
			
			string CacheKey = "workstageModel-" + WT_CODE;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(WT_CODE);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.workstage)objModel;
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
		public List<WongTung.Model.workstage> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.workstage> modelList = new List<WongTung.Model.workstage>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.workstage model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.workstage();
					model.WT_CO_CODE=ds.Tables[0].Rows[n]["WT_CO_CODE"].ToString();
					model.WT_CODE=ds.Tables[0].Rows[n]["WT_CODE"].ToString();
					model.WT_DESC=ds.Tables[0].Rows[n]["WT_DESC"].ToString();
					model.WT_DESC_T=ds.Tables[0].Rows[n]["WT_DESC_T"].ToString();
					model.WT_DESC_S=ds.Tables[0].Rows[n]["WT_DESC_S"].ToString();
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

