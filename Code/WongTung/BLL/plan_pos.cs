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
	/// ҵ���߼���plan_pos ��ժҪ˵����
	/// </summary>
	public class plan_pos
	{
		private readonly Iplan_pos dal=DataAccess.Createplan_pos();
		public plan_pos()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(string PLA_POS_CO,string PLA_POS_OFF,string PLA_POS_CODE)
		{
			return dal.Exists(PLA_POS_CO,PLA_POS_OFF,PLA_POS_CODE);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.plan_pos model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.plan_pos model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(string PLA_POS_CO,string PLA_POS_OFF,string PLA_POS_CODE)
		{
			
			dal.Delete(PLA_POS_CO,PLA_POS_OFF,PLA_POS_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.plan_pos GetModel(string PLA_POS_CO,string PLA_POS_OFF,string PLA_POS_CODE)
		{
			
			return dal.GetModel(PLA_POS_CO,PLA_POS_OFF,PLA_POS_CODE);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.plan_pos GetModelByCache(string PLA_POS_CO,string PLA_POS_OFF,string PLA_POS_CODE)
		{
			
			string CacheKey = "plan_posModel-" + PLA_POS_CO+PLA_POS_OFF+PLA_POS_CODE;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(PLA_POS_CO,PLA_POS_OFF,PLA_POS_CODE);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (WongTung.Model.plan_pos)objModel;
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
		public List<WongTung.Model.plan_pos> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.plan_pos> modelList = new List<WongTung.Model.plan_pos>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.plan_pos model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.plan_pos();
					model.PLA_POS_CO=ds.Tables[0].Rows[n]["PLA_POS_CO"].ToString();
					model.PLA_POS_OFF=ds.Tables[0].Rows[n]["PLA_POS_OFF"].ToString();
					model.PLA_POS_CODE=ds.Tables[0].Rows[n]["PLA_POS_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["PLA_POS_NUM"].ToString()!="")
					{
						model.PLA_POS_NUM=int.Parse(ds.Tables[0].Rows[n]["PLA_POS_NUM"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_POS_NOR"].ToString()!="")
					{
						model.PLA_POS_NOR=decimal.Parse(ds.Tables[0].Rows[n]["PLA_POS_NOR"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_POS_OT1"].ToString()!="")
					{
						model.PLA_POS_OT1=decimal.Parse(ds.Tables[0].Rows[n]["PLA_POS_OT1"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_POS_OT2"].ToString()!="")
					{
						model.PLA_POS_OT2=decimal.Parse(ds.Tables[0].Rows[n]["PLA_POS_OT2"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_POS_OT3"].ToString()!="")
					{
						model.PLA_POS_OT3=decimal.Parse(ds.Tables[0].Rows[n]["PLA_POS_OT3"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_POS_T1"].ToString()!="")
					{
						model.PLA_POS_T1=decimal.Parse(ds.Tables[0].Rows[n]["PLA_POS_T1"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_POS_T2"].ToString()!="")
					{
						model.PLA_POS_T2=decimal.Parse(ds.Tables[0].Rows[n]["PLA_POS_T2"].ToString());
					}
					if(ds.Tables[0].Rows[n]["PLA_POS_T3"].ToString()!="")
					{
						model.PLA_POS_T3=decimal.Parse(ds.Tables[0].Rows[n]["PLA_POS_T3"].ToString());
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

