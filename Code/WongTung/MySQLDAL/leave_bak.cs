using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using WongTung.IDAL;
using Maticsoft.DBUtility;//�����������
namespace WongTung.MySQLDAL
{
	/// <summary>
	/// ���ݷ�����leave_bak��
	/// </summary>
	public class leave_bak:Ileave_bak
	{
		public leave_bak()
		{}
		#region  ��Ա����



		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(WongTung.Model.leave_bak model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into leave_bak(");
			strSql.Append("CO_CODE,LEVAE_CODE,LEVAE_DESC)");
			strSql.Append(" values (");
			strSql.Append("@CO_CODE,@LEVAE_CODE,@LEVAE_DESC)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CO_CODE", MySqlDbType.Char,3),
					new MySqlParameter("@LEVAE_CODE", MySqlDbType.Char,3),
					new MySqlParameter("@LEVAE_DESC", MySqlDbType.Char,100)};
			parameters[0].Value = model.CO_CODE;
			parameters[1].Value = model.LEVAE_CODE;
			parameters[2].Value = model.LEVAE_DESC;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(WongTung.Model.leave_bak model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update leave_bak set ");
			strSql.Append("CO_CODE=@CO_CODE,");
			strSql.Append("LEVAE_CODE=@LEVAE_CODE,");
			strSql.Append("LEVAE_DESC=@LEVAE_DESC");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CO_CODE", MySqlDbType.Char,3),
					new MySqlParameter("@LEVAE_CODE", MySqlDbType.Char,3),
					new MySqlParameter("@LEVAE_DESC", MySqlDbType.Char,100)};
			parameters[0].Value = model.CO_CODE;
			parameters[1].Value = model.LEVAE_CODE;
			parameters[2].Value = model.LEVAE_DESC;

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete leave_bak ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
};

			DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public WongTung.Model.leave_bak GetModel()
		{
			//�ñ���������Ϣ�����Զ�������/�����ֶ�
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select CO_CODE,LEVAE_CODE,LEVAE_DESC from leave_bak ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
};

			WongTung.Model.leave_bak model=new WongTung.Model.leave_bak();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.CO_CODE=ds.Tables[0].Rows[0]["CO_CODE"].ToString();
				model.LEVAE_CODE=ds.Tables[0].Rows[0]["LEVAE_CODE"].ToString();
				model.LEVAE_DESC=ds.Tables[0].Rows[0]["LEVAE_DESC"].ToString();
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
			strSql.Append("select CO_CODE,LEVAE_CODE,LEVAE_DESC ");
			strSql.Append(" FROM leave_bak ");
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
			parameters[0].Value = "leave_bak";
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

