using System;
using System.Reflection;
using System.Configuration;
namespace WongTung.DALFactory
{
	/// <summary>
    /// Abstract Factory pattern to create the DAL��
    /// ��������ﴴ�����󱨴�����web.config���Ƿ��޸���<add key="DAL" value="Maticsoft.SQLServerDAL" />��
	/// </summary>
	public sealed class DataAccess
	{
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];        
		public DataAccess()
		{ }

        #region CreateObject 

		//��ʹ�û���
        private static object CreateObjectNoCache(string AssemblyPath,string classNamespace)
		{		
			try
			{
				object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);	
				return objType;
			}
			catch//(System.Exception ex)
			{
				//string str=ex.Message;// ��¼������־
				return null;
			}			
			
        }
		//ʹ�û���
		private static object CreateObject(string AssemblyPath,string classNamespace)
		{			
			object objType = DataCache.GetCache(classNamespace);
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);					
					DataCache.SetCache(classNamespace, objType);// д�뻺��
				}
				catch//(System.Exception ex)
				{
					//string str=ex.Message;// ��¼������־
				}
			}
			return objType;
		}
        #endregion

        #region CreateSysManage
        public static WongTung.IDAL.ISysManage CreateSysManage()
		{
			//��ʽ1			
			//return (WongTung.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");

			//��ʽ2 			
			string classNamespace = AssemblyPath+".SysManage";	
			object objType=CreateObject(AssemblyPath,classNamespace);
            return (WongTung.IDAL.ISysManage)objType;		
		}
		#endregion
             
        
   
		/// <summary>
		/// ����backdate���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ibackdate Createbackdate()
		{

			string ClassNamespace = AssemblyPath +".backdate";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ibackdate)objType;
		}

		/// <summary>
		/// ����backspecial���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ibackspecial Createbackspecial()
		{

			string ClassNamespace = AssemblyPath +".backspecial";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ibackspecial)objType;
		}

		/// <summary>
		/// ����bk_jobbud���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ibk_jobbud Createbk_jobbud()
		{

			string ClassNamespace = AssemblyPath +".bk_jobbud";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ibk_jobbud)objType;
		}

		/// <summary>
		/// ����budgetot���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ibudgetot Createbudgetot()
		{

			string ClassNamespace = AssemblyPath +".budgetot";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ibudgetot)objType;
		}

		/// <summary>
		/// ����changepw���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ichangepw Createchangepw()
		{

			string ClassNamespace = AssemblyPath +".changepw";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ichangepw)objType;
		}

		/// <summary>
		/// ����company���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Icompany Createcompany()
		{

			string ClassNamespace = AssemblyPath +".company";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Icompany)objType;
		}

		/// <summary>
		/// ����dailyts���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Idailyts Createdailyts()
		{

			string ClassNamespace = AssemblyPath +".dailyts";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Idailyts)objType;
		}

		/// <summary>
		/// ����dailyts_hist���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Idailyts_hist Createdailyts_hist()
		{

			string ClassNamespace = AssemblyPath +".dailyts_hist";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Idailyts_hist)objType;
		}

		/// <summary>
		/// ����department���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Idepartment Createdepartment()
		{

			string ClassNamespace = AssemblyPath +".department";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Idepartment)objType;
		}

		/// <summary>
		/// ����emp_day_tem���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iemp_day_tem Createemp_day_tem()
		{

			string ClassNamespace = AssemblyPath +".emp_day_tem";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iemp_day_tem)objType;
		}

		/// <summary>
		/// ����emp_job_tem���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iemp_job_tem Createemp_job_tem()
		{

			string ClassNamespace = AssemblyPath +".emp_job_tem";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iemp_job_tem)objType;
		}

		/// <summary>
		/// ����employee���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iemployee Createemployee()
		{

			string ClassNamespace = AssemblyPath +".employee";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iemployee)objType;
		}

		/// <summary>
		/// ����holiday���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iholiday Createholiday()
		{

			string ClassNamespace = AssemblyPath +".holiday";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iholiday)objType;
		}

		/// <summary>
		/// ����holiday_date���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iholiday_date Createholiday_date()
		{

			string ClassNamespace = AssemblyPath +".holiday_date";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iholiday_date)objType;
		}

		/// <summary>
		/// ����icpinq���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iicpinq Createicpinq()
		{

			string ClassNamespace = AssemblyPath +".icpinq";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iicpinq)objType;
		}

		/// <summary>
		/// ����incomts���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iincomts Createincomts()
		{

			string ClassNamespace = AssemblyPath +".incomts";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iincomts)objType;
		}

		/// <summary>
		/// ����incomts_hist���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iincomts_hist Createincomts_hist()
		{

			string ClassNamespace = AssemblyPath +".incomts_hist";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iincomts_hist)objType;
		}

		/// <summary>
		/// ����job���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ijob Createjob()
		{

			string ClassNamespace = AssemblyPath +".job";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ijob)objType;
		}

		/// <summary>
		/// ����jobbud���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ijobbud Createjobbud()
		{

			string ClassNamespace = AssemblyPath +".jobbud";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ijobbud)objType;
		}

		/// <summary>
		/// ����leave_bak���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ileave_bak Createleave_bak()
		{

			string ClassNamespace = AssemblyPath +".leave_bak";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ileave_bak)objType;
		}

		/// <summary>
		/// ����nocontrol���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Inocontrol Createnocontrol()
		{

			string ClassNamespace = AssemblyPath +".nocontrol";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Inocontrol)objType;
		}

		/// <summary>
		/// ����non���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Inon Createnon()
		{

			string ClassNamespace = AssemblyPath +".non";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Inon)objType;
		}

		/// <summary>
		/// ����non_hist���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Inon_hist Createnon_hist()
		{

			string ClassNamespace = AssemblyPath +".non_hist";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Inon_hist)objType;
		}

		/// <summary>
		/// ����offices���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ioffices Createoffices()
		{

			string ClassNamespace = AssemblyPath +".offices";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ioffices)objType;
		}

		/// <summary>
		/// ����outstanding_temp���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ioutstanding_temp Createoutstanding_temp()
		{

			string ClassNamespace = AssemblyPath +".outstanding_temp";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ioutstanding_temp)objType;
		}

		/// <summary>
		/// ����pat_job_tem���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ipat_job_tem Createpat_job_tem()
		{

			string ClassNamespace = AssemblyPath +".pat_job_tem";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ipat_job_tem)objType;
		}

		/// <summary>
		/// ����plan_emp���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iplan_emp Createplan_emp()
		{

			string ClassNamespace = AssemblyPath +".plan_emp";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iplan_emp)objType;
		}

		/// <summary>
		/// ����plan_pos���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iplan_pos Createplan_pos()
		{

			string ClassNamespace = AssemblyPath +".plan_pos";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iplan_pos)objType;
		}

		/// <summary>
		/// ����position���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iposition Createposition()
		{

			string ClassNamespace = AssemblyPath +".position";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iposition)objType;
		}

		/// <summary>
		/// ����prriod���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iprriod Createprriod()
		{

			string ClassNamespace = AssemblyPath +".prriod";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iprriod)objType;
		}

		/// <summary>
		/// ����ptl_job_tem���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iptl_job_tem Createptl_job_tem()
		{

			string ClassNamespace = AssemblyPath +".ptl_job_tem";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iptl_job_tem)objType;
		}

		/// <summary>
		/// ����servicetype���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iservicetype Createservicetype()
		{

			string ClassNamespace = AssemblyPath +".servicetype";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iservicetype)objType;
		}

		/// <summary>
		/// ����spe_endorse���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Ispe_endorse Createspe_endorse()
		{

			string ClassNamespace = AssemblyPath +".spe_endorse";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Ispe_endorse)objType;
		}

		/// <summary>
		/// ����temp_all_app���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Itemp_all_app Createtemp_all_app()
		{

			string ClassNamespace = AssemblyPath +".temp_all_app";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Itemp_all_app)objType;
		}

		/// <summary>
		/// ����temp_day_inq���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Itemp_day_inq Createtemp_day_inq()
		{

			string ClassNamespace = AssemblyPath +".temp_day_inq";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Itemp_day_inq)objType;
		}

		/// <summary>
		/// ����update_time���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iupdate_time Createupdate_time()
		{

			string ClassNamespace = AssemblyPath +".update_time";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iupdate_time)objType;
		}

		/// <summary>
		/// ����userinf���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iuserinf Createuserinf()
		{

			string ClassNamespace = AssemblyPath +".userinf";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iuserinf)objType;
		}

		/// <summary>
		/// ����worknatrue���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iworknatrue Createworknatrue()
		{

			string ClassNamespace = AssemblyPath +".worknatrue";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iworknatrue)objType;
		}

		/// <summary>
		/// ����workstage���ݲ�ӿ�
		/// </summary>
		public static WongTung.IDAL.Iworkstage Createworkstage()
		{

			string ClassNamespace = AssemblyPath +".workstage";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (WongTung.IDAL.Iworkstage)objType;
		}

}
}