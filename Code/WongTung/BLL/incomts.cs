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
	/// ҵ���߼���incomts ��ժҪ˵����
	/// </summary>
	public class incomts
	{
		private readonly Iincomts dal=DataAccess.Createincomts();
		public incomts()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.incomts model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.incomts model)
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
		public WongTung.Model.incomts GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.incomts GetModelByCache()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			string CacheKey = "incomtsModel-" ;
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
			return (WongTung.Model.incomts)objModel;
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
		public List<WongTung.Model.incomts> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.incomts> modelList = new List<WongTung.Model.incomts>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.incomts model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.incomts();
					model.IST_CO_CODE=ds.Tables[0].Rows[n]["IST_CO_CODE"].ToString();
					model.IST_OFFCIE_CODE=ds.Tables[0].Rows[n]["IST_OFFCIE_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["IST_WORK_DATE"].ToString()!="")
					{
						model.IST_WORK_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["IST_WORK_DATE"].ToString());
					}
					model.IST_USER_CODE=ds.Tables[0].Rows[n]["IST_USER_CODE"].ToString();
					model.IST_USER_NAME=ds.Tables[0].Rows[n]["IST_USER_NAME"].ToString();
					model.IST_INPUT_OK=ds.Tables[0].Rows[n]["IST_INPUT_OK"].ToString();
					model.IST_APP=ds.Tables[0].Rows[n]["IST_APP"].ToString();
					if(ds.Tables[0].Rows[n]["IST_NOR_HR"].ToString()!="")
					{
						model.IST_NOR_HR=decimal.Parse(ds.Tables[0].Rows[n]["IST_NOR_HR"].ToString());
					}
					if(ds.Tables[0].Rows[n]["IST_OT_HR"].ToString()!="")
					{
						model.IST_OT_HR=decimal.Parse(ds.Tables[0].Rows[n]["IST_OT_HR"].ToString());
					}
					model.IST_PERIOD=ds.Tables[0].Rows[n]["IST_PERIOD"].ToString();
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

