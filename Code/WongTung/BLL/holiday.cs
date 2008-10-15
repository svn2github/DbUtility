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
	/// ҵ���߼���holiday ��ժҪ˵����
	/// </summary>
	public class holiday
	{
		private readonly Iholiday dal=DataAccess.Createholiday();
		public holiday()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.holiday model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.holiday model)
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
		public WongTung.Model.holiday GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.holiday GetModelByCache()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			string CacheKey = "holidayModel-" ;
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
			return (WongTung.Model.holiday)objModel;
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
		public List<WongTung.Model.holiday> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.holiday> modelList = new List<WongTung.Model.holiday>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.holiday model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.holiday();
					model.HD_CO_CODE=ds.Tables[0].Rows[n]["HD_CO_CODE"].ToString();
					model.HD_EMP_CODE=ds.Tables[0].Rows[n]["HD_EMP_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["HD_LINE_NO"].ToString()!="")
					{
						model.HD_LINE_NO=decimal.Parse(ds.Tables[0].Rows[n]["HD_LINE_NO"].ToString());
					}
					if(ds.Tables[0].Rows[n]["HD_DATE"].ToString()!="")
					{
						model.HD_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["HD_DATE"].ToString());
					}
					model.HD_LEVE_CODE=ds.Tables[0].Rows[n]["HD_LEVE_CODE"].ToString();
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

