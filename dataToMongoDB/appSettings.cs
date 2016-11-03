using System.Configuration;

namespace dataToMongoDB
{
    class appSettings
    {
        
        public string sqlServerConnection
        {
            get { return ConfigurationManager.AppSettings["sqlServerConnection"]; }
        }
    public string sqlServerDatabase
        {
            get
            { return ConfigurationManager.AppSettings["sqlServerDatabase"];
            }
        }
        public string sqlServerTable
        {
            get
            { return ConfigurationManager.AppSettings["sqlServerTable"];
            }
        }
        public string sqlServerKey
        {
            get
            { return ConfigurationManager.AppSettings["sqlServerKey"];
            }
        }

        public string sqlServerScript
        {
            get
            {
                return ConfigurationManager.AppSettings["sqlServerScript"];
            }
        }

        public string mysqlServerConnection
        {
            get
            { return ConfigurationManager.AppSettings["mysqlServerConnection"];
            }
        }
        public string mysqlServerDatabase
        {
            get
            { return ConfigurationManager.AppSettings["mysqlServerDatabase"];
            }
        }
        public string mysqlServerTable
        {
            get
            { return ConfigurationManager.AppSettings["mysqlServerTable"];
            }
        }
        public string mysqlServerKey
        {
            get
            { return ConfigurationManager.AppSettings["mysqlServerKey"];
            }
        }

        public string mongoDBServerConnection
        {
            get
            { return ConfigurationManager.AppSettings["mongoDBServerConnection"];
            }
        }
        public string mongoDBServerDatabase
        {
            get
            { return ConfigurationManager.AppSettings["mongoDBServerDatabase"];
            }
        }
        public string mongoDBServerTable
        {
            get
            { return ConfigurationManager.AppSettings["mongoDBServerTable"];
            }
        }

        public string mongoDBServerTransformationTable
        {
            get
            {
                return ConfigurationManager.AppSettings["mongoDBServerTranformationTable"];
            }
        }
        public string mongoDBServerKey
        {
            get
            { return ConfigurationManager.AppSettings[" mongoDBServerKey"]; }
        }

        public string folderPath
        {
            get
            { return ConfigurationManager.AppSettings["folderPath"]; }
        }



    }
}
