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
	/// ҵ���߼���jobbud ��ժҪ˵����
	/// </summary>
	public class jobbud
	{
		private readonly Ijobbud dal=DataAccess.Createjobbud();
		public jobbud()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string JOB_CO_CODE,string JOB_CODE,string JOB_SER,string JOB_POS)
		{
			return dal.Exists(JOB_CO_CODE,JOB_CODE,JOB_SER,JOB_POS);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.jobbud model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.jobbud model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string JOB_CO_CODE,string JOB_CODE,string JOB_SER,string JOB_POS)
		{
			
			dal.Delete(JOB_CO_CODE,JOB_CODE,JOB_SER,JOB_POS);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.jobbud GetModel(string JOB_CO_CODE,string JOB_CODE,string JOB_SER,string JOB_POS)
		{
			
			return dal.GetModel(JOB_CO_CODE,JOB_CODE,JOB_SER,JOB_POS);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.jobbud GetModelByCache(string JOB_CO_CODE,string JOB_CODE,string JOB_SER,string JOB_POS)
		{
			
			string CacheKey = "jobbudModel-" + JOB_CO_CODE+JOB_CODE+JOB_SER+JOB_POS;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(JOB_CO_CODE,JOB_CODE,JOB_SER,JOB_POS);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.jobbud)objModel;
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
		public List<WongTung.Model.jobbud> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.jobbud> modelList = new List<WongTung.Model.jobbud>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.jobbud model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.jobbud();
					model.JOB_CO_CODE=ds.Tables[0].Rows[n]["JOB_CO_CODE"].ToString();
					model.JOB_CODE=ds.Tables[0].Rows[n]["JOB_CODE"].ToString();
					model.JOB_SER=ds.Tables[0].Rows[n]["JOB_SER"].ToString();
					model.JOB_POS=ds.Tables[0].Rows[n]["JOB_POS"].ToString();
					model.JOB_STAFF=ds.Tables[0].Rows[n]["JOB_STAFF"].ToString();
					if(ds.Tables[0].Rows[n]["JOB_BUD"].ToString()!="")
					{
						model.JOB_BUD=decimal.Parse(ds.Tables[0].Rows[n]["JOB_BUD"].ToString());
					}
					if(ds.Tables[0].Rows[n]["JOB_NOR"].ToString()!="")
					{
						model.JOB_NOR=decimal.Parse(ds.Tables[0].Rows[n]["JOB_NOR"].ToString());
					}
					if(ds.Tables[0].Rows[n]["JOB_NOR_EXP"].ToString()!="")
					{
						model.JOB_NOR_EXP=decimal.Parse(ds.Tables[0].Rows[n]["JOB_NOR_EXP"].ToString());
					}
					if(ds.Tables[0].Rows[n]["JOB_OT"].ToString()!="")
					{
						model.JOB_OT=decimal.Parse(ds.Tables[0].Rows[n]["JOB_OT"].ToString());
					}
					if(ds.Tables[0].Rows[n]["JOB_OT_EXP"].ToString()!="")
					{
						model.JOB_OT_EXP=decimal.Parse(ds.Tables[0].Rows[n]["JOB_OT_EXP"].ToString());
					}
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

