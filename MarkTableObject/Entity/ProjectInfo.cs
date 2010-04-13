﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace hwj.MarkTableObject.Entity
{
    [Serializable]
    public class ProjectInfo
    {
        public string FileName { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string MainPath { get; set; }

        public string BusinessNamespace { get; set; }
        public string BusinessPath { get; set; }
        public string BusinessPrefixChar { get; set; }
        public string BusinessConnection { get; set; }

        public string DataAccessNamespace { get; set; }
        public string DataAccessPath { get; set; }
        public string DataAccessPrefixChar { get; set; }

        public string EntityNamespace { get; set; }
        public string EntityPath { get; set; }
        public string EntityPrefixChar { get; set; }

        //public string DataSourceName { get; set; }
        public DatabaseInfo Database { get; set; }


        public ProjectInfo()
        {
            
        }

        public void SaveXML()
        {
            string xml = hwj.CommonLibrary.Object.SerializationHelper.SerializeToXml(this);
            Common.CreateFile(this.FileName, xml);
        }
    }
}
