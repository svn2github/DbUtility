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
	/// ҵ���߼���nocontrol ��ժҪ˵����
	/// </summary>
	public class nocontrol
	{
		private readonly Inocontrol dal=DataAccess.Createnocontrol();
		public nocontrol()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.nocontrol model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.nocontrol model)
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
		public WongTung.Model.nocontrol GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.nocontrol GetModelByCache()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			string CacheKey = "nocontrolModel-" ;
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
			return (WongTung.Model.nocontrol)objModel;
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
		public List<WongTung.Model.nocontrol> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.nocontrol> modelList = new List<WongTung.Model.nocontrol>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.nocontrol model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.nocontrol();
					model.NO_CO_CODE=ds.Tables[0].Rows[n]["NO_CO_CODE"].ToString();
					model.NO_CODE=ds.Tables[0].Rows[n]["NO_CODE"].ToString();
					model.NO_DESC=ds.Tables[0].Rows[n]["NO_DESC"].ToString();
					if(ds.Tables[0].Rows[n]["NO_STA_NO"].ToString()!="")
					{
						model.NO_STA_NO=decimal.Parse(ds.Tables[0].Rows[n]["NO_STA_NO"].ToString());
					}
					if(ds.Tables[0].Rows[n]["NO_SEQ_NO"].ToString()!="")
					{
						model.NO_SEQ_NO=decimal.Parse(ds.Tables[0].Rows[n]["NO_SEQ_NO"].ToString());
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

