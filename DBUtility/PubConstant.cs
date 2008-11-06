using System;
using System.Configuration;

namespace hwj.DBUtility
{

    public class PubConstant
    {
        /// <summary>
        /// ��ȡ�����ַ���
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = WongTung.Common.WebConfig.WongTungConnection;
                if (WongTung.Common.WebConfig.ConnectionStringEncrypt)
                {
                    _connectionString = DESEncrypt.Decrypt(_connectionString);
                }
                return _connectionString;
            }
        }

        /// <summary>
        /// �õ�web.config������������ݿ������ַ�����
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            if (WongTung.Common.WebConfig.ConnectionStringEncrypt)
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }

        private static Enums.DBType _DatabaseType;
        public static Enums.DBType DatabaseType
        {
            get
            {
                if (_DatabaseType == Enums.DBType.None)
                {
                    switch (WongTung.Common.WebConfig.DatabaseTypeString)
                    {
                        case "MYSQL":
                            _DatabaseType = Enums.DBType.MySql;
                            break;
                        case "MSSQL":
                            _DatabaseType = Enums.DBType.MsSql;
                            break;
                        default:
                            throw new Exception("Invalid database type");
                    };
                }
                return _DatabaseType;
            }
        }
    }
}
