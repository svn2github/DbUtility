using System;
using System.Configuration;

namespace hwj.DBUtility
{

    public class PubConstant
    {
        /// <summary>
        /// �õ�web.config������������ݿ������ַ�����(AppSetting)
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName, bool isEncrype)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            if (isEncrype)
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }
        //private static Enums.DBType _DatabaseType;
        //public static Enums.DBType DatabaseType
        //{
        //    get
        //    {
        //        if (_DatabaseType == Enums.DBType.None)
        //        {
        //            switch (WongTung.Common.WebConfig.DatabaseTypeString)
        //            {
        //                case "MYSQL":
        //                    _DatabaseType = Enums.DBType.MySql;
        //                    break;
        //                case "MSSQL":
        //                    _DatabaseType = Enums.DBType.MsSql;
        //                    break;
        //                default:
        //                    throw new Exception("Invalid database type");
        //            };
        //        }
        //        return _DatabaseType;
        //    }
        //}
    }
}
