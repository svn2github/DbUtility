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
	/// ҵ���߼���employee ��ժҪ˵����
	/// </summary>
	public class employee
	{
		private readonly Iemployee dal=DataAccess.Createemployee();
		public employee()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string EMP_CODE)
		{
			return dal.Exists(EMP_CODE);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.employee model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.employee model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string EMP_CODE)
		{
			
			dal.Delete(EMP_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.employee GetModel(string EMP_CODE)
		{
			
			return dal.GetModel(EMP_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.employee GetModelByCache(string EMP_CODE)
		{
			
			string CacheKey = "employeeModel-" + EMP_CODE;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(EMP_CODE);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.employee)objModel;
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
		public List<WongTung.Model.employee> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.employee> modelList = new List<WongTung.Model.employee>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.employee model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.employee();
					model.EMP_CO_CODE=ds.Tables[0].Rows[n]["EMP_CO_CODE"].ToString();
					model.EMP_CODE=ds.Tables[0].Rows[n]["EMP_CODE"].ToString();
					model.EMP_NAME=ds.Tables[0].Rows[n]["EMP_NAME"].ToString();
					model.EMP_POS_CODE=ds.Tables[0].Rows[n]["EMP_POS_CODE"].ToString();
					model.EMP_DEP_CODE=ds.Tables[0].Rows[n]["EMP_DEP_CODE"].ToString();
					model.EMP_INITIAL=ds.Tables[0].Rows[n]["EMP_INITIAL"].ToString();
					model.EMP_OFFICE=ds.Tables[0].Rows[n]["EMP_OFFICE"].ToString();
					model.EMP_CHNAME=ds.Tables[0].Rows[n]["EMP_CHNAME"].ToString();
					model.EMP_SPE=ds.Tables[0].Rows[n]["EMP_SPE"].ToString();
					if(ds.Tables[0].Rows[n]["EMP_CRE_DATE"].ToString()!="")
					{
						model.EMP_CRE_DATE=DateTime.Parse(ds.Tables[0].Rows[n]["EMP_CRE_DATE"].ToString());
					}
					model.EMP_DEL=ds.Tables[0].Rows[n]["EMP_DEL"].ToString();
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

