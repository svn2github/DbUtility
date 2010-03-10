﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using hwj.CommonLibrary.Object;
using hwj.MarkTableObject.Entity;

namespace hwj.MarkTableObject.BLL.MSSQL
{
    public class BuilderColumn
    {
        public static ColumnInfos GetColumnInfoForTable(string connectionString, string tableName)
        {
            ColumnInfos list = new ColumnInfos();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(string.Format("SELECT * FROM {0}", tableName), connection);

                connection.Open();
                DataTable tb1 = connection.GetSchema("Columns", new string[] { null, null, tableName });
                DataView dv = tb1.DefaultView;

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.KeyInfo);
                DataTable tb = reader.GetSchemaTable();
                foreach (DataRow r in tb.Rows)
                {
                    ColumnInfo c = BLL.Common.GetColumnInfo(r);
                    c.DataTypeName = BLL.Common.GetStringValue(r["DataTypeName"]);

                    dv.RowFilter = string.Format("COLUMN_NAME='{0}'", c.ColumnName);
                    if (dv.Count > 0)
                    {
                        if (dv[0]["COLUMN_DEFAULT"] != null)
                            c.DefaultValue = dv[0]["COLUMN_DEFAULT"].ToString();
                        //if (dv[0]["DESCRIPTION"] != null)
                        //    c.Description = dv[0]["DESCRIPTION"].ToString();
                    }

                    list.Add(c);
                }
                reader.Close();
            }
            return list;
        }
    }
}
