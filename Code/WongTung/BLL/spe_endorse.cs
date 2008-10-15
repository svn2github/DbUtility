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
	/// ҵ���߼���spe_endorse ��ժҪ˵����
	/// </summary>
	public class spe_endorse
	{
		private readonly Ispe_endorse dal=DataAccess.Createspe_endorse();
		public spe_endorse()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string SPE_CODE)
		{
			return dal.Exists(SPE_CODE);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.spe_endorse model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.spe_endorse model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string SPE_CODE)
		{
			
			dal.Delete(SPE_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.spe_endorse GetModel(string SPE_CODE)
		{
			
			return dal.GetModel(SPE_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.spe_endorse GetModelByCache(string SPE_CODE)
		{
			
			string CacheKey = "spe_endorseModel-" + SPE_CODE;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SPE_CODE);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.spe_endorse)objModel;
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
		public List<WongTung.Model.spe_endorse> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.spe_endorse> modelList = new List<WongTung.Model.spe_endorse>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.spe_endorse model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.spe_endorse();
					model.SPE_CODE=ds.Tables[0].Rows[n]["SPE_CODE"].ToString();
					model.SPE_CRE_EMP=ds.Tables[0].Rows[n]["SPE_CRE_EMP"].ToString();
					if(ds.Tables[0].Rows[n]["SPE_CRE_DATE"].ToString()!="")
					{
						model.SPE_CRE_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["SPE_CRE_DATE"].ToString());
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

