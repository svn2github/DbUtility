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
	/// ҵ���߼���temp_all_app ��ժҪ˵����
	/// </summary>
	public class temp_all_app
	{
		private readonly Itemp_all_app dal=DataAccess.Createtemp_all_app();
		public temp_all_app()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.temp_all_app model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.temp_all_app model)
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
		public WongTung.Model.temp_all_app GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.temp_all_app GetModelByCache()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			string CacheKey = "temp_all_appModel-" ;
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
			return (WongTung.Model.temp_all_app)objModel;
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
		public List<WongTung.Model.temp_all_app> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.temp_all_app> modelList = new List<WongTung.Model.temp_all_app>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.temp_all_app model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.temp_all_app();
					model.TEM_CO_CODE=ds.Tables[0].Rows[n]["TEM_CO_CODE"].ToString();
					model.TEM_STAFF_CODE=ds.Tables[0].Rows[n]["TEM_STAFF_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["TEM_WORK_DATE"].ToString()!="")
					{
						model.TEM_WORK_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["TEM_WORK_DATE"].ToString());
					}
					if(ds.Tables[0].Rows[n]["TEM_LINE_NO"].ToString()!="")
					{
						model.TEM_LINE_NO=int.Parse(ds.Tables[0].Rows[n]["TEM_LINE_NO"].ToString());
					}
					model.TEM_HOUR_TYPE=ds.Tables[0].Rows[n]["TEM_HOUR_TYPE"].ToString();
					model.TEM_APP_CODE=ds.Tables[0].Rows[n]["TEM_APP_CODE"].ToString();
					model.TEM_SER_CODE=ds.Tables[0].Rows[n]["TEM_SER_CODE"].ToString();
					model.TEM_JOB_CODE=ds.Tables[0].Rows[n]["TEM_JOB_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["TEM_BF_SUM"].ToString()!="")
					{
						model.TEM_BF_SUM=decimal.Parse(ds.Tables[0].Rows[n]["TEM_BF_SUM"].ToString());
					}
					if(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_0"].ToString()!="")
					{
						model.TEM_NOR_HOUR_0=decimal.Parse(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_0"].ToString());
					}
					if(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_1"].ToString()!="")
					{
						model.TEM_NOR_HOUR_1=decimal.Parse(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_1"].ToString());
					}
					if(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_2"].ToString()!="")
					{
						model.TEM_NOR_HOUR_2=decimal.Parse(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_2"].ToString());
					}
					if(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_3"].ToString()!="")
					{
						model.TEM_NOR_HOUR_3=decimal.Parse(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_3"].ToString());
					}
					if(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_4"].ToString()!="")
					{
						model.TEM_NOR_HOUR_4=decimal.Parse(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_4"].ToString());
					}
					if(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_5"].ToString()!="")
					{
						model.TEM_NOR_HOUR_5=decimal.Parse(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_5"].ToString());
					}
					if(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_6"].ToString()!="")
					{
						model.TEM_NOR_HOUR_6=decimal.Parse(ds.Tables[0].Rows[n]["TEM_NOR_HOUR_6"].ToString());
					}
					model.TEM_TYPE=ds.Tables[0].Rows[n]["TEM_TYPE"].ToString();
					model.TEM_APP_FLAG=ds.Tables[0].Rows[n]["TEM_APP_FLAG"].ToString();
					model.TEM_QUE=ds.Tables[0].Rows[n]["TEM_QUE"].ToString();
					model.TEM_POS_CODE=ds.Tables[0].Rows[n]["TEM_POS_CODE"].ToString();
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

