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
	/// ҵ���߼���dailyts ��ժҪ˵����
	/// </summary>
	public class dailyts
	{
		private readonly Idailyts dal=DataAccess.Createdailyts();
		public dailyts()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.dailyts model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.dailyts model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			dal.Delete();
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.dailyts GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.dailyts GetModelByCache()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			string CacheKey = "dailytsModel-" ;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.dailyts)objModel;
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
		public List<WongTung.Model.dailyts> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.dailyts> modelList = new List<WongTung.Model.dailyts>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.dailyts model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.dailyts();
					model.DT_CO_CODE=ds.Tables[0].Rows[n]["DT_CO_CODE"].ToString();
					model.DT_STAFF_CODE=ds.Tables[0].Rows[n]["DT_STAFF_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["DT_WORK_DATE"].ToString()!="")
					{
						model.DT_WORK_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["DT_WORK_DATE"].ToString());
					}
					if(ds.Tables[0].Rows[n]["DT_LINE_NO"].ToString()!="")
					{
						model.DT_LINE_NO=decimal.Parse(ds.Tables[0].Rows[n]["DT_LINE_NO"].ToString());
					}
					model.DT_APP_CODE=ds.Tables[0].Rows[n]["DT_APP_CODE"].ToString();
					model.DT_JOB_CODE=ds.Tables[0].Rows[n]["DT_JOB_CODE"].ToString();
					model.DT_SER_CODE=ds.Tables[0].Rows[n]["DT_SER_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["DT_NOR_HOUR"].ToString()!="")
					{
						model.DT_NOR_HOUR=decimal.Parse(ds.Tables[0].Rows[n]["DT_NOR_HOUR"].ToString());
					}
					if(ds.Tables[0].Rows[n]["DT_OVER_HOUR"].ToString()!="")
					{
						model.DT_OVER_HOUR=decimal.Parse(ds.Tables[0].Rows[n]["DT_OVER_HOUR"].ToString());
					}
					model.DT_TYPE=ds.Tables[0].Rows[n]["DT_TYPE"].ToString();
					model.DT_PERIOD=ds.Tables[0].Rows[n]["DT_PERIOD"].ToString();
					model.DT_SUBMIT=ds.Tables[0].Rows[n]["DT_SUBMIT"].ToString();
					model.DT_UPDATE=ds.Tables[0].Rows[n]["DT_UPDATE"].ToString();
					model.DT_RAMNO=ds.Tables[0].Rows[n]["DT_RAMNO"].ToString();
					if(ds.Tables[0].Rows[n]["DT_UPDATE_DATE"].ToString()!="")
					{
						model.DT_UPDATE_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["DT_UPDATE_DATE"].ToString());
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

