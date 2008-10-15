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
	/// ҵ���߼���update_time ��ժҪ˵����
	/// </summary>
	public class update_time
	{
		private readonly Iupdate_time dal=DataAccess.Createupdate_time();
		public update_time()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string UT_CODE)
		{
			return dal.Exists(UT_CODE);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.update_time model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.update_time model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string UT_CODE)
		{
			
			dal.Delete(UT_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.update_time GetModel(string UT_CODE)
		{
			
			return dal.GetModel(UT_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.update_time GetModelByCache(string UT_CODE)
		{
			
			string CacheKey = "update_timeModel-" + UT_CODE;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(UT_CODE);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.update_time)objModel;
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
		public List<WongTung.Model.update_time> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.update_time> modelList = new List<WongTung.Model.update_time>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.update_time model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.update_time();
					model.UT_CODE=ds.Tables[0].Rows[n]["UT_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["UT_DATE"].ToString()!="")
					{
						model.UT_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["UT_DATE"].ToString());
					}
					model.UT_TIME=ds.Tables[0].Rows[n]["UT_TIME"].ToString();
					if(ds.Tables[0].Rows[n]["UT_FRE"].ToString()!="")
					{
						model.UT_FRE=int.Parse(ds.Tables[0].Rows[n]["UT_FRE"].ToString());
					}
					model.UT_UPDATE_USER=ds.Tables[0].Rows[n]["UT_UPDATE_USER"].ToString();
					if(ds.Tables[0].Rows[n]["UT_UPDATE_DT"].ToString()!="")
					{
						model.UT_UPDATE_DT=DateTime.Parse(ds.Tables[0].Rows[n]["UT_UPDATE_DT"].ToString());
					}
					model.UT_INF=ds.Tables[0].Rows[n]["UT_INF"].ToString();
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

