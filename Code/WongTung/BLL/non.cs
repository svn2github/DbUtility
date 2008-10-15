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
	/// ҵ���߼���non ��ժҪ˵����
	/// </summary>
	public class non
	{
		private readonly Inon dal=DataAccess.Createnon();
		public non()
		{}
		#region  ��Ա����

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.non model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.non model)
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
		public WongTung.Model.non GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			return dal.GetModel();
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public WongTung.Model.non GetModelByCache()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			string CacheKey = "nonModel-" ;
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
			return (WongTung.Model.non)objModel;
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
		public List<WongTung.Model.non> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<WongTung.Model.non> modelList = new List<WongTung.Model.non>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				WongTung.Model.non model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new WongTung.Model.non();
					model.CO_CODE=ds.Tables[0].Rows[n]["CO_CODE"].ToString();
					model.STAFF_CODE=ds.Tables[0].Rows[n]["STAFF_CODE"].ToString();
					if(ds.Tables[0].Rows[n]["DATE"].ToString()!="")
					{
						model.DATE=DateTime.Parse(ds.Tables[0].Rows[n]["DATE"].ToString());
					}
					model.TYPE=ds.Tables[0].Rows[n]["TYPE"].ToString();
					if(ds.Tables[0].Rows[n]["ANNUAL"].ToString()!="")
					{
						model.ANNUAL=decimal.Parse(ds.Tables[0].Rows[n]["ANNUAL"].ToString());
					}
					if(ds.Tables[0].Rows[n]["SICK"].ToString()!="")
					{
						model.SICK=decimal.Parse(ds.Tables[0].Rows[n]["SICK"].ToString());
					}
					if(ds.Tables[0].Rows[n]["ADMIN"].ToString()!="")
					{
						model.ADMIN=decimal.Parse(ds.Tables[0].Rows[n]["ADMIN"].ToString());
					}
					if(ds.Tables[0].Rows[n]["OT_PAY"].ToString()!="")
					{
						model.OT_PAY=decimal.Parse(ds.Tables[0].Rows[n]["OT_PAY"].ToString());
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

