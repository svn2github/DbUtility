using System;
using System.Collections.Generic;
using System.Text;
using LTP.Utility;
using LTP.CodeHelper;
namespace LTP.BuilderModel
{
    /// <summary>
    /// Model�����������
    /// </summary>
    public class BuilderModel : IBuilder.IBuilderModel
    {
        #region ��������
        protected string _modelname = ""; //model����
        protected string _namespace = "Maticsoft"; //���������ռ���
        protected string _modelpath = "";//ʵ����������ռ�
        protected List<ColumnInfo> _fieldlist;

        /// <summary>
        /// ���������ռ��� 
        /// </summary>        
        public string NameSpace
        {
            set { _namespace = value; }
            get { return _namespace; }
        }
        /// <summary>
        /// ʵ����������ռ�
        /// </summary>
        public string Modelpath
        {
            set { _modelpath = value; }
            get { return _modelpath; }
        }
        /// <summary>
        /// model����
        /// </summary>
        public string ModelName
        {
            set { _modelname = value; }
            get { return _modelname; }
        }
        /// <summary>
        /// ѡ����ֶμ���
        /// </summary>
        public List<ColumnInfo> Fieldlist
        {
            set { _fieldlist = value; }
            get { return _fieldlist; }
        }

        #endregion

        public BuilderModel()
        {
        }

        #region ��������Model��
        /// <summary>
        /// ��������sModel��
        /// </summary>		
        public string CreatModel()
        {
            StringPlus strclass = new StringPlus();
            strclass.AppendLine("using System;");
            strclass.AppendLine("using System.Collections.Generic;");
            strclass.AppendLine("using System.Data;");
            strclass.AppendLine("using hwj.DBUtility;");
            strclass.AppendLine("using hwj.DBUtility.Entity;");
            strclass.AppendLine("using hwj.DBUtility.TableMapping;");
            strclass.AppendLine("");
            strclass.AppendLine("namespace " + Modelpath.Replace("Model", "Entity"));
            strclass.AppendLine("{");
            strclass.AppendSpaceLine(1, "/// <summary>");
            strclass.AppendSpaceLine(1, "/// ʵ����" + _modelname + " ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)");
            strclass.AppendSpaceLine(1, "/// </summary>");
            strclass.AppendSpaceLine(1, "[Serializable]");
            strclass.AppendSpaceLine(1, "public class " + _modelname + " : BaseTable<" + _modelname + ">");
            strclass.AppendSpaceLine(1, "{");
            strclass.AppendSpaceLine(2, "public " + _modelname + "()");
            strclass.AppendSpaceLine(3, ": base(DBTableName)");
            strclass.AppendSpaceLine(2, "{");
            //strclass.AppendSpaceLine(3, "base.DBTableName = DBTableName;");
            strclass.AppendSpaceLine(2, "}");
            strclass.AppendLine(CreatTableName(_modelname));
            strclass.AppendLine(CreatFieldsEnum());
            strclass.AppendLine(CreatModelMethod());
            strclass.AppendSpaceLine(1, "}");
            strclass.AppendSpaceLine(1, "public class " + _modelname + "s : BaseList<" + _modelname + ", " + _modelname + "s> { }");
            strclass.AppendSpaceLine(1, "public class " + _modelname + "Page : PageResult<" + _modelname + ", " + _modelname + "s> { }");
            strclass.AppendLine("}");
            strclass.AppendLine("");

            return strclass.ToString();
        }
        #endregion

