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
	/// ҵ���߼���outstanding_temp ��ժҪ˵����
	/// </summary>
	public class outstanding_temp
	{
		private readonly Ioutstanding_temp dal=DataAccess.Createoutstanding_temp();
		public outstanding_temp()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(decimal NUM)
		{
			return dal.Exists(NUM);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.outstanding_temp model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.outstanding_temp model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(decimal NUM)
		{
			
			dal.Delete(NUM);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.outstanding_temp GetModel(decimal NUM)
		{
			
			return dal.GetModel(NUM);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.outstanding_temp GetModelByCache(decimal NUM)
		{
			
			string CacheKey = "outstanding_tempModel-" + NUM;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(NUM);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.outstanding_temp)objModel;
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
		public List<WongTung.Model.outstanding_temp> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.outstanding_temp> modelList = new List<WongTung.Model.outstanding_temp>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.outstanding_temp model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.outstanding_temp();
					if(ds.Tables[0].Rows[n]["NUM"].ToString()!="")
					{
						model.NUM=decimal.Parse(ds.Tables[0].Rows[n]["NUM"].ToString());
					}
					model.OUT_OFF_CODE=ds.Tables[0].Rows[n]["OUT_OFF_CODE"].ToString();
					model.OUT_OFF_NAME=ds.Tables[0].Rows[n]["OUT_OFF_NAME"].ToString();
					model.OUT_EMP_CODE=ds.Tables[0].Rows[n]["OUT_EMP_CODE"].ToString();
					model.OUT_EMP_NAME=ds.Tables[0].Rows[n]["OUT_EMP_NAME"].ToString();
					if(ds.Tables[0].Rows[n]["OUT_DAY"].ToString()!="")
					{
						model.OUT_DAY=DateTime.Parse(ds.Tables[0].Rows[n]["OUT_DAY"].ToString());
					}
					if(ds.Tables[0].Rows[n]["OUT_POS_CLASS"].ToString()!="")
					{
						model.OUT_POS_CLASS=decimal.Parse(ds.Tables[0].Rows[n]["OUT_POS_CLASS"].ToString());
					}
					model.OUT_POS_CODE=ds.Tables[0].Rows[n]["OUT_POS_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["OUT_UPDATE_DATE"].ToString()!="")
					{
						model.OUT_UPDATE_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["OUT_UPDATE_DATE"].ToString());
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

