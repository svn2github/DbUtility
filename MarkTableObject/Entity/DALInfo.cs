﻿using System;
using System.Collections.Generic;
using System.Text;

namespace hwj.MarkTableObject.Entity
{
    public class DALInfo
    {
        public EntityInfo EntityInfo { get; set; }
        public string Namespace { get; set; }
        public string FileName { get; set; }
        public DatabaseEnum ConnType { get; set; }
        public DBModule Module { get; set; }
        /// <summary>
        /// 前缀字符
        /// </summary>
        public string PrefixChar { get; set; }
        public string DALName { get; set; }

        public DALInfo(ProjectInfo prjInfo, DBModule module, string tableName)
        {
            EntityInfo = new EntityInfo(prjInfo, module, tableName);
            Namespace = prjInfo.DataAccessNamespace;
            ConnType = prjInfo.Database.DatabaseType;
            Module = module;
            PrefixChar = prjInfo.DataAccessPrefixChar;

            DALName = PrefixChar + tableName;
            FileName = string.Format("{0}\\{1}.cs", prjInfo.DataAccessPath.TrimEnd('\\'), DALName);
        }
    }
}
