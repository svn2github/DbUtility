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
	/// ҵ���߼���backspecial ��ժҪ˵����
	/// </summary>
	public class backspecial
	{
		private readonly Ibackspecial dal=DataAccess.Createbackspecial();
		public backspecial()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string BS_CODE)
		{
			return dal.Exists(BS_CODE);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.backspecial model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.backspecial model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string BS_CODE)
		{
			
			dal.Delete(BS_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.backspecial GetModel(string BS_CODE)
		{
			
			return dal.GetModel(BS_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.backspecial GetModelByCache(string BS_CODE)
		{
			
			string CacheKey = "backspecialModel-" + BS_CODE;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(BS_CODE);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.backspecial)objModel;
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
		public List<WongTung.Model.backspecial> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.backspecial> modelList = new List<WongTung.Model.backspecial>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.backspecial model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.backspecial();
					model.BS_CO_CODE=ds.Tables[0].Rows[n]["BS_CO_CODE"].ToString();
					model.BS_CODE=ds.Tables[0].Rows[n]["BS_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["BS_DATE"].ToString()!="")
					{
						model.BS_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["BS_DATE"].ToString());
					}
					if(ds.Tables[0].Rows[n]["BS_CURDATE"].ToString()!="")
					{
						model.BS_CURDATE=DateTime.Parse(ds.Tables[0].Rows[n]["BS_CURDATE"].ToString());
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

