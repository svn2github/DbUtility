using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using WongTung.IDAL;
using Maticsoft.DBUtility;//�����������
namespace WongTung.MySQLDAL
{
	/// <summary>
	/// ���ݷ�����prriod��
	/// </summary>
	public class prriod:Iprriod
	{
		public prriod()
		{}
		#region  ��Ա����



		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.prriod model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into prriod(");
			strSql.Append("PR_CO_CODE,PR_NO,PR_FROM,PR_TO)");
			strSql.Append(" values (");
			strSql.Append("@PR_CO_CODE,@PR_NO,@PR_FROM,@PR_TO)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@PR_CO_CODE", MySqlDbType.Char,3),
					new MySqlParameter("@PR_NO", MySqlDbType.Decimal,18),
					new MySqlParameter("@PR_FROM", MySqlDbType.Char,8),
					new MySqlParameter("@PR_TO", MySqlDbType.Char,8)};
			parameters[0].Value = model.PR_CO_CODE;
			parameters[1].Value = model.PR_NO;
			parameters[2].Value = model.PR_FROM;
			parameters[3].Value = model.PR_TO;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.prriod model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update prriod set ");
			strSql.Append("PR_CO_CODE=@PR_CO_CODE,");
			strSql.Append("PR_NO=@PR_NO,");
			strSql.Append("PR_FROM=@PR_FROM,");
			strSql.Append("PR_TO=@PR_TO");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@PR_CO_CODE", MySqlDbType.Char,3),
					new MySqlParameter("@PR_NO", MySqlDbType.Decimal,18),
					new MySqlParameter("@PR_FROM", MySqlDbType.Char,8),
					new MySqlParameter("@PR_TO", MySqlDbType.Char,8)};
			parameters[0].Value = model.PR_CO_CODE;
			parameters[1].Value = model.PR_NO;
			parameters[2].Value = model.PR_FROM;
			parameters[3].Value = model.PR_TO;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete prriod ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
};

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.prriod GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PR_CO_CODE,PR_NO,PR_FROM,PR_TO from prriod ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
};

			WongTung.Model.prriod model=new WongTung.Model.prriod();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.PR_CO_CODE=ds.Tables[0].Rows[0]["PR_CO_CODE"].ToString();
				if(ds.Tables[0].Rows[0]["PR_NO"].ToString()!="")
				{
					model.PR_NO=decimal.Parse(ds.Tables[0].Rows[0]["PR_NO"].ToString());
				}
				model.PR_FROM=ds.Tables[0].Rows[0]["PR_FROM"].ToString();
				model.PR_TO=ds.Tables[0].Rows[0]["PR_TO"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select PR_CO_CODE,PR_NO,PR_FROM,PR_TO ");
			strSql.Append(" FROM prriod ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "prriod";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  ��Ա����
	}
}

