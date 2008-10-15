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
	/// ҵ���߼���plan_emp ��ժҪ˵����
	/// </summary>
	public class plan_emp
	{
		private readonly Iplan_emp dal=DataAccess.Createplan_emp();
		public plan_emp()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string PLA_EMP_CO,string PLA_EMP_OFF,string PLA_EMP_POS,string PLA_EMP_CODE)
		{
			return dal.Exists(PLA_EMP_CO,PLA_EMP_OFF,PLA_EMP_POS,PLA_EMP_CODE);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.plan_emp model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.plan_emp model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string PLA_EMP_CO,string PLA_EMP_OFF,string PLA_EMP_POS,string PLA_EMP_CODE)
		{
			
			dal.Delete(PLA_EMP_CO,PLA_EMP_OFF,PLA_EMP_POS,PLA_EMP_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.plan_emp GetModel(string PLA_EMP_CO,string PLA_EMP_OFF,string PLA_EMP_POS,string PLA_EMP_CODE)
		{
			
			return dal.GetModel(PLA_EMP_CO,PLA_EMP_OFF,PLA_EMP_POS,PLA_EMP_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.plan_emp GetModelByCache(string PLA_EMP_CO,string PLA_EMP_OFF,string PLA_EMP_POS,string PLA_EMP_CODE)
		{
			
			string CacheKey = "plan_empModel-" + PLA_EMP_CO+PLA_EMP_OFF+PLA_EMP_POS+PLA_EMP_CODE;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(PLA_EMP_CO,PLA_EMP_OFF,PLA_EMP_POS,PLA_EMP_CODE);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.plan_emp)objModel;
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
		public List<WongTung.Model.plan_emp> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.plan_emp> modelList = new List<WongTung.Model.plan_emp>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.plan_emp model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.plan_emp();
					model.PLA_EMP_CO=ds.Tables[0].Rows[n]["PLA_EMP_CO"].ToString();
					model.PLA_EMP_OFF=ds.Tables[0].Rows[n]["PLA_EMP_OFF"].ToString();
					model.PLA_EMP_POS=ds.Tables[0].Rows[n]["PLA_EMP_POS"].ToString();
					model.PLA_EMP_CODE=ds.Tables[0].Rows[n]["PLA_EMP_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["PLA_EMP_NUM"].ToString()!="")
					{
						model.PLA_EMP_NUM=int.Parse(ds.Tables[0].Rows[n]["PLA_EMP_NUM"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_EMP_NOR"].ToString()!="")
					{
						model.PLA_EMP_NOR=decimal.Parse(ds.Tables[0].Rows[n]["PLA_EMP_NOR"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_EMP_OT1"].ToString()!="")
					{
						model.PLA_EMP_OT1=decimal.Parse(ds.Tables[0].Rows[n]["PLA_EMP_OT1"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_EMP_OT2"].ToString()!="")
					{
						model.PLA_EMP_OT2=decimal.Parse(ds.Tables[0].Rows[n]["PLA_EMP_OT2"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_EMP_OT3"].ToString()!="")
					{
						model.PLA_EMP_OT3=decimal.Parse(ds.Tables[0].Rows[n]["PLA_EMP_OT3"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_EMP_T1"].ToString()!="")
					{
						model.PLA_EMP_T1=decimal.Parse(ds.Tables[0].Rows[n]["PLA_EMP_T1"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_EMP_T2"].ToString()!="")
					{
						model.PLA_EMP_T2=decimal.Parse(ds.Tables[0].Rows[n]["PLA_EMP_T2"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_EMP_T3"].ToString()!="")
					{
						model.PLA_EMP_T3=decimal.Parse(ds.Tables[0].Rows[n]["PLA_EMP_T3"].ToString());
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