        #region ����Model���Բ���
        /// <summary>
        /// ����ʵ���������
        /// </summary>
        /// <returns></returns>
        public string CreatModelMethod()
        {
            //������ͼ�ظ��ֶε�����
            string tmpColumnName = string.Empty;
            string sFieldFormat = "[FieldMapping(\"{0}\", {1}{2})]";
            string sFieldFormat_isPK = "[FieldMapping(\"{0}\", {1}, Enums.DataHandle.UnInsert, Enums.DataHandle.UnUpdate{2})]";
            string sUnNull = string.Empty;// ", Enums.DataHandle.UnNull";//��Ҫʱ�ٴ򿪸�����
            string sDescIsPK = "PK";
            string sDescCanNull = "Allow Null";
            string sDescCanntNull = "Un-Null";
            StringPlus strclass = new StringPlus();
            StringPlus strclass1 = new StringPlus();
            StringPlus strclass2 = new StringPlus();

            strclass.AppendSpaceLine(2, "#region Model");
            foreach (ColumnInfo field in Fieldlist)
            {
                if (tmpColumnName != field.ColumnName)
                {
                    string columnName = field.ColumnName;
                    string columnType = field.TypeName;
                    bool IsIdentity = field.IsIdentity;
                    bool ispk = field.IsPK;
                    bool cisnull = field.cisNull;
                    string deText = field.DeText;
                    columnType = CodeCommon.DbTypeToCS(columnType);
                    string isnull = "";
                    if (CodeCommon.isValueType(columnType))
                    {
                        if ((!IsIdentity) && (!ispk) && (cisnull))
                        {
                            //isnull = "?";//����ɿ�����
                        }
                    }

                    strclass1.AppendSpaceLine(2, "private " + SetFirstUpper(columnType) + isnull + " _" + columnName.ToLower() + ";");//˽�б���
                    strclass2.AppendSpaceLine(2, "/// <summary>");
                    strclass2.AppendSpaceLine(2, "/// " + deText + "[" + string.Format("{0}/{1}/{2}({3})/{4}", (ispk ? sDescIsPK : ""), (cisnull ? sDescCanNull : sDescCanntNull), field.TypeName, field.Length, string.IsNullOrEmpty(field.DefaultVal) ? "" : "Default:" + field.DefaultVal).TrimEnd('/').TrimStart('/') + "]");
                    strclass2.AppendSpaceLine(2, "/// </summary>");
                    string _sUnNull = sUnNull;
                    if (cisnull)
                        _sUnNull = string.Empty;
                    if (IsIdentity)
                        strclass2.AppendSpaceLine(2, string.Format(sFieldFormat_isPK, columnName, GetTypeCode(columnType), _sUnNull));
                    else
                        strclass2.AppendSpaceLine(2, string.Format(sFieldFormat, columnName, GetTypeCode(columnType), _sUnNull));
                    strclass2.AppendSpaceLine(2, "public " + SetFirstUpper(columnType) + isnull + " " + columnName);//����
                    strclass2.AppendSpaceLine(2, "{");
                    strclass2.AppendSpaceLine(3, "set{AddAssigned(\"" + columnName + "\");" + " _" + columnName.ToLower() + "=value;}");
                    strclass2.AppendSpaceLine(3, "get{return " + "_" + columnName.ToLower() + ";}");
                    strclass2.AppendSpaceLine(2, "}");
                    //strclass2.AppendSpaceLine(2, "public static string " + columnName);
                    //strclass2.AppendSpaceLine(2, "{");
                    //strclass2.AppendSpaceLine(3, "get{return \"" + columnName.ToString().Trim() + "\";}");
                    //strclass2.AppendSpaceLine(2, "}");
                }
                tmpColumnName = field.ColumnName;
            }
            strclass.Append(strclass1.Value);
            strclass.Append(strclass2.Value);
            strclass.AppendSpaceLine(2, "#endregion Model");

            return strclass.ToString();
        }
        public string CreatFieldsEnum()
        {
            //������ͼ�ظ��ֶε�����
            string tmpColumnName = string.Empty;
            StringPlus strclass = new StringPlus();
            strclass.AppendSpaceLine(2, "public enum Fields");
            strclass.AppendSpaceLine(2, "{");
            foreach (ColumnInfo f in Fieldlist)
            {
                if (tmpColumnName != f.ColumnName)
                {
                    strclass.AppendSpaceLine(3, "/// <summary>");
                    strclass.AppendSpaceLine(3, "///" + f.DeText);
                    strclass.AppendSpaceLine(3, "/// </summary>");
                    strclass.AppendSpaceLine(3, f.ColumnName + ",");
                }
                tmpColumnName = f.ColumnName;
            }
            strclass.AppendSpaceLine(2, "}");
            return strclass.ToString();
        }
        public string CreatTableName(string modelName)
        {
            if (modelName.IndexOf("tb") != -1)
                modelName = modelName.Substring(2);
            StringPlus strclass = new StringPlus();
            strclass.AppendSpaceLine(2, "public const string DBTableName = \"" + modelName + "\";");
            //strclass.AppendSpaceLine(2, "public static string DBTableName");
            //strclass.AppendSpaceLine(2, "{");
            //strclass.AppendSpaceLine(3, "get { return \"" + modelName + "\"; }");
            //strclass.AppendSpaceLine(2, "}");
            return strclass.ToString();
        }
        private string GetTypeCode(string columnType)
        {
            string s = string.Empty;

            s = "DbType." + SetFirstUpper(columnType) + "";
            return s;
        }
        private string SetFirstUpper(string value)
        {
            if (value == "int")
                value = "Int32";
            return value.Substring(0, 1).ToUpper() + value.Substring(1);
        }
        #endregion
    }
}
