using System;
using WongTung.DBUtility.TableMapping;
namespace WongTung.Entity.Table
{
	/// <summary>
	/// 实体类plan_pos 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class plan_pos : iTable
	{
		public plan_pos()
		{}
		public enum Fields
		{
			PLA_POS_CO,
			PLA_POS_OFF,
			PLA_POS_CODE,
			PLA_POS_NUM,
			PLA_POS_NOR,
			PLA_POS_OT1,
			PLA_POS_OT2,
			PLA_POS_OT3,
			PLA_POS_T1,
			PLA_POS_T2,
			PLA_POS_T3,
		}

		public static string TableName
		{
			get { return "plan_pos"; }
		}

		#region Model
		private String _pla_pos_co;
		private String _pla_pos_off;
		private String _pla_pos_code;
		private Int32 _pla_pos_num;
		private Decimal _pla_pos_nor;
		private Decimal _pla_pos_ot1;
		private Decimal _pla_pos_ot2;
		private Decimal _pla_pos_ot3;
		private Decimal _pla_pos_t1;
		private Decimal _pla_pos_t2;
		private Decimal _pla_pos_t3;
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_CO", TypeCode.String)]
		public String PLA_POS_CO
		{
			set{ _pla_pos_co=value;}
			get{return _pla_pos_co;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_OFF", TypeCode.String)]
		public String PLA_POS_OFF
		{
			set{ _pla_pos_off=value;}
			get{return _pla_pos_off;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_CODE", TypeCode.String)]
		public String PLA_POS_CODE
		{
			set{ _pla_pos_code=value;}
			get{return _pla_pos_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_NUM", TypeCode.Int32)]
		public Int32 PLA_POS_NUM
		{
			set{ _pla_pos_num=value;}
			get{return _pla_pos_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_NOR", TypeCode.Decimal)]
		public Decimal PLA_POS_NOR
		{
			set{ _pla_pos_nor=value;}
			get{return _pla_pos_nor;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_OT1", TypeCode.Decimal)]
		public Decimal PLA_POS_OT1
		{
			set{ _pla_pos_ot1=value;}
			get{return _pla_pos_ot1;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_OT2", TypeCode.Decimal)]
		public Decimal PLA_POS_OT2
		{
			set{ _pla_pos_ot2=value;}
			get{return _pla_pos_ot2;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_OT3", TypeCode.Decimal)]
		public Decimal PLA_POS_OT3
		{
			set{ _pla_pos_ot3=value;}
			get{return _pla_pos_ot3;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_T1", TypeCode.Decimal)]
		public Decimal PLA_POS_T1
		{
			set{ _pla_pos_t1=value;}
			get{return _pla_pos_t1;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_T2", TypeCode.Decimal)]
		public Decimal PLA_POS_T2
		{
			set{ _pla_pos_t2=value;}
			get{return _pla_pos_t2;}
		}
		/// <summary>
		/// 
		/// </summary>
		[FieldMapping("PLA_POS_T3", TypeCode.Decimal)]
		public Decimal PLA_POS_T3
		{
			set{ _pla_pos_t3=value;}
			get{return _pla_pos_t3;}
		}
		#endregion Model

	}
}

