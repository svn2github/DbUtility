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
	/// ҵ���߼���servicetype ��ժҪ˵����
	/// </summary>
	public class servicetype
	{
		private readonly Iservicetype dal=DataAccess.Createservicetype();
		public servicetype()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.servicetype model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.servicetype model)
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
		public WongTung.Model.servicetype GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.servicetype GetModelByCache()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			string CacheKey = "servicetypeModel-" ;
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
			return (WongTung.Model.servicetype)objModel;
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
		public List<WongTung.Model.servicetype> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.servicetype> modelList = new List<WongTung.Model.servicetype>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.servicetype model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.servicetype();
					model.ST_CO_CODE=ds.Tables[0].Rows[n]["ST_CO_CODE"].ToString();
					model.ST_JOB_CODE=ds.Tables[0].Rows[n]["ST_JOB_CODE"].ToString();
					model.ST_SER_CODE=ds.Tables[0].Rows[n]["ST_SER_CODE"].ToString();
					model.ST_DESC=ds.Tables[0].Rows[n]["ST_DESC"].ToString();
					model.ST_DESC1=ds.Tables[0].Rows[n]["ST_DESC1"].ToString();
					model.ST_DESC_T1=ds.Tables[0].Rows[n]["ST_DESC_T1"].ToString();
					model.ST_DESC_S1=ds.Tables[0].Rows[n]["ST_DESC_S1"].ToString();
					model.ST_DESC_T2=ds.Tables[0].Rows[n]["ST_DESC_T2"].ToString();
					model.ST_DESC_S2=ds.Tables[0].Rows[n]["ST_DESC_S2"].ToString();
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

