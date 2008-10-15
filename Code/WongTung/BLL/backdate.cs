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
	/// ҵ���߼���backdate ��ժҪ˵����
	/// </summary>
	public class backdate
	{
		private readonly Ibackdate dal=DataAccess.Createbackdate();
		public backdate()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.backdate model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.backdate model)
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
		public WongTung.Model.backdate GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.backdate GetModelByCache()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			string CacheKey = "backdateModel-" ;
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
			return (WongTung.Model.backdate)objModel;
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
		public List<WongTung.Model.backdate> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.backdate> modelList = new List<WongTung.Model.backdate>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.backdate model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.backdate();
					model.BK_CO_CODE=ds.Tables[0].Rows[n]["BK_CO_CODE"].ToString();
					model.BK_USER=ds.Tables[0].Rows[n]["BK_USER"].ToString();
					model.BK_RAN_NO=ds.Tables[0].Rows[n]["BK_RAN_NO"].ToString();
					model.BK_EMP=ds.Tables[0].Rows[n]["BK_EMP"].ToString();
					if(ds.Tables[0].Rows[n]["BK_RAN_DATE"].ToString()!="")
					{
						model.BK_RAN_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["BK_RAN_DATE"].ToString());
					}
					if(ds.Tables[0].Rows[n]["BK_CRE_DATE"].ToString()!="")
					{
						model.BK_CRE_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["BK_CRE_DATE"].ToString());
					}
					model.BK_STATUS=ds.Tables[0].Rows[n]["BK_STATUS"].ToString();
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

